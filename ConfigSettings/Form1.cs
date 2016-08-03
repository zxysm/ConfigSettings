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
using static ConfigSettings.Config;

namespace ConfigSettings
{
    public partial class frmConfig : Form
    {
        private string oldSettingPath = @".\Config\";
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
            cbxLevelUpByCPOrIv.DataSource = Enum.GetValues(typeof(Power));
            cbxLevelUpByCPOrIv.SelectedIndex = 0;
            cbxUpgradePokemonMinimumStatsOperator.DataSource = Enum.GetValues(typeof(Operator));
            cbxUpgradePokemonMinimumStatsOperator.SelectedIndex = 0;
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
            ParseGeneralSettings();
            ParseBotSettings();
        }

        private void ParseBotSettings()
        {
            cboxAutomaticallyLevelUpPokemon.Checked = config.AutomaticallyLevelUpPokemon;
            txtAmountOfTimesToUpgradeLoop.Text = config.AmountOfTimesToUpgradeLoop.ToString();
            txtGetMinStarDustForLevelUp.Text = config.GetMinStarDustForLevelUp.ToString();
            cbxLevelUpByCPOrIv.SelectedItem = config.LevelUpByCPOrIv;
            txtUpgradePokemonCpMinimum.Text = config.UpgradePokemonCpMinimum.ToString();
            txtUpgradePokemonIvMinimum.Text = config.UpgradePokemonIvMinimum.ToString();
            cbxUpgradePokemonMinimumStatsOperator.SelectedItem = config.UpgradePokemonMinimumStatsOperator;
            cboxDisableHumanWalking.Checked = config.DisableHumanWalking;
        }

        private void ParseGeneralSettings()
        {
            cboxAutoUpdate.Checked = config.AutoUpdate;
            cboxTransferConfigAndAuthOnUpdate.Checked = config.TransferConfigAndAuthOnUpdate;
            cbxTranslationLanguageCode.SelectedItem = config.TranslationLanguageCode;
            cboxStartUpWelcomeDelay.Checked = config.StartupWelcomeDelay;
            txtAmountOfPokemonToDisplayOnStart.Text = config.AmountOfPokemonToDisplayOnStart.ToString();
            cboxShowPokeballCountsBeforeRecycle.Checked = config.ShowPokeballCountsBeforeRecycle;
            cboxDumpPokemonStats.Checked = config.DumpPokemonStats;
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
    }
}
