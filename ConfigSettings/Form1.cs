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
        }

        private void ParseConfig(string configFile)
        {
            string configJson = File.ReadAllText(configFile);
            config = JsonConvert.DeserializeObject<Config>(configJson);
            //MessageBox.Show(config.PokemonsTransferFilter["Golduck"].ToString());

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
    }
}
