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
            }
            cbxKeepMinOperator.DataSource = Enum.GetValues(typeof(ConfigSettings.Config.Operator));
            cbxKeepMinOperator.SelectedIndex = 0;
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
            foreach (KeyValuePair<string, PokemonTransfer> pair in config.PokemonsTransferFilter)
            {
                config.PokemonsTransferFilter[pair.Key].MovesToDisplay = string.Join(",", pair.Value.Moves);
            }
            dtgrvwPokemonTransferFilter.DataSource = (from pokemon in config.PokemonsTransferFilter
                                                      select new
                                                      {
                                                          pokemon.Key,
                                                          pokemon.Value.KeepMinCp,
                                                          pokemon.Value.KeepMinLvl,
                                                          pokemon.Value.UseKeepMinLvl,
                                                          pokemon.Value.KeepMinIvPercentage,
                                                          pokemon.Value.KeepMinDuplicatePokemon,
                                                          pokemon.Value.MovesToDisplay,
                                                          pokemon.Value.KeepMinOperator,
                                                      }).ToList();
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
            if (cboxUseGPXPathing.Checked)
            {
                txtGPXFile.Enabled = true;
                lblGPXFile.Enabled = true;
            }
            else
            {
                txtGPXFile.Enabled = false;
                lblGPXFile.Enabled = false;
            }
        }

        private void cboxEvolveAllPokemonAboveIV_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxEvolveAllPokemonAboveIV.Checked)
            {
                lblEvolveAboveIVValue.Enabled = true;
                txtEvolveAboveIVValue.Enabled = true;
            }
            else
            {
                lblEvolveAboveIVValue.Enabled = false;
                txtEvolveAboveIVValue.Enabled = false;
            }
        }

        private void cboxEvolveAllPokemonWithEnoughCandy_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxEvolveAllPokemonWithEnoughCandy.Checked)
            {
                cboxEvolveAllPokemonAboveIV.Enabled = true;
                lblEvolveAboveIVValue.Enabled = true & cboxEvolveAllPokemonAboveIV.Checked;
                txtEvolveAboveIVValue.Enabled = true & cboxEvolveAllPokemonAboveIV.Checked;
                lblPokemonsToEvolve.Enabled = true;
                lstvwPokemonsToEvolve.Enabled = true;
                cboxKeepPokemonsThatCanEvolve.Enabled = true;
                lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = true & cboxKeepPokemonsThatCanEvolve.Checked;
                txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = true & cboxKeepPokemonsThatCanEvolve.Checked;
            }
            else
            {
                cboxEvolveAllPokemonAboveIV.Enabled = false;
                lblEvolveAboveIVValue.Enabled = false & cboxEvolveAllPokemonAboveIV.Checked;
                txtEvolveAboveIVValue.Enabled = false & cboxEvolveAllPokemonAboveIV.Checked;
                lblPokemonsToEvolve.Enabled = false;
                lstvwPokemonsToEvolve.Enabled = false;
                cboxKeepPokemonsThatCanEvolve.Enabled = false;
                lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = false & cboxKeepPokemonsThatCanEvolve.Checked;
                txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = false & cboxKeepPokemonsThatCanEvolve.Checked;
            }
        }

        private void cboxKeepPokemonsThatCanEvolve_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxKeepPokemonsThatCanEvolve.Checked)
            {
                lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = true;
                txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = true;
            }
            else
            {
                lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = false;
                txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = false;
            }
        }

        private void cboxRenamePokemon_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxRenamePokemon.Checked)
            {
                cboxRenameOnlyAboveIv.Enabled = true;
                lblRenameTemplate.Enabled = true;
                txtRenameTemplate.Enabled = true;
            }
            else
            {
                cboxRenameOnlyAboveIv.Enabled = false;
                lblRenameTemplate.Enabled = false;
                txtRenameTemplate.Enabled = false;
            }
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
            if (cboxAutomaticallyLevelUpPokemon.Checked)
            {
                lblAmountOfTimesToUpgradeLoop.Enabled = true;
                txtAmountOfTimesToUpgradeLoop.Enabled = true;
                lblLevelUpByCPOrIv.Enabled = true;
                cbxLevelUpByCPOrIv.Enabled = true;
                lblUpgradePokemonMinimumStatsOperator.Enabled = true;
                cbxUpgradePokemonMinimumStatsOperator.Enabled = true;
                lblGetMinStarDustForLevelUp.Enabled = true;
                txtGetMinStarDustForLevelUp.Enabled = true;
                lblUpgradePokemonCpMinimum.Enabled = true;
                txtUpgradePokemonCpMinimum.Enabled = true;
                lblUpgradePokemonIvMinimum.Enabled = true;
                txtUpgradePokemonIvMinimum.Enabled = true;
            }
            else
            {
                lblAmountOfTimesToUpgradeLoop.Enabled = false;
                txtAmountOfTimesToUpgradeLoop.Enabled = false;
                lblLevelUpByCPOrIv.Enabled = false;
                cbxLevelUpByCPOrIv.Enabled = false;
                lblUpgradePokemonMinimumStatsOperator.Enabled = false;
                cbxUpgradePokemonMinimumStatsOperator.Enabled = false;
                lblGetMinStarDustForLevelUp.Enabled = false;
                txtGetMinStarDustForLevelUp.Enabled = false;
                lblUpgradePokemonCpMinimum.Enabled = false;
                txtUpgradePokemonCpMinimum.Enabled = false;
                lblUpgradePokemonIvMinimum.Enabled = false;
                txtUpgradePokemonIvMinimum.Enabled = false;
            }
        }

        private void cboxTransferDuplicatePokemon_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxTransferDuplicatePokemon.Checked)
            {
                lblKeepMinDuplicatePokemon.Enabled = true;
                txtKeepMinDuplicatePokemon.Enabled = true;
                lblKeepMinIVPercentage.Enabled = true;
                txtKeepMinIVPercentage.Enabled = true;
                lblKeepMinCP.Enabled = true;
                txtKeepMinCP.Enabled = true;
                lblPokemonsNotToTransfer.Enabled = true;
                lstvwPokemonsNotToTransfer.Enabled = true;
                lblPokemonTransferFilter.Enabled = true;
                dtgrvwPokemonTransferFilter.Enabled = true;
                cboxUseKeepMinLvl.Enabled = true;
                lblKeepMinLvl.Enabled = true & cboxUseKeepMinLvl.Checked;
                txtKeepMinLvl.Enabled = true & cboxUseKeepMinLvl.Checked;
                lblKeepMinOperator.Enabled = true;
                cbxKeepMinOperator.Enabled = true;
            }
            else
            {
                lblKeepMinDuplicatePokemon.Enabled = false;
                txtKeepMinDuplicatePokemon.Enabled = false;
                lblKeepMinIVPercentage.Enabled = false;
                txtKeepMinIVPercentage.Enabled = false;
                lblKeepMinCP.Enabled = false;
                txtKeepMinCP.Enabled = false;
                lblPokemonsNotToTransfer.Enabled = false;
                lstvwPokemonsNotToTransfer.Enabled = false;
                lblPokemonTransferFilter.Enabled = false;
                dtgrvwPokemonTransferFilter.Enabled = false;
                cboxUseKeepMinLvl.Enabled = false;
                lblKeepMinLvl.Enabled = false & cboxUseKeepMinLvl.Checked;
                txtKeepMinLvl.Enabled = false & cboxUseKeepMinLvl.Checked;
                lblKeepMinOperator.Enabled = false;
                cbxKeepMinOperator.Enabled = false;
            }
        }

        private void txtKeepMinLvl_TextChanged(object sender, EventArgs e)
        {
            TextBoxAmountChanged(txtKeepMinLvl);
        }

        private void cboxUseKeepMinLvl_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxUseKeepMinLvl.Checked)
            {
                lblKeepMinLvl.Enabled = true;
                txtKeepMinLvl.Enabled = true;
            }
            else
            {
                lblKeepMinLvl.Enabled = false;
                txtKeepMinLvl.Enabled = false;
            }
        }
    }
}
