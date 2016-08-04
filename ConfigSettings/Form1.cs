using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private string oldSettingPath = @"..\..\Config\";
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
            }
            cbxKeepMinOperator.DataSource = Enum.GetValues(typeof(ConfigSettings.Config.Operator));
            cbxKeepMinOperator.SelectedIndex = 0;
            BindingSource bs = new BindingSource();
            bs.DataSource = StaticList.Items.ToList();
            dtgrvwItemRecycleFilter.DataSource = bs;
        }

        private void btnUpdateSettings_Click(object sender, EventArgs e)
        {
            if (!File.Exists(oldSettingPath + @"config.json") || !File.Exists(oldSettingPath + @"auth.json"))
                MessageBox.Show("Config files not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ParseSettings();
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
            ParseGeneralSettings();
            ParseLocationSettings();
            ParseEvolutionSettings();
            ParseUpgradeSettings();
            ParseTransferSettings();
            ParseItemsSettings();
        }

        private void ParseItemsSettings()
        {
            cboxUseEggIncubators.Checked = config.UseEggIncubators;
            cboxUseLuckyEggsWhileEvolving.Checked = config.UseLuckyEggsWhileEvolving;
            txtUseLuckyEggsMinPokemonAmount.Text = config.UseLuckyEggsMinPokemonAmount.ToString();
            cboxUseLuckyEggConstantly.Checked = config.UseLuckyEggConstantly;
            cboxUseIncenseConstantly.Checked = config.UseIncenseConstantly;
            cboxVerboseRecycling.Checked = config.VerboseRecycling;
            txtRecycleInventoryAtUsagePercentage.Text = config.RecycleInventoryAtUsagePercentage.ToString();
            txtTotalAmountOfPokeballsToKeep.Text = config.TotalAmountOfPokeballsToKeep.ToString();
            txtTotalAmountOfPotionsToKeep.Text = config.TotalAmountOfPotionsToKeep.ToString();
            txtTotalAmountOfRevivesToKeep.Text = config.TotalAmountOfRevicesToKeep.ToString();
            txtTotalAmountOfBerriesToKeep.Text = config.TotalAmountOfBerriesToKeep.ToString();
            BindingSource bs = new BindingSource();
            bs.DataSource = config.ItemRecycleFilter.ToList();
            dtgrvwItemRecycleFilter.DataSource = null;
            dtgrvwItemRecycleFilter.DataSource = bs;
        }

        private void ParseTransferSettings()
        {
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
            bs.DataSource = (from pokemon in config.PokemonsTransferFilterT
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
                             }).Distinct<PokemonTransferT>().ToList();
            dtgrvwPokemonTransferFilter.DataSource = bs;
        }

        private void ParseUpgradeSettings()
        {
            cboxAutomaticallyLevelUpPokemon.Checked = config.AutomaticallyLevelUpPokemon;
            txtAmountOfTimesToUpgradeLoop.Text = config.AmountOfTimesToUpgradeLoop.ToString();
            cbxLevelUpByCPOrIv.SelectedItem = config.LevelUpByCPOrIv;
            cbxUpgradePokemonMinimumStatsOperator.SelectedItem = config.UpgradePokemonMinimumStatsOperator;
            txtGetMinStarDustForLevelUp.Text = config.GetMinStarDustForLevelUp.ToString();
            txtUpgradePokemonCpMinimum.Text = config.UpgradePokemonCpMinimum.ToString();
            txtUpgradePokemonIvMinimum.Text = config.UpgradePokemonIvMinimum.ToString();
        }

        private void ParseEvolutionSettings()
        {
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
            cbxAuthType.SelectedItem = auth.AuthType;
            txtGoogleUsername.Text = auth.GoogleUserName;
            txtGooglePassword.Text = auth.GooglePassword;
            txtPtcUsername.Text = auth.PtcUsername;
            txtPtcPassword.Text = auth.PtcPassword;
        }

        private void ParseLocationSettings()
        {
            txtDefaultAltitude.Text = config.DefaultAltitude.ToString();
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
            txtWebSocketPort.Text = config.WebSocketPort.ToString();
        }

        private void ParseConfig(string configFile)
        {
            string configJson = File.ReadAllText(configFile);
            config = JsonConvert.DeserializeObject<Config>(configJson);
            //for (int i=0;i<config.PokemonsTransferFilter.Count; i++)
            //{
            //    KeyValuePair<string, PokemonTransfer> key = config.PokemonsTransferFilter.ElementAt(i);
            //    MessageBox.Show(key.Key.ToString() + " - " + key.Value.ToString());
            //}
        }

        private void ParseAuth(string authFile)
        {
            string authJson = File.ReadAllText(authFile);
            auth = JsonConvert.DeserializeObject<Auth>(authJson);
            //string o = JsonConvert.SerializeObject(auth, Formatting.Indented);
            //o = o.Replace("\r\n","\n");
            //File.WriteAllText(authFile + ".old", o);
        }

        private void btnOldConfigPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oldSettingPath = fbd.SelectedPath + @"\\";
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
    }
}
