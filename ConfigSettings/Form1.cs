using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ConfigSettings
{
    public partial class frmConfig : Form
    {
        private string oldSettingPath = @".\Config\";
        private string newSettingPath = @".\Config\";
        private Auth auth;
        private Config config;

        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            auth = new Auth();
            config = new Config();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            txtOldConfigPath.Text = oldSettingPath;
            cbxTranslationLanguageCode.SelectedIndex = 2;
            cbxLevelUpByCPOrIv.DataSource = Enum.GetValues(typeof(ConfigSettings.Config.Power));
            cbxLevelUpByCPOrIv.SelectedIndex = 0;
            cbxUpgradePokemonMinimumStatsOperator.DataSource = Enum.GetValues(typeof(ConfigSettings.Config.Operator));
            cbxUpgradePokemonMinimumStatsOperator.SelectedIndex = 0;
            cbxAuthType.DataSource = Enum.GetValues(typeof(ConfigSettings.Auth.Authentication));
            cbxAuthType.SelectedIndex = 0;
            lstvwPokemonsToEvolve.Items.Clear();
            lstvwPokemonsNotToTransfer.Items.Clear();
            for (int i = 0; i < StaticList.PokemonNames.Length; i++)
            {
                lstvwPokemonsToEvolve.Items.Add(StaticList.PokemonIndex[i] + " - " + StaticList.PokemonNames[i]);
                lstvwPokemonsNotToTransfer.Items.Add(StaticList.PokemonIndex[i] + " - " + StaticList.PokemonNames[i]);
                lstvwPokemonsToIgnore.Items.Add(StaticList.PokemonIndex[i] + " - " + StaticList.PokemonNames[i]);
                lstvwPokemonToUseMasterball.Items.Add(StaticList.PokemonIndex[i] + " - " + StaticList.PokemonNames[i]);
                lstvwPokemon.Items.Add(StaticList.PokemonIndex[i] + " - " + StaticList.PokemonNames[i]);
            }
            cbxKeepMinOperator.DataSource = Enum.GetValues(typeof(ConfigSettings.Config.Operator));
            cbxKeepMinOperator.SelectedIndex = 0;
            BindingSource bs = new BindingSource();
            bs.DataSource = StaticList.Items.ToList();
            dtgrvwItemRecycleFilter.DataSource = bs;
            cbxUseBerriesOperator.DataSource = Enum.GetValues(typeof(ConfigSettings.Config.Operator));
            cbxUseBerriesOperator.SelectedIndex = 0;
            txtSavingPath.Text = newSettingPath;
            cboxUseWebsocket.Checked = false;
            cboxCatchPokemon.Checked = true;
        }

        private void btnUpdateSettings_Click(object sender, EventArgs e)
        {
            bckgrwkrLoading.RunWorkerAsync();
        }

        private void ParseSettings()
        {
            ParseAuth(oldSettingPath + @"auth.json");
            ParseConfig(oldSettingPath + @"config.json");
            ParseToUI();
        }

        private void ParseToUI()
        {
            ParseAuthToUI();
            bckgrwkrLoading.ReportProgress(10);

            ParseGeneralSettings();
            bckgrwkrLoading.ReportProgress(20);

            ParseLocationSettings();
            bckgrwkrLoading.ReportProgress(25);

            ParseEvolutionSettings();
            bckgrwkrLoading.ReportProgress(36);

            ParseUpgradeSettings();
            bckgrwkrLoading.ReportProgress(50);

            ParseTransferSettings();
            bckgrwkrLoading.ReportProgress(77);

            ParseItemsSettings();
            bckgrwkrLoading.ReportProgress(85);

            ParseCatchingSettings();
            bckgrwkrLoading.ReportProgress(88);

            ParseAdvancedCatchingSettings();
            bckgrwkrLoading.ReportProgress(93);

            ParseSnipingSettings();
            bckgrwkrLoading.ReportProgress(100);
        }

        private void ParseSnipingSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseSnipingSettings);
                Invoke(method);
                return;
            }
            cboxUseSnipeOnlineLocationServer.Checked = config.UseSnipeOnlineLocationServer;
            cboxUseSnipeLocationServer.Checked = config.UseSnipeLocationServer;
            txtSnipeLocationServer.Text = config.SnipeLocationServer;
            txtSnipeLocationServerPort.Text = config.SnipeLocationServerPort.ToString();
            cboxGetSniperInfoFromPokezz.Checked = config.GetSniperInfoFromPokezz;
            cboxGetOnlyVerifiedSniperInfoFromPokezz.Checked = config.GetOnlyVerifiedSniperInfoFromPokezz;
            cboxSnipeAtPokestops.Checked = config.SnipeAtPokestops;
            cboxSnipeIgnoreUnknownIv.Checked = config.SnipeIgnoreUnknownIv;
            cboxUseTransferIvForSnipe.Checked = config.UseTransferIvForSnipe;
            cboxUsePokemonSniperFilterOnly.Checked = config.UsePokemonSniperFilterOnly;
            txtMinPokeballsToSnipe.Text = config.MinPokeballsToSnipe.ToString();
            txtMinPokeballsWhileSnipe.Text = config.MinPokeballsWhileSnipe.ToString();
            txtMinDelayBetweenSnipes.Text = config.MinDelayBetweenSnipes.ToString();
            txtSnipingScanOffset.Text = config.SnipingScanOffset.ToString();
            cboxSnipePokemonNotInPokedex.Checked = config.SnipePokemonNotInPokedex;
            BindingSource bs = new BindingSource();
            bs.DataSource = config.PokemonToSnipe.Locations.ToList();
            dtgrvwLocations.DataSource = null;
            dtgrvwLocations.DataSource = bs;
            foreach (string pokemonName in config.PokemonToSnipe.Pokemon)
            {
                lstvwPokemon.Items[Array.IndexOf(StaticList.PokemonNames, pokemonName)].Checked = true;
            }
        }

        private void ParseAdvancedCatchingSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseAdvancedCatchingSettings);
                Invoke(method);
                return;
            }
            cboxEnableHumanizedThrows.Checked = config.EnableHumanizedThrows;
            txtNiceThrowChance.Text = config.NiceThrowChance.ToString();
            txtGreatThrowChance.Text = config.GreatThrowChance.ToString();
            txtExcellentThrowChance.Text = config.ExcellentThrowChance.ToString();
            txtCurveThrowChance.Text = config.CurveThrowChance.ToString();
            txtForceGreatThrowOverCp.Text = config.ForceGreatThrowOverCp.ToString();
            txtForceExcellentThrowOverCp.Text = config.ForceExcellentThrowOverCp.ToString();
            txtForceGreatThrowOverIv.Text = config.ForceGreatThrowOverIv.ToString();
            txtForceExcellentThrowOverIv.Text = config.ForceExcellentThrowOverIv.ToString();
            cboxTransferWeakPokemon.Checked = config.TransferWeakPokemon;
            cboxTransferDuplicatePokemonOnCapture.Checked = config.TransferDuplicatePokemonOnCapture;
        }

        private void ParseCatchingSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseCatchingSettings);
                Invoke(method);
                return;
            }
            cboxCatchPokemon.Checked = config.CatchPokemon;
            cboxUsePokemonToNotCatchFilter.Checked = config.UsePokemonToNotCatchFilter;
            foreach (string pokemonName in config.PokemonsToIgnore)
            {
                lstvwPokemonsToIgnore.Items[Array.IndexOf(StaticList.PokemonNames, pokemonName)].Checked = true;
            }
            txtMaxPokeballsPerPokemon.Text = config.MaxPokeballsPerPokemon.ToString();
            foreach (string pokemonName in config.PokemonToUseMasterball)
            {
                lstvwPokemonToUseMasterball.Items[Array.IndexOf(StaticList.PokemonNames, pokemonName)].Checked = true;
            }
            txtUseGreatBallAboveCp.Text = config.UseGreatBallAboveCp.ToString();
            txtUseUltraBallAboveCp.Text = config.UseUltraBallAboveCp.ToString();
            txtUseMasterBallAboveCp.Text = config.UseMasterBallAboveCp.ToString();
            txtUseGreatBallAboveIv.Text = config.UseGreatBallAboveIv.ToString();
            txtUseUltraBallAboveIv.Text = config.UseUltraBallAboveIv.ToString();
            txtUseGreatBallBelowCatchProbability.Text = config.UseGreatBallBelowCatchProbability.ToString();
            txtUseUltraBallBelowCatchProbability.Text = config.UseUltraBallBelowCatchProbability.ToString();
            txtUseMasterBallBelowCatchProbability.Text = config.UseMasterBallBelowCatchProbability.ToString();
            txtUseBerriesMinCp.Text = config.UseBerriesMinCp.ToString();
            txtUseBerriesMinIv.Text = config.UseBerriesMinIv.ToString();
            txtUseBerriesBelowCatchProbability.Text = config.UseBerriesBelowCatchProbability.ToString();
            cbxUseBerriesOperator.SelectedItem = config.UseBerriesOperator;
        }

        private void ParseItemsSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseItemsSettings);
                Invoke(method);
                return;
            }
            cboxUseEggIncubators.Checked = config.UseEggIncubators;
            cboxUseLuckyEggsWhileEvolving.Checked = config.UseLuckyEggsWhileEvolving;
            txtUseLuckyEggsMinPokemonAmount.Text = config.UseLuckyEggsMinPokemonAmount.ToString();
            cboxUseLuckyEggConstantly.Checked = config.UseLuckyEggConstantly;
            cboxUseIncenseConstantly.Checked = config.UseIncenseConstantly;
            cboxVerboseRecycling.Checked = config.VerboseRecycling;
            txtRecycleInventoryAtUsagePercentage.Text = config.RecycleInventoryAtUsagePercentage.ToString();
            txtTotalAmountOfPokeballsToKeep.Text = config.TotalAmountOfPokeballsToKeep.ToString();
            txtTotalAmountOfPotionsToKeep.Text = config.TotalAmountOfPotionsToKeep.ToString();
            txtTotalAmountOfRevivesToKeep.Text = config.TotalAmountOfRevivesToKeep.ToString();
            txtTotalAmountOfBerriesToKeep.Text = config.TotalAmountOfBerriesToKeep.ToString();
            BindingSource bs = new BindingSource();
            bs.DataSource = config.ItemRecycleFilter.ToList();
            dtgrvwItemRecycleFilter.DataSource = null;
            dtgrvwItemRecycleFilter.DataSource = bs;
        }

        private void ParseTransferSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseTransferSettings);
                Invoke(method);
                return;
            }
            cboxPrioritizeIVOverCP.Checked = config.PrioritizeIvOverCp;
            cboxTransferDuplicatePokemon.Checked = config.TransferDuplicatePokemon;
            txtKeepMinDuplicatePokemon.Text = config.KeepMinDuplicatePokemon.ToString();
            txtKeepMinIVPercentage.Text = config.KeepMinIvPercentage.ToString();
            txtKeepMinCP.Text = config.KeepMinCp.ToString();
            cboxUseKeepMinLvl.Checked = config.UseKeepMinLvl;
            txtKeepMinLvl.Text = config.KeepMinLvl.ToString();
            cbxKeepMinOperator.SelectedItem = config.KeepMinOperator;
            foreach (string pokemonName in config.PokemonsNotToTransfer)
            {
                lstvwPokemonsNotToTransfer.Items[Array.IndexOf(StaticList.PokemonNames, pokemonName)].Checked = true;
            }
            config.ConvertTransferT();
            BindingSource bs = new BindingSource();
            PokemonTransferT[] PokemonsTransferFilterT = config.ConvertTransferT();
            bs.DataSource = (from pokemon in PokemonsTransferFilterT
                             select new PokemonTransferT
                             {
                                 Key = pokemon.Key,
                                 KeepMinCp = pokemon.KeepMinCp,
                                 KeepMinLvl = pokemon.KeepMinLvl,
                                 UseKeepMinLvl = pokemon.UseKeepMinLvl,
                                 KeepMinIvPercentage = pokemon.KeepMinIvPercentage,
                                 KeepMinDuplicatePokemon = pokemon.KeepMinDuplicatePokemon,
                                 MovesToDisplay = pokemon.MovesToDisplay,
                                 KeepMinOperator = pokemon.KeepMinOperator,
                                 MovesOperator = pokemon.MovesOperator
                             }).Distinct<PokemonTransferT>().ToList();
            dtgrvwPokemonTransferFilter.DataSource = bs;
        }

        private void ParseUpgradeSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseUpgradeSettings);
                Invoke(method);
                return;
            }
            cboxAutomaticallyLevelUpPokemon.Checked = config.AutomaticallyLevelUpPokemon;
            txtAmountOfTimesToUpgradeLoop.Text = config.AmountOfTimesToUpgradeLoop.ToString();
            cbxLevelUpByCPOrIv.SelectedItem = config.LevelUpByCPorIv;
            cbxUpgradePokemonMinimumStatsOperator.SelectedItem = config.UpgradePokemonMinimumStatsOperator;
            txtGetMinStarDustForLevelUp.Text = config.GetMinStarDustForLevelUp.ToString();
            txtUpgradePokemonCpMinimum.Text = config.UpgradePokemonCpMinimum.ToString();
            txtUpgradePokemonIvMinimum.Text = config.UpgradePokemonIvMinimum.ToString();
        }

        private void ParseEvolutionSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseEvolutionSettings);
                Invoke(method);
                return;
            }
            cboxEvolveAllPokemonAboveIV.Checked = config.EvolveAllPokemonAboveIv;
            txtEvolveAboveIVValue.Text = config.EvolveAboveIvValue.ToString();
            cboxEvolveAllPokemonWithEnoughCandy.Checked = config.EvolveAllPokemonWithEnoughCandy;
            foreach (string pokemonName in config.PokemonsToEvolve)
            {
                lstvwPokemonsToEvolve.Items[Array.IndexOf(StaticList.PokemonNames, pokemonName)].Checked = true;
            }
            cboxKeepPokemonsThatCanEvolve.Checked = config.KeepPokemonsThatCanEvolve;
            txtEvolveKeptPokemonsAtStorageUsagePercentage.Text = config.EvolveKeptPokemonsAtStorageUsagePercentage.ToString();
        }

        private void ParseAuthToUI()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseAuthToUI);
                Invoke(method);
                return;
            }
            cbxAuthType.SelectedItem = auth.AuthType;
            txtGoogleUsername.Text = auth.GoogleUsername;
            txtGooglePassword.Text = auth.GooglePassword;
            txtPtcUsername.Text = auth.PtcUsername;
            txtPtcPassword.Text = auth.PtcPassword;
            cboxUseProxy.Checked = auth.UseProxy;
            txtUseProxyHost.Text = auth.UseProxyHost;
            txtUseProxyPort.Text = auth.UseProxyPort;
            cboxUseProxyAuthentication.Checked = auth.UseProxyAuthentication;
            txtUseProxyUsername.Text = auth.UseProxyUsername;
            txtUseProxyPassword.Text = auth.UseProxyPassword;
            ParseDevice();
        }

        private void ParseDevice()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseDevice);
                Invoke(method);
                return;
            }
            txtDeviceId.Text = auth.DeviceId;
            txtAndroidBoardName.Text = auth.AndroidBoardName;
            txtAndroidBootloader.Text = auth.AndroidBootloader;
            txtDeviceBrand.Text = auth.DeviceBrand;
            txtDeviceModel.Text = auth.DeviceModel;
            txtDeviceModelIdentifier.Text = auth.DeviceModelIdentifier;
            txtDeviceModelBoot.Text = auth.DeviceModelBoot;
            txtHardwareManufacturer.Text = auth.HardwareManufacturer;
            txtHardwareModel.Text = auth.HardwareModel;
            txtFirmwareBrand.Text = auth.FirmwareBrand;
            txtFirmwareTags.Text = auth.FirmwareTags;
            txtFirmwareType.Text = auth.FirmwareType;
            txtFirmwareFingerprint.Text = auth.FirmwareFingerprint;
        }

        private void ParseLocationSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseLocationSettings);
                Invoke(method);
                return;
            }
            txtDefaultLatitude.Text = config.DefaultLatitude.ToString();
            txtDefaultLongitude.Text = config.DefaultLongitude.ToString();
            cboxDisableHumanWalking.Checked = config.DisableHumanWalking;
            txtWalkingSpeedInKilometerPerHour.Text = config.WalkingSpeedInKilometerPerHour.ToString();
            txtMaxTravelDistanceInMeters.Text = config.MaxTravelDistanceInMeters.ToString();
            cboxUseGPXPathing.Checked = config.UseGpxPathing;
            txtGPXFile.Text = config.GpxFile;
            txtMaxSpawnLocationOffset.Text = config.MaxSpawnLocationOffset.ToString();
        }

        private void ParseGeneralSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(ParseGeneralSettings);
                Invoke(method);
                return;
            }
            cboxAutoUpdate.Checked = config.AutoUpdate;
            cbxTranslationLanguageCode.SelectedItem = config.TranslationLanguageCode;
            cboxTransferConfigAndAuthOnUpdate.Checked = config.TransferConfigAndAuthOnUpdate;
            cboxStartUpWelcomeDelay.Checked = config.StartupWelcomeDelay;
            txtAmountOfPokemonToDisplayOnStart.Text = config.AmountOfPokemonToDisplayOnStart.ToString();
            cboxShowPokeballCountsBeforeRecycle.Checked = config.ShowPokeballCountsBeforeRecycle;
            cboxDumpPokemonStats.Checked = config.DumpPokemonStats;
            txtDelayBetweenPlayerActions.Text = config.DelayBetweenPlayerActions.ToString();
            txtDelayBetweenPokemonCatch.Text = config.DelayBetweenPokemonCatch.ToString();
            cboxRenamePokemon.Checked = config.RenamePokemon;
            cboxRenameOnlyAboveIv.Checked = config.RenameOnlyAboveIv;
            txtRenameTemplate.Text = config.RenameTemplate;
            cboxUseWebsocket.Checked = config.UseWebsocket;
            txtWebSocketPort.Text = config.WebSocketPort.ToString();
            cboxAutoFavoritePokemon.Checked = config.AutoFavoritePokemon;
            txtFavoriteMinIvPercentage.Text = config.FavoriteMinIvPercentage.ToString();
        }

        private void ParseConfig(string configFile)
        {
            string configJson = File.ReadAllText(configFile);
            config = JsonConvert.DeserializeObject<Config>(configJson);
        }

        private void ParseAuth(string authFile)
        {
            string authJson = File.ReadAllText(authFile);
            auth = JsonConvert.DeserializeObject<Auth>(authJson);
        }

        private void btnOldConfigPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (fbd.SelectedPath[fbd.SelectedPath.Length - 1] != '\\')
                    oldSettingPath = fbd.SelectedPath + @"\";
                else
                    oldSettingPath = fbd.SelectedPath;
                txtOldConfigPath.Text = oldSettingPath;
            }
        }

        private void txtAmountOfPokemonToDisplayOnStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAmountOfPokemonToDisplayOnStart_TextChanged_1(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtAmountOfPokemonToDisplayOnStart);
        }

        private void TextBoxAmountChanged(TextBox txt)
        {
            int t;
            if (txt.Text == "")
                t = 0;
            else
                t = Int32.Parse(txt.Text);
            if (t < 0)
                t = 0;
            if (t > 9999)
                t = 10000;
            txt.Text = t.ToString();
        }

        private void txtAmountOfTimesToUpgradeLoop_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtAmountOfTimesToUpgradeLoop);
        }

        private void txtGetMinStarDustForLevelUp_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtGetMinStarDustForLevelUp);
        }

        private void txtUpgradePokemonCpMinimum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtMaxSpawnLocationOffset_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtMaxSpawnLocationOffset);
        }

        private void txtDelayBetweenPlayerActions_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtDelayBetweenPlayerActions);
        }

        private void txtDelayBetweenPokemonCatch_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtDelayBetweenPokemonCatch);
        }

        private void cbxAuthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ConfigSettings.Auth.Authentication)cbxAuthType.SelectedItem == ConfigSettings.Auth.Authentication.google)
            {
                lblPtcUsername.Enabled = false;
                lblPtcPassword.Enabled = false;
                txtPtcUsername.Enabled = false;
                txtPtcPassword.Enabled = false;

                lblGoogleUsername.Enabled = true;
                lblGooglePassword.Enabled = true;
                txtGoogleUsername.Enabled = true;
                txtGooglePassword.Enabled = true;
            }
            else
            {
                lblGoogleUsername.Enabled = false;
                lblGooglePassword.Enabled = false;
                txtGoogleUsername.Enabled = false;
                txtGooglePassword.Enabled = false;

                lblPtcUsername.Enabled = true;
                lblPtcPassword.Enabled = true;
                txtPtcUsername.Enabled = true;
                txtPtcPassword.Enabled = true;
            }
        }

        private void txtMaxTravelDistanceInMeters_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtMaxTravelDistanceInMeters);
        }

        private void cboxUseGPXPathing_CheckedChanged(object sender, EventArgs e)
        {
            txtGPXFile.Enabled = cboxUseGPXPathing.Checked;
            lblGPXFile.Enabled = cboxUseGPXPathing.Checked;
        }

        private void cboxEvolveAllPokemonAboveIV_CheckedChanged(object sender, EventArgs e)
        {
            lblEvolveAboveIVValue.Enabled = cboxEvolveAllPokemonAboveIV.Checked;
            txtEvolveAboveIVValue.Enabled = cboxEvolveAllPokemonAboveIV.Checked;
        }

        private void cboxEvolveAllPokemonWithEnoughCandy_CheckedChanged(object sender, EventArgs e)
        {
            cboxEvolveAllPokemonAboveIV.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked;
            lblEvolveAboveIVValue.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked & cboxEvolveAllPokemonAboveIV.Checked;
            txtEvolveAboveIVValue.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked & cboxEvolveAllPokemonAboveIV.Checked;
            lblPokemonsToEvolve.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked;
            lstvwPokemonsToEvolve.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked;
            cboxKeepPokemonsThatCanEvolve.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked;
            lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked & cboxKeepPokemonsThatCanEvolve.Checked;
            txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = cboxEvolveAllPokemonWithEnoughCandy.Checked & cboxKeepPokemonsThatCanEvolve.Checked;
        }

        private void cboxKeepPokemonsThatCanEvolve_CheckedChanged(object sender, EventArgs e)
        {
            lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = cboxKeepPokemonsThatCanEvolve.Checked;
            txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = cboxKeepPokemonsThatCanEvolve.Checked;
        }

        private void cboxRenamePokemon_CheckedChanged(object sender, EventArgs e)
        {
            cboxRenameOnlyAboveIv.Enabled = cboxRenamePokemon.Checked;
            lblRenameTemplate.Enabled = cboxRenamePokemon.Checked;
            txtRenameTemplate.Enabled = cboxRenamePokemon.Checked;
        }

        private void txtWebSocketPort_TextChanged(object sender, EventArgs e)
        {
            int t;
            if (txtWebSocketPort.Text == "")
                t = 14251;
            else
                t = Int32.Parse(txtWebSocketPort.Text);
            if (t < 0)
                t = 14251;
            txtWebSocketPort.Text = t.ToString();
        }

        private void cboxAutomaticallyLevelUpPokemon_CheckedChanged(object sender, EventArgs e)
        {
            lblAmountOfTimesToUpgradeLoop.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            txtAmountOfTimesToUpgradeLoop.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            lblLevelUpByCPOrIv.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            cbxLevelUpByCPOrIv.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            lblUpgradePokemonMinimumStatsOperator.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            cbxUpgradePokemonMinimumStatsOperator.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            lblGetMinStarDustForLevelUp.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            txtGetMinStarDustForLevelUp.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            lblUpgradePokemonCpMinimum.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            txtUpgradePokemonCpMinimum.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            lblUpgradePokemonIvMinimum.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
            txtUpgradePokemonIvMinimum.Enabled = cboxAutomaticallyLevelUpPokemon.Checked;
        }

        private void cboxTransferDuplicatePokemon_CheckedChanged(object sender, EventArgs e)
        {
            lblKeepMinDuplicatePokemon.Enabled = cboxTransferDuplicatePokemon.Checked;
            txtKeepMinDuplicatePokemon.Enabled = cboxTransferDuplicatePokemon.Checked;
            lblKeepMinIVPercentage.Enabled = cboxTransferDuplicatePokemon.Checked;
            txtKeepMinIVPercentage.Enabled = cboxTransferDuplicatePokemon.Checked;
            lblKeepMinCP.Enabled = cboxTransferDuplicatePokemon.Checked;
            txtKeepMinCP.Enabled = cboxTransferDuplicatePokemon.Checked;
            lblPokemonsNotToTransfer.Enabled = cboxTransferDuplicatePokemon.Checked;
            lstvwPokemonsNotToTransfer.Enabled = cboxTransferDuplicatePokemon.Checked;
            lblPokemonTransferFilter.Enabled = cboxTransferDuplicatePokemon.Checked;
            dtgrvwPokemonTransferFilter.Enabled = cboxTransferDuplicatePokemon.Checked;
            cboxUseKeepMinLvl.Enabled = cboxTransferDuplicatePokemon.Checked;
            lblKeepMinLvl.Enabled = cboxTransferDuplicatePokemon.Checked & cboxUseKeepMinLvl.Checked;
            txtKeepMinLvl.Enabled = cboxTransferDuplicatePokemon.Checked & cboxUseKeepMinLvl.Checked;
            lblKeepMinOperator.Enabled = cboxTransferDuplicatePokemon.Checked;
            cbxKeepMinOperator.Enabled = cboxTransferDuplicatePokemon.Checked;
        }

        private void txtKeepMinLvl_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtKeepMinLvl);
        }

        private void cboxUseKeepMinLvl_CheckedChanged(object sender, EventArgs e)
        {
            lblKeepMinLvl.Enabled = cboxUseKeepMinLvl.Checked;
            txtKeepMinLvl.Enabled = cboxUseKeepMinLvl.Checked;
        }

        private void txtKeepMinDuplicatePokemon_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtKeepMinDuplicatePokemon);
        }

        private void txtKeepMinCP_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtKeepMinCP);
        }

        private void cboxUseLuckyEggsWhileEvolving_CheckedChanged(object sender, EventArgs e)
        {
            lblUseLuckyEggsMinPokemonAmount.Enabled = cboxUseLuckyEggsWhileEvolving.Checked;
            txtUseLuckyEggsMinPokemonAmount.Enabled = cboxUseLuckyEggsWhileEvolving.Checked;
        }

        private void cboxUsePokemonToNotCatchFilter_CheckedChanged(object sender, EventArgs e)
        {
            lblPokemonsToIgnore.Enabled = cboxUsePokemonToNotCatchFilter.Checked;
            lstvwPokemonsToIgnore.Enabled = cboxUsePokemonToNotCatchFilter.Checked;
        }

        private void cboxEnableHumanizedThrows_CheckedChanged(object sender, EventArgs e)
        {
            lblNiceThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            txtNiceThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            lblGreatThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            txtGreatThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            lblExcellentThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            txtExcellentThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            lblCurveThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            txtCurveThrowChance.Enabled = cboxEnableHumanizedThrows.Checked;
            lblForceGreatThrowOverIv.Enabled = cboxEnableHumanizedThrows.Checked;
            txtForceGreatThrowOverIv.Enabled = cboxEnableHumanizedThrows.Checked;
            lblForceExcellentThrowOverIv.Enabled = cboxEnableHumanizedThrows.Checked;
            txtForceExcellentThrowOverIv.Enabled = cboxEnableHumanizedThrows.Checked;
            lblForceGreatThrowOverCp.Enabled = cboxEnableHumanizedThrows.Checked;
            txtForceGreatThrowOverCp.Enabled = cboxEnableHumanizedThrows.Checked;
            lblForceExcellentThrowOverCp.Enabled = cboxEnableHumanizedThrows.Checked;
            txtForceExcellentThrowOverCp.Enabled = cboxEnableHumanizedThrows.Checked;
        }

        private void cboxAutoFavoritePokemon_CheckedChanged(object sender, EventArgs e)
        {
            lblFavoriteMinIvPercentage.Enabled = cboxAutoFavoritePokemon.Checked;
            txtFavoriteMinIvPercentage.Enabled = cboxAutoFavoritePokemon.Checked;
        }

        private void cboxUseSnipeLocationServer_CheckedChanged(object sender, EventArgs e)
        {
            lblSnipeLocationServer.Enabled = cboxUseSnipeLocationServer.Checked;
            txtSnipeLocationServer.Enabled = cboxUseSnipeLocationServer.Checked;
            lblSnipeLocationServerPort.Enabled = cboxUseSnipeLocationServer.Checked;
            txtSnipeLocationServerPort.Enabled = cboxUseSnipeLocationServer.Checked;
        }

        private void cboxOverrideOldSettings_CheckedChanged(object sender, EventArgs e)
        {
            lblSavingPath.Enabled = !cboxOverrideOldSettings.Checked;
            txtSavingPath.Enabled = !cboxOverrideOldSettings.Checked;
            btnBrowse.Enabled = !cboxOverrideOldSettings.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (fbd.SelectedPath[fbd.SelectedPath.Length - 1] != '\\')
                    newSettingPath = fbd.SelectedPath + @"\";
                else
                    newSettingPath = fbd.SelectedPath;
                txtSavingPath.Text = newSettingPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bckgrwkrSaving.RunWorkerAsync();
        }

        private void GetConfigSettings()
        {
            GetGeneralConfig();
            bckgrwkrSaving.ReportProgress(20);

            GetLocationSettings();
            bckgrwkrSaving.ReportProgress(25);

            GetEvolutionSettings();
            bckgrwkrSaving.ReportProgress(36);

            GetUpgradeSettings();
            bckgrwkrSaving.ReportProgress(50);

            GetTransferSettings();
            bckgrwkrSaving.ReportProgress(77);

            GetItemsSettings();
            bckgrwkrSaving.ReportProgress(85);

            GetCatchingSettings();
            bckgrwkrSaving.ReportProgress(88);

            GetAdvancedCatchingSettings();
            bckgrwkrSaving.ReportProgress(93);

            GetSnipingSettings();
            bckgrwkrSaving.ReportProgress(99);
        }

        private void GetSnipingSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetSnipingSettings);
                Invoke(method);
                return;
            }
            config.UseSnipeOnlineLocationServer = cboxUseSnipeOnlineLocationServer.Checked;
            config.UsePokemonSniperFilterOnly = cboxUsePokemonSniperFilterOnly.Checked;
            config.GetSniperInfoFromPokezz = cboxGetSniperInfoFromPokezz.Checked;
            config.GetOnlyVerifiedSniperInfoFromPokezz = cboxGetOnlyVerifiedSniperInfoFromPokezz.Checked;
            config.SnipeAtPokestops = cboxSnipeAtPokestops.Checked;
            config.SnipeIgnoreUnknownIv = cboxSnipeIgnoreUnknownIv.Checked;
            config.UseTransferIvForSnipe = cboxUseTransferIvForSnipe.Checked;
            config.UseSnipeLocationServer = cboxUseSnipeLocationServer.Checked;
            config.SnipeLocationServer = txtSnipeLocationServer.Text;
            config.SnipeLocationServerPort = int.Parse(txtSnipeLocationServerPort.Text);
            config.MinPokeballsToSnipe = int.Parse(txtMinPokeballsToSnipe.Text);
            config.MinPokeballsWhileSnipe = int.Parse(txtMinPokeballsWhileSnipe.Text);
            config.MinDelayBetweenSnipes = int.Parse(txtMinDelayBetweenSnipes.Text);
            config.SnipingScanOffset = float.Parse(txtSnipingScanOffset.Text);
            config.SnipePokemonNotInPokedex = cboxSnipePokemonNotInPokedex.Checked;
            List<Location> locations = new List<Location>();
            for (int i = 0; i < dtgrvwLocations.Rows.Count - 1; i++)
            {
                Location _location = new Location();
                _location.Latitude = (decimal)dtgrvwLocations.Rows[i].Cells[0].Value;
                _location.Longitude = (decimal)dtgrvwLocations.Rows[i].Cells[1].Value;
                locations.Add(_location);
            }
            config.PokemonToSnipe.Locations = locations.ToArray();
            List<string> pkm = new List<string>();
            foreach (ListViewItem item in lstvwPokemon.CheckedItems)
            {
                pkm.Add(StaticList.PokemonNames[item.Index]);
            }
            config.PokemonToSnipe.Pokemon = pkm.ToArray();
        }

        private void GetAdvancedCatchingSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetAdvancedCatchingSettings);
                Invoke(method);
                return;
            }
            config.EnableHumanizedThrows = cboxEnableHumanizedThrows.Checked;
            config.NiceThrowChance = int.Parse(txtNiceThrowChance.Text);
            config.GreatThrowChance = int.Parse(txtGreatThrowChance.Text);
            config.ExcellentThrowChance = int.Parse(txtExcellentThrowChance.Text);
            config.CurveThrowChance = int.Parse(txtCurveThrowChance.Text);
            config.ForceGreatThrowOverCp = int.Parse(txtForceGreatThrowOverCp.Text);
            config.ForceGreatThrowOverIv = int.Parse(txtForceGreatThrowOverIv.Text);
            config.ForceExcellentThrowOverCp = int.Parse(txtForceExcellentThrowOverCp.Text);
            config.ForceExcellentThrowOverIv = int.Parse(txtForceExcellentThrowOverIv.Text);
            config.TransferWeakPokemon = cboxTransferWeakPokemon.Checked;
            config.TransferDuplicatePokemonOnCapture = cboxTransferDuplicatePokemonOnCapture.Checked;
        }

        private void GetCatchingSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetCatchingSettings);
                Invoke(method);
                return;
            }
            config.CatchPokemon = cboxCatchPokemon.Checked;
            config.UsePokemonToNotCatchFilter = cboxUsePokemonToNotCatchFilter.Checked;
            List<string> pkm = new List<string>();
            foreach (ListViewItem item in lstvwPokemonsToIgnore.CheckedItems)
            {
                pkm.Add(StaticList.PokemonNames[item.Index]);
            }
            config.PokemonsToIgnore = pkm.ToArray();
            config.MaxPokeballsPerPokemon = int.Parse(txtMaxPokeballsPerPokemon.Text);
            pkm.Clear();
            foreach (ListViewItem item in lstvwPokemonToUseMasterball.CheckedItems)
            {
                pkm.Add(StaticList.PokemonNames[item.Index]);
            }
            config.PokemonToUseMasterball = pkm.ToArray();
            config.UseGreatBallAboveCp = int.Parse(txtUseGreatBallAboveCp.Text);
            config.UseUltraBallAboveCp = int.Parse(txtUseUltraBallAboveCp.Text);
            config.UseMasterBallAboveCp = int.Parse(txtUseMasterBallAboveCp.Text);
            config.UseGreatBallAboveIv = float.Parse(txtUseGreatBallAboveIv.Text);
            config.UseUltraBallAboveIv = float.Parse(txtUseUltraBallAboveIv.Text);
            config.UseGreatBallBelowCatchProbability = float.Parse(txtUseGreatBallBelowCatchProbability.Text);
            config.UseUltraBallBelowCatchProbability = float.Parse(txtUseUltraBallBelowCatchProbability.Text);
            config.UseMasterBallBelowCatchProbability = float.Parse(txtUseMasterBallBelowCatchProbability.Text);
            config.UseBerriesMinCp = int.Parse(txtUseBerriesMinCp.Text);
            config.UseBerriesMinIv = float.Parse(txtUseBerriesMinIv.Text);
            config.UseBerriesBelowCatchProbability = float.Parse(txtUseBerriesBelowCatchProbability.Text);
            config.UseBerriesOperator = (ConfigSettings.Config.Operator)cbxUseBerriesOperator.SelectedItem;
        }

        private void GetItemsSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetItemsSettings);
                Invoke(method);
                return;
            }
            config.UseEggIncubators = cboxUseEggIncubators.Checked;
            config.UseLuckyEggsWhileEvolving = cboxUseLuckyEggsWhileEvolving.Checked;
            config.UseLuckyEggsMinPokemonAmount = int.Parse(txtUseLuckyEggsMinPokemonAmount.Text);
            config.UseLuckyEggConstantly = cboxUseLuckyEggConstantly.Checked;
            config.UseIncenseConstantly = cboxUseIncenseConstantly.Checked;
            config.VerboseRecycling = cboxVerboseRecycling.Checked;
            config.RecycleInventoryAtUsagePercentage = float.Parse(txtRecycleInventoryAtUsagePercentage.Text);
            config.TotalAmountOfPokeballsToKeep = int.Parse(txtTotalAmountOfPokeballsToKeep.Text);
            config.TotalAmountOfPotionsToKeep = int.Parse(txtTotalAmountOfPotionsToKeep.Text);
            config.TotalAmountOfRevivesToKeep = int.Parse(txtTotalAmountOfRevivesToKeep.Text);
            config.TotalAmountOfBerriesToKeep = int.Parse(txtTotalAmountOfBerriesToKeep.Text);
            List<ItemRecycler> items = new List<ItemRecycler>();
            for (int i = 0; i < dtgrvwItemRecycleFilter.Rows.Count - 1; i++)
            {
                ItemRecycler _item = new ItemRecycler();
                _item.Key = dtgrvwItemRecycleFilter.Rows[i].Cells[0].Value.ToString();
                _item.Value = (int)dtgrvwItemRecycleFilter.Rows[i].Cells[1].Value;
                items.Add(_item);
            }
            config.ItemRecycleFilter = items.ToArray();
        }

        private void GetTransferSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetTransferSettings);
                Invoke(method);
                return;
            }
            config.PrioritizeIvOverCp = cboxPrioritizeIVOverCP.Checked;
            config.TransferDuplicatePokemon = cboxTransferDuplicatePokemon.Checked;
            config.KeepMinDuplicatePokemon = int.Parse(txtKeepMinDuplicatePokemon.Text);
            config.KeepMinIvPercentage = float.Parse(txtKeepMinIVPercentage.Text);
            config.KeepMinCp = int.Parse(txtKeepMinCP.Text);
            config.UseKeepMinLvl = cboxUseKeepMinLvl.Checked;
            config.KeepMinLvl = int.Parse(txtKeepMinLvl.Text);
            config.KeepMinOperator = (ConfigSettings.Config.Operator)cbxKeepMinOperator.SelectedItem;
            List<string> pokemonNames = new List<string>();
            foreach (ListViewItem item in lstvwPokemonsNotToTransfer.CheckedItems)
            {
                pokemonNames.Add(StaticList.PokemonNames[item.Index]);
            }
            config.PokemonsNotToTransfer = pokemonNames.ToArray();
            List<PokemonTransferT> pkmT = new List<PokemonTransferT>();
            for (int i = 0; i < dtgrvwPokemonTransferFilter.Rows.Count - 1; i++)
            {
                PokemonTransferT _pkmT = new PokemonTransferT();
                _pkmT.Key = dtgrvwPokemonTransferFilter.Rows[i].Cells[0].Value.ToString();
                _pkmT.KeepMinCp = (int)dtgrvwPokemonTransferFilter.Rows[i].Cells[1].Value;
                _pkmT.KeepMinLvl = (int)dtgrvwPokemonTransferFilter.Rows[i].Cells[2].Value;
                _pkmT.UseKeepMinLvl = (bool)dtgrvwPokemonTransferFilter.Rows[i].Cells[3].Value;
                _pkmT.KeepMinIvPercentage = (float)dtgrvwPokemonTransferFilter.Rows[i].Cells[4].Value;
                _pkmT.KeepMinDuplicatePokemon = (int)dtgrvwPokemonTransferFilter.Rows[i].Cells[5].Value;
                _pkmT.MovesToDisplay
                    = dtgrvwPokemonTransferFilter.Rows[i].Cells[6].Value == null ? "" : dtgrvwPokemonTransferFilter.Rows[i].Cells[6].Value.ToString();
                _pkmT.KeepMinOperator = (ConfigSettings.Config.Operator)dtgrvwPokemonTransferFilter.Rows[i].Cells[7].Value;
                _pkmT.MovesOperator = (ConfigSettings.Config.Operator)dtgrvwPokemonTransferFilter.Rows[i].Cells[8].Value;
                pkmT.Add(_pkmT);
            }
            config.ConvertTransfer(pkmT.ToArray());
        }

        private void GetUpgradeSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetUpgradeSettings);
                Invoke(method);
                return;
            }
            config.AutomaticallyLevelUpPokemon = cboxAutomaticallyLevelUpPokemon.Checked;
            config.AmountOfTimesToUpgradeLoop = int.Parse(txtAmountOfTimesToUpgradeLoop.Text);
            config.LevelUpByCPorIv = (ConfigSettings.Config.Power)cbxLevelUpByCPOrIv.SelectedItem;
            config.UpgradePokemonMinimumStatsOperator = (ConfigSettings.Config.Operator)cbxUpgradePokemonMinimumStatsOperator.SelectedItem;
            config.GetMinStarDustForLevelUp = int.Parse(txtGetMinStarDustForLevelUp.Text);
            config.UpgradePokemonCpMinimum = float.Parse(txtUpgradePokemonCpMinimum.Text);
            config.UpgradePokemonIvMinimum = float.Parse(txtUpgradePokemonIvMinimum.Text);
        }

        private void GetEvolutionSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetEvolutionSettings);
                Invoke(method);
                return;
            }
            config.EvolveAllPokemonWithEnoughCandy = cboxEvolveAllPokemonWithEnoughCandy.Checked;
            config.EvolveAllPokemonAboveIv = cboxEvolveAllPokemonAboveIV.Checked;
            config.EvolveAboveIvValue = float.Parse(txtEvolveAboveIVValue.Text);
            List<string> pokemonNames = new List<string>();
            foreach (ListViewItem item in lstvwPokemonsToEvolve.CheckedItems)
            {
                pokemonNames.Add(StaticList.PokemonNames[item.Index]);
            }
            config.PokemonsToEvolve = pokemonNames.ToArray();
            config.KeepPokemonsThatCanEvolve = cboxKeepPokemonsThatCanEvolve.Checked;
            config.EvolveKeptPokemonsAtStorageUsagePercentage = float.Parse(txtEvolveKeptPokemonsAtStorageUsagePercentage.Text);
        }

        private void GetLocationSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetLocationSettings);
                Invoke(method);
                return;
            }
            config.DefaultLatitude = decimal.Parse(txtDefaultLatitude.Text);
            config.DefaultLongitude = decimal.Parse(txtDefaultLongitude.Text);
            config.DisableHumanWalking = cboxDisableHumanWalking.Checked;
            config.WalkingSpeedInKilometerPerHour = float.Parse(txtWalkingSpeedInKilometerPerHour.Text);
            config.MaxTravelDistanceInMeters = int.Parse(txtMaxTravelDistanceInMeters.Text);
            config.MaxSpawnLocationOffset = int.Parse(txtMaxSpawnLocationOffset.Text);
        }

        private void GetGeneralConfig()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetGeneralConfig);
                Invoke(method);
                return;
            }
            config.TranslationLanguageCode = cbxTranslationLanguageCode.SelectedItem.ToString();
            config.AutoUpdate = cboxAutoUpdate.Checked;
            config.TransferConfigAndAuthOnUpdate = cboxTransferConfigAndAuthOnUpdate.Checked;
            config.StartupWelcomeDelay = cboxStartUpWelcomeDelay.Checked;
            config.AmountOfPokemonToDisplayOnStart = int.Parse(txtAmountOfPokemonToDisplayOnStart.Text);
            config.ShowPokeballCountsBeforeRecycle = cboxShowPokeballCountsBeforeRecycle.Checked;
            config.DumpPokemonStats = cboxDumpPokemonStats.Checked;
            config.DelayBetweenPlayerActions = int.Parse(txtDelayBetweenPlayerActions.Text);
            config.DelayBetweenPokemonCatch = int.Parse(txtDelayBetweenPokemonCatch.Text);
            config.RenamePokemon = cboxRenamePokemon.Checked;
            config.RenameOnlyAboveIv = cboxRenameOnlyAboveIv.Checked;
            config.RenameTemplate = txtRenameTemplate.Text;
            config.UseWebsocket = cboxUseWebsocket.Checked;
            config.WebSocketPort = int.Parse(txtWebSocketPort.Text);
            config.AutoFavoritePokemon = cboxAutoFavoritePokemon.Checked;
            config.FavoriteMinIvPercentage = float.Parse(txtFavoriteMinIvPercentage.Text);
        }

        private void GetAuthSettings()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetAuthSettings);
                Invoke(method);
                return;
            }
            auth.AuthType = (ConfigSettings.Auth.Authentication)cbxAuthType.SelectedItem;
            auth.GoogleUsername = txtGoogleUsername.Text;
            auth.GooglePassword = txtGooglePassword.Text;
            auth.PtcUsername = txtPtcUsername.Text;
            auth.PtcPassword = txtPtcPassword.Text;
            auth.UseProxy = cboxUseProxy.Checked;
            auth.UseProxyHost = txtUseProxyHost.Text;
            auth.UseProxyPort = txtUseProxyPort.Text;
            auth.UseProxyAuthentication = cboxUseProxyAuthentication.Checked;
            auth.UseProxyUsername = txtUseProxyUsername.Text;
            auth.UseProxyPassword = txtUseProxyPassword.Text;
            GetDevice();
        }

        private void GetDevice()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(GetDevice);
                Invoke(method);
                return;
            }
            auth.DeviceId = txtDeviceId.Text;
            auth.AndroidBoardName = txtAndroidBoardName.Text;
            auth.AndroidBootloader = txtAndroidBootloader.Text;
            auth.DeviceBrand = txtDeviceBrand.Text;
            auth.DeviceModel = txtDeviceModel.Text;
            auth.DeviceModelIdentifier = txtDeviceModelIdentifier.Text;
            auth.DeviceModelBoot = txtDeviceModelBoot.Text;
            auth.HardwareManufacturer = txtHardwareManufacturer.Text;
            auth.HardwareModel = txtHardwareModel.Text;
            auth.FirmwareBrand = txtFirmwareBrand.Text;
            auth.FirmwareTags = txtFirmwareTags.Text;
            auth.FirmwareType = txtFirmwareType.Text;
            auth.FirmwareFingerprint = txtFirmwareFingerprint.Text;
        }

        private void bckgrwkrSaving_DoWork(object sender, DoWorkEventArgs e)
        {
            bckgrwkrSaving.ReportProgress(0);
            if (!cboxOverrideOldSettings.Checked)
            {
                newSettingPath = oldSettingPath;
                if (File.Exists(oldSettingPath + @"auth.json.old"))
                    File.Delete(oldSettingPath + @"auth.json.old");
                if (File.Exists(oldSettingPath + @"config.json.old"))
                    File.Delete(oldSettingPath + @"config.json.old");
                File.Move(oldSettingPath + @"auth.json", oldSettingPath + @"auth.json.old");
                File.Move(oldSettingPath + @"config.json", oldSettingPath + @"config.json.old");
            }
            else
            {
                File.Delete(oldSettingPath + @"auth.json");
                File.Delete(oldSettingPath + @"config.json");
            }
            bckgrwkrSaving.ReportProgress(2);
            if (!Directory.Exists(newSettingPath))
                Directory.CreateDirectory(newSettingPath);

            GetAuthSettings();
            bckgrwkrSaving.ReportProgress(5);

            GetConfigSettings();

            string _auth = JsonConvert.SerializeObject(auth, Formatting.Indented, new JsonSerializerSettings { });
            File.WriteAllText(newSettingPath + @"auth.json", _auth);
            string _config = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(newSettingPath + @"config.json", _config);
            bckgrwkrSaving.ReportProgress(100);
        }

        private void bckgrwkrSaving_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if ((int)progressBar1.Value < 100)
                lblProgress.Text = progressBar1.Value.ToString() + "%";
            else
                lblProgress.Text = "Done";
        }

        private void bckgrwkrLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            bckgrwkrLoading.ReportProgress(0);
            if (!File.Exists(oldSettingPath + @"config.json") || !File.Exists(oldSettingPath + @"auth.json"))
                MessageBox.Show("Config files not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ParseSettings();
        }

        private void bckgrwkrLoading_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            Process.Start(txtBotLocation.Text);
        }

        private void cboxUseWebsocket_CheckedChanged(object sender, EventArgs e)
        {
            lblWebSocketPort.Enabled = cboxUseWebsocket.Checked;
            txtWebSocketPort.Enabled = cboxUseWebsocket.Checked;
        }

        private void cboxCatchPokemon_CheckedChanged(object sender, EventArgs e)
        {
            cboxUsePokemonToNotCatchFilter.Enabled = cboxCatchPokemon.Checked;
            lblPokemonsToIgnore.Enabled = cboxCatchPokemon.Checked;
            lstvwPokemonsToIgnore.Enabled = cboxCatchPokemon.Checked;
            lblMaxPokeballsPerPokemon.Enabled = cboxCatchPokemon.Checked;
            txtMaxPokeballsPerPokemon.Enabled = cboxCatchPokemon.Checked;
            lblPokemonToUseMasterball.Enabled = cboxCatchPokemon.Checked;
            lstvwPokemonToUseMasterball.Enabled = cboxCatchPokemon.Checked;
            lblUseGreatBallAboveCp.Enabled = cboxCatchPokemon.Checked;
            txtUseGreatBallAboveCp.Enabled = cboxCatchPokemon.Checked;
            lblUseUltraBallAboveCp.Enabled = cboxCatchPokemon.Checked;
            txtUseUltraBallAboveCp.Enabled = cboxCatchPokemon.Checked;
            lblUseMasterBallAboveCp.Enabled = cboxCatchPokemon.Checked;
            txtUseMasterBallAboveCp.Enabled = cboxCatchPokemon.Checked;
            lblUseGreatBallAboveIv.Enabled = cboxCatchPokemon.Checked;
            txtUseGreatBallAboveIv.Enabled = cboxCatchPokemon.Checked;
            lblUseUltraBallAboveIv.Enabled = cboxCatchPokemon.Checked;
            txtUseUltraBallAboveIv.Enabled = cboxCatchPokemon.Checked;
            lblUseGreatBallBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            txtUseGreatBallBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            lblUseUltraBallBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            txtUseUltraBallBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            lblUseMasterBallBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            txtUseMasterBallBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            lblUseBerriesMinCp.Enabled = cboxCatchPokemon.Checked;
            txtUseBerriesMinCp.Enabled = cboxCatchPokemon.Checked;
            lblUseBerriesMinIv.Enabled = cboxCatchPokemon.Checked;
            txtUseBerriesMinIv.Enabled = cboxCatchPokemon.Checked;
            lblUseBerriesBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            txtUseBerriesBelowCatchProbability.Enabled = cboxCatchPokemon.Checked;
            lblUseBerriesOperator.Enabled = cboxCatchPokemon.Checked;
            cbxUseBerriesOperator.Enabled = cboxCatchPokemon.Checked;
        }

        private void cboxUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            lblUseProxyHost.Enabled = cboxUseProxy.Checked;
            txtUseProxyHost.Enabled = cboxUseProxy.Checked;
            lblUseProxyPort.Enabled = cboxUseProxy.Checked;
            txtUseProxyPort.Enabled = cboxUseProxy.Checked;
            cboxUseProxyAuthentication.Enabled = cboxUseProxy.Checked;
            lblUseProxyUsername.Enabled = cboxUseProxy.Checked & cboxUseProxyAuthentication.Checked;
            txtUseProxyUsername.Enabled = cboxUseProxy.Checked & cboxUseProxyAuthentication.Checked;
            lblUseProxyPassword.Enabled = cboxUseProxy.Checked & cboxUseProxyAuthentication.Checked;
            txtUseProxyPassword.Enabled = cboxUseProxy.Checked & cboxUseProxyAuthentication.Checked;
        }

        private void UseProxyAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            lblUseProxyUsername.Enabled = cboxUseProxyAuthentication.Checked;
            txtUseProxyUsername.Enabled = cboxUseProxyAuthentication.Checked;
            lblUseProxyPassword.Enabled = cboxUseProxyAuthentication.Checked;
            txtUseProxyPassword.Enabled = cboxUseProxyAuthentication.Checked;
        }
    }
}
