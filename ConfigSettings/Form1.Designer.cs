﻿namespace ConfigSettings
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grboxAuthentication = new System.Windows.Forms.GroupBox();
            this.lblPtcPassword = new System.Windows.Forms.Label();
            this.txtPtcPassword = new System.Windows.Forms.TextBox();
            this.lblPtcUsername = new System.Windows.Forms.Label();
            this.txtPtcUsername = new System.Windows.Forms.TextBox();
            this.lblGooglePassword = new System.Windows.Forms.Label();
            this.txtGooglePassword = new System.Windows.Forms.TextBox();
            this.lblGoogleUsername = new System.Windows.Forms.Label();
            this.cbxAuthType = new System.Windows.Forms.ComboBox();
            this.txtGoogleUsername = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grboxLocation = new System.Windows.Forms.GroupBox();
            this.txtMaxSpawnLocationOffset = new System.Windows.Forms.TextBox();
            this.txtWalkingSpeedInKilometerPerHour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDefaultLongitude = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDefaultLatitude = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDefaultAltitude = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDelayBetweenPokemonCatch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDelayBetweenPlayerActions = new System.Windows.Forms.TextBox();
            this.cboxDisableHumanWalking = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxUpgradePokemonMinimumStatsOperator = new System.Windows.Forms.ComboBox();
            this.txtUpgradePokemonIvMinimum = new System.Windows.Forms.TextBox();
            this.lblUpgradePokemonMinimumStatsOperator = new System.Windows.Forms.Label();
            this.lblUpgradePokemonIvMinimum = new System.Windows.Forms.Label();
            this.lblUpgradePokemonCpMinimum = new System.Windows.Forms.Label();
            this.txtUpgradePokemonCpMinimum = new System.Windows.Forms.TextBox();
            this.lblLevelUpByCPOrIv = new System.Windows.Forms.Label();
            this.cbxLevelUpByCPOrIv = new System.Windows.Forms.ComboBox();
            this.txtGetMinStarDustForLevelUp = new System.Windows.Forms.TextBox();
            this.lblGetMinStarDustForLevelUp = new System.Windows.Forms.Label();
            this.txtAmountOfTimesToUpgradeLoop = new System.Windows.Forms.TextBox();
            this.cboxAutomaticallyLevelUpPokemon = new System.Windows.Forms.CheckBox();
            this.lblAmountOfTimesToUpgradeLoop = new System.Windows.Forms.Label();
            this.grboxGeneralConfig = new System.Windows.Forms.GroupBox();
            this.cboxDumpPokemonStats = new System.Windows.Forms.CheckBox();
            this.cboxShowPokeballCountsBeforeRecycle = new System.Windows.Forms.CheckBox();
            this.txtAmountOfPokemonToDisplayOnStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxStartUpWelcomeDelay = new System.Windows.Forms.CheckBox();
            this.cboxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.cbxTranslationLanguageCode = new System.Windows.Forms.ComboBox();
            this.cboxTransferConfigAndAuthOnUpdate = new System.Windows.Forms.CheckBox();
            this.grboxOldSetting = new System.Windows.Forms.GroupBox();
            this.txtOldConfigPath = new System.Windows.Forms.TextBox();
            this.lblOldConfigPath = new System.Windows.Forms.Label();
            this.btnOldConfigPath = new System.Windows.Forms.Button();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.txtMaxTravelDistanceInMeters = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboxUseGPXPathing = new System.Windows.Forms.CheckBox();
            this.txtGPXFile = new System.Windows.Forms.TextBox();
            this.grboxEvolution = new System.Windows.Forms.GroupBox();
            this.lblGPXFile = new System.Windows.Forms.Label();
            this.txtEvolveAboveIVValue = new System.Windows.Forms.TextBox();
            this.lblEvolveAboveIVValue = new System.Windows.Forms.Label();
            this.cboxEvolveAllPokemonAboveIV = new System.Windows.Forms.CheckBox();
            this.cboxEvolveAllPokemonWithEnoughCandy = new System.Windows.Forms.CheckBox();
            this.lblPokemonsToEvolve = new System.Windows.Forms.Label();
            this.lstvwPokemonsToEvolve = new System.Windows.Forms.ListView();
            this.cboxKeepPokemonsThatCanEvolve = new System.Windows.Forms.CheckBox();
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage = new System.Windows.Forms.TextBox();
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage = new System.Windows.Forms.Label();
            this.cboxRenamePokemon = new System.Windows.Forms.CheckBox();
            this.cboxRenameOnlyAboveIv = new System.Windows.Forms.CheckBox();
            this.lblRenameTemplate = new System.Windows.Forms.Label();
            this.txtRenameTemplate = new System.Windows.Forms.TextBox();
            this.txtWebSocketPort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grboxAuthentication.SuspendLayout();
            this.grboxLocation.SuspendLayout();
            this.grboxGeneralConfig.SuspendLayout();
            this.grboxOldSetting.SuspendLayout();
            this.grboxEvolution.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TranslationLanguageCode";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grboxEvolution);
            this.panel1.Controls.Add(this.grboxAuthentication);
            this.panel1.Controls.Add(this.grboxLocation);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grboxGeneralConfig);
            this.panel1.Controls.Add(this.grboxOldSetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 811);
            this.panel1.TabIndex = 1;
            // 
            // grboxAuthentication
            // 
            this.grboxAuthentication.Controls.Add(this.lblPtcPassword);
            this.grboxAuthentication.Controls.Add(this.txtPtcPassword);
            this.grboxAuthentication.Controls.Add(this.lblPtcUsername);
            this.grboxAuthentication.Controls.Add(this.txtPtcUsername);
            this.grboxAuthentication.Controls.Add(this.lblGooglePassword);
            this.grboxAuthentication.Controls.Add(this.txtGooglePassword);
            this.grboxAuthentication.Controls.Add(this.lblGoogleUsername);
            this.grboxAuthentication.Controls.Add(this.cbxAuthType);
            this.grboxAuthentication.Controls.Add(this.txtGoogleUsername);
            this.grboxAuthentication.Controls.Add(this.label16);
            this.grboxAuthentication.Location = new System.Drawing.Point(3, 101);
            this.grboxAuthentication.Name = "grboxAuthentication";
            this.grboxAuthentication.Size = new System.Drawing.Size(259, 153);
            this.grboxAuthentication.TabIndex = 11;
            this.grboxAuthentication.TabStop = false;
            this.grboxAuthentication.Text = "Authentication";
            // 
            // lblPtcPassword
            // 
            this.lblPtcPassword.AutoSize = true;
            this.lblPtcPassword.Location = new System.Drawing.Point(6, 127);
            this.lblPtcPassword.Name = "lblPtcPassword";
            this.lblPtcPassword.Size = new System.Drawing.Size(69, 13);
            this.lblPtcPassword.TabIndex = 31;
            this.lblPtcPassword.Text = "PtcPassword";
            // 
            // txtPtcPassword
            // 
            this.txtPtcPassword.Location = new System.Drawing.Point(101, 124);
            this.txtPtcPassword.Name = "txtPtcPassword";
            this.txtPtcPassword.PasswordChar = '*';
            this.txtPtcPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPtcPassword.TabIndex = 30;
            this.txtPtcPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPtcUsername
            // 
            this.lblPtcUsername.AutoSize = true;
            this.lblPtcUsername.Location = new System.Drawing.Point(6, 101);
            this.lblPtcUsername.Name = "lblPtcUsername";
            this.lblPtcUsername.Size = new System.Drawing.Size(71, 13);
            this.lblPtcUsername.TabIndex = 29;
            this.lblPtcUsername.Text = "PtcUsername";
            // 
            // txtPtcUsername
            // 
            this.txtPtcUsername.Location = new System.Drawing.Point(101, 98);
            this.txtPtcUsername.Name = "txtPtcUsername";
            this.txtPtcUsername.Size = new System.Drawing.Size(152, 20);
            this.txtPtcUsername.TabIndex = 28;
            this.txtPtcUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGooglePassword
            // 
            this.lblGooglePassword.AutoSize = true;
            this.lblGooglePassword.Location = new System.Drawing.Point(6, 75);
            this.lblGooglePassword.Name = "lblGooglePassword";
            this.lblGooglePassword.Size = new System.Drawing.Size(87, 13);
            this.lblGooglePassword.TabIndex = 27;
            this.lblGooglePassword.Text = "GooglePassword";
            // 
            // txtGooglePassword
            // 
            this.txtGooglePassword.Location = new System.Drawing.Point(101, 72);
            this.txtGooglePassword.Name = "txtGooglePassword";
            this.txtGooglePassword.PasswordChar = '*';
            this.txtGooglePassword.Size = new System.Drawing.Size(152, 20);
            this.txtGooglePassword.TabIndex = 26;
            this.txtGooglePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGoogleUsername
            // 
            this.lblGoogleUsername.AutoSize = true;
            this.lblGoogleUsername.Location = new System.Drawing.Point(6, 49);
            this.lblGoogleUsername.Name = "lblGoogleUsername";
            this.lblGoogleUsername.Size = new System.Drawing.Size(89, 13);
            this.lblGoogleUsername.TabIndex = 25;
            this.lblGoogleUsername.Text = "GoogleUsername";
            // 
            // cbxAuthType
            // 
            this.cbxAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthType.FormattingEnabled = true;
            this.cbxAuthType.Location = new System.Drawing.Point(102, 19);
            this.cbxAuthType.Name = "cbxAuthType";
            this.cbxAuthType.Size = new System.Drawing.Size(151, 21);
            this.cbxAuthType.TabIndex = 24;
            this.cbxAuthType.SelectedIndexChanged += new System.EventHandler(this.cbxAuthType_SelectedIndexChanged);
            // 
            // txtGoogleUsername
            // 
            this.txtGoogleUsername.Location = new System.Drawing.Point(101, 46);
            this.txtGoogleUsername.Name = "txtGoogleUsername";
            this.txtGoogleUsername.Size = new System.Drawing.Size(152, 20);
            this.txtGoogleUsername.TabIndex = 8;
            this.txtGoogleUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "AuthType";
            // 
            // grboxLocation
            // 
            this.grboxLocation.Controls.Add(this.cboxDisableHumanWalking);
            this.grboxLocation.Controls.Add(this.lblGPXFile);
            this.grboxLocation.Controls.Add(this.txtGPXFile);
            this.grboxLocation.Controls.Add(this.cboxUseGPXPathing);
            this.grboxLocation.Controls.Add(this.txtMaxTravelDistanceInMeters);
            this.grboxLocation.Controls.Add(this.label17);
            this.grboxLocation.Controls.Add(this.txtMaxSpawnLocationOffset);
            this.grboxLocation.Controls.Add(this.txtWalkingSpeedInKilometerPerHour);
            this.grboxLocation.Controls.Add(this.label13);
            this.grboxLocation.Controls.Add(this.txtDefaultLongitude);
            this.grboxLocation.Controls.Add(this.label12);
            this.grboxLocation.Controls.Add(this.label11);
            this.grboxLocation.Controls.Add(this.txtDefaultLatitude);
            this.grboxLocation.Controls.Add(this.label10);
            this.grboxLocation.Controls.Add(this.txtDefaultAltitude);
            this.grboxLocation.Controls.Add(this.label9);
            this.grboxLocation.Location = new System.Drawing.Point(268, 12);
            this.grboxLocation.Name = "grboxLocation";
            this.grboxLocation.Size = new System.Drawing.Size(512, 207);
            this.grboxLocation.TabIndex = 10;
            this.grboxLocation.TabStop = false;
            this.grboxLocation.Text = "Location";
            // 
            // txtMaxSpawnLocationOffset
            // 
            this.txtMaxSpawnLocationOffset.Location = new System.Drawing.Point(155, 178);
            this.txtMaxSpawnLocationOffset.Name = "txtMaxSpawnLocationOffset";
            this.txtMaxSpawnLocationOffset.Size = new System.Drawing.Size(351, 20);
            this.txtMaxSpawnLocationOffset.TabIndex = 12;
            this.txtMaxSpawnLocationOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxSpawnLocationOffset.TextChanged += new System.EventHandler(this.txtMaxSpawnLocationOffset_TextChanged);
            this.txtMaxSpawnLocationOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // txtWalkingSpeedInKilometerPerHour
            // 
            this.txtWalkingSpeedInKilometerPerHour.Location = new System.Drawing.Point(326, 100);
            this.txtWalkingSpeedInKilometerPerHour.Name = "txtWalkingSpeedInKilometerPerHour";
            this.txtWalkingSpeedInKilometerPerHour.Size = new System.Drawing.Size(180, 20);
            this.txtWalkingSpeedInKilometerPerHour.TabIndex = 12;
            this.txtWalkingSpeedInKilometerPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWalkingSpeedInKilometerPerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "MaxSpawnLocationOffset";
            // 
            // txtDefaultLongitude
            // 
            this.txtDefaultLongitude.Location = new System.Drawing.Point(155, 74);
            this.txtDefaultLongitude.Name = "txtDefaultLongitude";
            this.txtDefaultLongitude.Size = new System.Drawing.Size(351, 20);
            this.txtDefaultLongitude.TabIndex = 12;
            this.txtDefaultLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "WalkingSpeedInKilometerPerHour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "DefaultLongitude";
            // 
            // txtDefaultLatitude
            // 
            this.txtDefaultLatitude.Location = new System.Drawing.Point(155, 48);
            this.txtDefaultLatitude.Name = "txtDefaultLatitude";
            this.txtDefaultLatitude.Size = new System.Drawing.Size(351, 20);
            this.txtDefaultLatitude.TabIndex = 10;
            this.txtDefaultLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "DefaultLatitude";
            // 
            // txtDefaultAltitude
            // 
            this.txtDefaultAltitude.Location = new System.Drawing.Point(155, 22);
            this.txtDefaultAltitude.Name = "txtDefaultAltitude";
            this.txtDefaultAltitude.Size = new System.Drawing.Size(351, 20);
            this.txtDefaultAltitude.TabIndex = 8;
            this.txtDefaultAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "DefaultAltitude";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 584);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 288);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Config";
            // 
            // txtDelayBetweenPokemonCatch
            // 
            this.txtDelayBetweenPokemonCatch.Location = new System.Drawing.Point(161, 212);
            this.txtDelayBetweenPokemonCatch.Name = "txtDelayBetweenPokemonCatch";
            this.txtDelayBetweenPokemonCatch.Size = new System.Drawing.Size(92, 20);
            this.txtDelayBetweenPokemonCatch.TabIndex = 22;
            this.txtDelayBetweenPokemonCatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayBetweenPokemonCatch.TextChanged += new System.EventHandler(this.txtDelayBetweenPokemonCatch_TextChanged);
            this.txtDelayBetweenPokemonCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "DelayBetweenPokemonCatch";
            // 
            // txtDelayBetweenPlayerActions
            // 
            this.txtDelayBetweenPlayerActions.Location = new System.Drawing.Point(161, 186);
            this.txtDelayBetweenPlayerActions.Name = "txtDelayBetweenPlayerActions";
            this.txtDelayBetweenPlayerActions.Size = new System.Drawing.Size(92, 20);
            this.txtDelayBetweenPlayerActions.TabIndex = 14;
            this.txtDelayBetweenPlayerActions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayBetweenPlayerActions.TextChanged += new System.EventHandler(this.txtDelayBetweenPlayerActions_TextChanged);
            this.txtDelayBetweenPlayerActions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // cboxDisableHumanWalking
            // 
            this.cboxDisableHumanWalking.AutoSize = true;
            this.cboxDisableHumanWalking.Location = new System.Drawing.Point(6, 102);
            this.cboxDisableHumanWalking.Name = "cboxDisableHumanWalking";
            this.cboxDisableHumanWalking.Size = new System.Drawing.Size(134, 17);
            this.cboxDisableHumanWalking.TabIndex = 21;
            this.cboxDisableHumanWalking.Text = "DisableHumanWalking";
            this.cboxDisableHumanWalking.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "DelayBetweenPlayerActions";
            // 
            // cbxUpgradePokemonMinimumStatsOperator
            // 
            this.cbxUpgradePokemonMinimumStatsOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpgradePokemonMinimumStatsOperator.Enabled = false;
            this.cbxUpgradePokemonMinimumStatsOperator.FormattingEnabled = true;
            this.cbxUpgradePokemonMinimumStatsOperator.Location = new System.Drawing.Point(420, 42);
            this.cbxUpgradePokemonMinimumStatsOperator.Name = "cbxUpgradePokemonMinimumStatsOperator";
            this.cbxUpgradePokemonMinimumStatsOperator.Size = new System.Drawing.Size(86, 21);
            this.cbxUpgradePokemonMinimumStatsOperator.TabIndex = 20;
            // 
            // txtUpgradePokemonIvMinimum
            // 
            this.txtUpgradePokemonIvMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpgradePokemonIvMinimum.Enabled = false;
            this.txtUpgradePokemonIvMinimum.Location = new System.Drawing.Point(156, 121);
            this.txtUpgradePokemonIvMinimum.Name = "txtUpgradePokemonIvMinimum";
            this.txtUpgradePokemonIvMinimum.Size = new System.Drawing.Size(350, 20);
            this.txtUpgradePokemonIvMinimum.TabIndex = 19;
            this.txtUpgradePokemonIvMinimum.Text = "0";
            this.txtUpgradePokemonIvMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUpgradePokemonIvMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // lblUpgradePokemonMinimumStatsOperator
            // 
            this.lblUpgradePokemonMinimumStatsOperator.AutoSize = true;
            this.lblUpgradePokemonMinimumStatsOperator.Enabled = false;
            this.lblUpgradePokemonMinimumStatsOperator.Location = new System.Drawing.Point(215, 45);
            this.lblUpgradePokemonMinimumStatsOperator.Name = "lblUpgradePokemonMinimumStatsOperator";
            this.lblUpgradePokemonMinimumStatsOperator.Size = new System.Drawing.Size(199, 13);
            this.lblUpgradePokemonMinimumStatsOperator.TabIndex = 18;
            this.lblUpgradePokemonMinimumStatsOperator.Text = "UpgradePokemonMinimumStatsOperator";
            // 
            // lblUpgradePokemonIvMinimum
            // 
            this.lblUpgradePokemonIvMinimum.AutoSize = true;
            this.lblUpgradePokemonIvMinimum.Enabled = false;
            this.lblUpgradePokemonIvMinimum.Location = new System.Drawing.Point(3, 123);
            this.lblUpgradePokemonIvMinimum.Name = "lblUpgradePokemonIvMinimum";
            this.lblUpgradePokemonIvMinimum.Size = new System.Drawing.Size(143, 13);
            this.lblUpgradePokemonIvMinimum.TabIndex = 18;
            this.lblUpgradePokemonIvMinimum.Text = "UpgradePokemonIvMinimum";
            // 
            // lblUpgradePokemonCpMinimum
            // 
            this.lblUpgradePokemonCpMinimum.AutoSize = true;
            this.lblUpgradePokemonCpMinimum.Enabled = false;
            this.lblUpgradePokemonCpMinimum.Location = new System.Drawing.Point(3, 97);
            this.lblUpgradePokemonCpMinimum.Name = "lblUpgradePokemonCpMinimum";
            this.lblUpgradePokemonCpMinimum.Size = new System.Drawing.Size(147, 13);
            this.lblUpgradePokemonCpMinimum.TabIndex = 17;
            this.lblUpgradePokemonCpMinimum.Text = "UpgradePokemonCpMinimum";
            // 
            // txtUpgradePokemonCpMinimum
            // 
            this.txtUpgradePokemonCpMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpgradePokemonCpMinimum.Enabled = false;
            this.txtUpgradePokemonCpMinimum.Location = new System.Drawing.Point(156, 95);
            this.txtUpgradePokemonCpMinimum.Name = "txtUpgradePokemonCpMinimum";
            this.txtUpgradePokemonCpMinimum.Size = new System.Drawing.Size(350, 20);
            this.txtUpgradePokemonCpMinimum.TabIndex = 16;
            this.txtUpgradePokemonCpMinimum.Text = "0";
            this.txtUpgradePokemonCpMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUpgradePokemonCpMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // lblLevelUpByCPOrIv
            // 
            this.lblLevelUpByCPOrIv.AutoSize = true;
            this.lblLevelUpByCPOrIv.Enabled = false;
            this.lblLevelUpByCPOrIv.Location = new System.Drawing.Point(6, 45);
            this.lblLevelUpByCPOrIv.Name = "lblLevelUpByCPOrIv";
            this.lblLevelUpByCPOrIv.Size = new System.Drawing.Size(93, 13);
            this.lblLevelUpByCPOrIv.TabIndex = 15;
            this.lblLevelUpByCPOrIv.Text = "LevelUpByCPOrIv";
            // 
            // cbxLevelUpByCPOrIv
            // 
            this.cbxLevelUpByCPOrIv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevelUpByCPOrIv.Enabled = false;
            this.cbxLevelUpByCPOrIv.FormattingEnabled = true;
            this.cbxLevelUpByCPOrIv.Location = new System.Drawing.Point(105, 42);
            this.cbxLevelUpByCPOrIv.Name = "cbxLevelUpByCPOrIv";
            this.cbxLevelUpByCPOrIv.Size = new System.Drawing.Size(47, 21);
            this.cbxLevelUpByCPOrIv.TabIndex = 10;
            // 
            // txtGetMinStarDustForLevelUp
            // 
            this.txtGetMinStarDustForLevelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetMinStarDustForLevelUp.Enabled = false;
            this.txtGetMinStarDustForLevelUp.Location = new System.Drawing.Point(155, 69);
            this.txtGetMinStarDustForLevelUp.Name = "txtGetMinStarDustForLevelUp";
            this.txtGetMinStarDustForLevelUp.Size = new System.Drawing.Size(351, 20);
            this.txtGetMinStarDustForLevelUp.TabIndex = 14;
            this.txtGetMinStarDustForLevelUp.Text = "0";
            this.txtGetMinStarDustForLevelUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGetMinStarDustForLevelUp.TextChanged += new System.EventHandler(this.txtGetMinStarDustForLevelUp_TextChanged);
            this.txtGetMinStarDustForLevelUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // lblGetMinStarDustForLevelUp
            // 
            this.lblGetMinStarDustForLevelUp.AutoSize = true;
            this.lblGetMinStarDustForLevelUp.Enabled = false;
            this.lblGetMinStarDustForLevelUp.Location = new System.Drawing.Point(6, 71);
            this.lblGetMinStarDustForLevelUp.Name = "lblGetMinStarDustForLevelUp";
            this.lblGetMinStarDustForLevelUp.Size = new System.Drawing.Size(137, 13);
            this.lblGetMinStarDustForLevelUp.TabIndex = 13;
            this.lblGetMinStarDustForLevelUp.Text = "GetMinStarDustForLevelUp";
            // 
            // txtAmountOfTimesToUpgradeLoop
            // 
            this.txtAmountOfTimesToUpgradeLoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOfTimesToUpgradeLoop.Enabled = false;
            this.txtAmountOfTimesToUpgradeLoop.Location = new System.Drawing.Point(381, 18);
            this.txtAmountOfTimesToUpgradeLoop.Name = "txtAmountOfTimesToUpgradeLoop";
            this.txtAmountOfTimesToUpgradeLoop.Size = new System.Drawing.Size(125, 20);
            this.txtAmountOfTimesToUpgradeLoop.TabIndex = 12;
            this.txtAmountOfTimesToUpgradeLoop.Text = "0";
            this.txtAmountOfTimesToUpgradeLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountOfTimesToUpgradeLoop.TextChanged += new System.EventHandler(this.txtAmountOfTimesToUpgradeLoop_TextChanged);
            this.txtAmountOfTimesToUpgradeLoop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // cboxAutomaticallyLevelUpPokemon
            // 
            this.cboxAutomaticallyLevelUpPokemon.AutoSize = true;
            this.cboxAutomaticallyLevelUpPokemon.Location = new System.Drawing.Point(6, 19);
            this.cboxAutomaticallyLevelUpPokemon.Name = "cboxAutomaticallyLevelUpPokemon";
            this.cboxAutomaticallyLevelUpPokemon.Size = new System.Drawing.Size(173, 17);
            this.cboxAutomaticallyLevelUpPokemon.TabIndex = 10;
            this.cboxAutomaticallyLevelUpPokemon.Text = "AutomaticallyLevelUpPokemon";
            this.cboxAutomaticallyLevelUpPokemon.UseVisualStyleBackColor = true;
            this.cboxAutomaticallyLevelUpPokemon.CheckedChanged += new System.EventHandler(this.cboxAutomaticallyLevelUpPokemon_CheckedChanged);
            // 
            // lblAmountOfTimesToUpgradeLoop
            // 
            this.lblAmountOfTimesToUpgradeLoop.AutoSize = true;
            this.lblAmountOfTimesToUpgradeLoop.Enabled = false;
            this.lblAmountOfTimesToUpgradeLoop.Location = new System.Drawing.Point(215, 20);
            this.lblAmountOfTimesToUpgradeLoop.Name = "lblAmountOfTimesToUpgradeLoop";
            this.lblAmountOfTimesToUpgradeLoop.Size = new System.Drawing.Size(160, 13);
            this.lblAmountOfTimesToUpgradeLoop.TabIndex = 11;
            this.lblAmountOfTimesToUpgradeLoop.Text = "AmountOfTimesToUpgradeLoop";
            // 
            // grboxGeneralConfig
            // 
            this.grboxGeneralConfig.Controls.Add(this.txtWebSocketPort);
            this.grboxGeneralConfig.Controls.Add(this.label18);
            this.grboxGeneralConfig.Controls.Add(this.txtRenameTemplate);
            this.grboxGeneralConfig.Controls.Add(this.lblRenameTemplate);
            this.grboxGeneralConfig.Controls.Add(this.cboxRenameOnlyAboveIv);
            this.grboxGeneralConfig.Controls.Add(this.cboxRenamePokemon);
            this.grboxGeneralConfig.Controls.Add(this.txtDelayBetweenPokemonCatch);
            this.grboxGeneralConfig.Controls.Add(this.cboxDumpPokemonStats);
            this.grboxGeneralConfig.Controls.Add(this.label15);
            this.grboxGeneralConfig.Controls.Add(this.cboxShowPokeballCountsBeforeRecycle);
            this.grboxGeneralConfig.Controls.Add(this.txtDelayBetweenPlayerActions);
            this.grboxGeneralConfig.Controls.Add(this.txtAmountOfPokemonToDisplayOnStart);
            this.grboxGeneralConfig.Controls.Add(this.label2);
            this.grboxGeneralConfig.Controls.Add(this.label14);
            this.grboxGeneralConfig.Controls.Add(this.cboxStartUpWelcomeDelay);
            this.grboxGeneralConfig.Controls.Add(this.cboxAutoUpdate);
            this.grboxGeneralConfig.Controls.Add(this.cbxTranslationLanguageCode);
            this.grboxGeneralConfig.Controls.Add(this.cboxTransferConfigAndAuthOnUpdate);
            this.grboxGeneralConfig.Controls.Add(this.label1);
            this.grboxGeneralConfig.Location = new System.Drawing.Point(3, 260);
            this.grboxGeneralConfig.Name = "grboxGeneralConfig";
            this.grboxGeneralConfig.Size = new System.Drawing.Size(259, 318);
            this.grboxGeneralConfig.TabIndex = 9;
            this.grboxGeneralConfig.TabStop = false;
            this.grboxGeneralConfig.Text = "General Config";
            // 
            // cboxDumpPokemonStats
            // 
            this.cboxDumpPokemonStats.AutoSize = true;
            this.cboxDumpPokemonStats.Location = new System.Drawing.Point(9, 164);
            this.cboxDumpPokemonStats.Name = "cboxDumpPokemonStats";
            this.cboxDumpPokemonStats.Size = new System.Drawing.Size(123, 17);
            this.cboxDumpPokemonStats.TabIndex = 22;
            this.cboxDumpPokemonStats.Text = "DumpPokemonStats";
            this.cboxDumpPokemonStats.UseVisualStyleBackColor = true;
            // 
            // cboxShowPokeballCountsBeforeRecycle
            // 
            this.cboxShowPokeballCountsBeforeRecycle.AutoSize = true;
            this.cboxShowPokeballCountsBeforeRecycle.Location = new System.Drawing.Point(9, 141);
            this.cboxShowPokeballCountsBeforeRecycle.Name = "cboxShowPokeballCountsBeforeRecycle";
            this.cboxShowPokeballCountsBeforeRecycle.Size = new System.Drawing.Size(197, 17);
            this.cboxShowPokeballCountsBeforeRecycle.TabIndex = 10;
            this.cboxShowPokeballCountsBeforeRecycle.Text = "ShowPokeballCountsBeforeRecycle";
            this.cboxShowPokeballCountsBeforeRecycle.UseVisualStyleBackColor = true;
            // 
            // txtAmountOfPokemonToDisplayOnStart
            // 
            this.txtAmountOfPokemonToDisplayOnStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOfPokemonToDisplayOnStart.Location = new System.Drawing.Point(194, 115);
            this.txtAmountOfPokemonToDisplayOnStart.Name = "txtAmountOfPokemonToDisplayOnStart";
            this.txtAmountOfPokemonToDisplayOnStart.Size = new System.Drawing.Size(59, 20);
            this.txtAmountOfPokemonToDisplayOnStart.TabIndex = 8;
            this.txtAmountOfPokemonToDisplayOnStart.Text = "10";
            this.txtAmountOfPokemonToDisplayOnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountOfPokemonToDisplayOnStart.TextChanged += new System.EventHandler(this.txtAmountOfPokemonToDisplayOnStart_TextChanged_1);
            this.txtAmountOfPokemonToDisplayOnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AmountOfPokemonToDisplayOnStart";
            // 
            // cboxStartUpWelcomeDelay
            // 
            this.cboxStartUpWelcomeDelay.AutoSize = true;
            this.cboxStartUpWelcomeDelay.Location = new System.Drawing.Point(9, 92);
            this.cboxStartUpWelcomeDelay.Name = "cboxStartUpWelcomeDelay";
            this.cboxStartUpWelcomeDelay.Size = new System.Drawing.Size(134, 17);
            this.cboxStartUpWelcomeDelay.TabIndex = 5;
            this.cboxStartUpWelcomeDelay.Text = "StartUpWelcomeDelay";
            this.cboxStartUpWelcomeDelay.UseVisualStyleBackColor = true;
            // 
            // cboxAutoUpdate
            // 
            this.cboxAutoUpdate.AutoSize = true;
            this.cboxAutoUpdate.Location = new System.Drawing.Point(9, 19);
            this.cboxAutoUpdate.Name = "cboxAutoUpdate";
            this.cboxAutoUpdate.Size = new System.Drawing.Size(83, 17);
            this.cboxAutoUpdate.TabIndex = 3;
            this.cboxAutoUpdate.Text = "AutoUpdate";
            this.cboxAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxTranslationLanguageCode
            // 
            this.cbxTranslationLanguageCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTranslationLanguageCode.BackColor = System.Drawing.Color.White;
            this.cbxTranslationLanguageCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTranslationLanguageCode.DropDownWidth = 5;
            this.cbxTranslationLanguageCode.FormattingEnabled = true;
            this.cbxTranslationLanguageCode.Items.AddRange(new object[] {
            "da",
            "de",
            "en",
            "es",
            "et",
            "fr",
            "gr",
            "hu",
            "id",
            "it",
            "lt",
            "nt",
            "no",
            "pl",
            "pt-br",
            "pt-pt",
            "ru_RU",
            "sv",
            "th",
            "tr",
            "uk_UA",
            "zh_CN",
            "zh_tw"});
            this.cbxTranslationLanguageCode.Location = new System.Drawing.Point(144, 42);
            this.cbxTranslationLanguageCode.Name = "cbxTranslationLanguageCode";
            this.cbxTranslationLanguageCode.Size = new System.Drawing.Size(109, 21);
            this.cbxTranslationLanguageCode.TabIndex = 1;
            // 
            // cboxTransferConfigAndAuthOnUpdate
            // 
            this.cboxTransferConfigAndAuthOnUpdate.AutoSize = true;
            this.cboxTransferConfigAndAuthOnUpdate.Location = new System.Drawing.Point(9, 69);
            this.cboxTransferConfigAndAuthOnUpdate.Name = "cboxTransferConfigAndAuthOnUpdate";
            this.cboxTransferConfigAndAuthOnUpdate.Size = new System.Drawing.Size(185, 17);
            this.cboxTransferConfigAndAuthOnUpdate.TabIndex = 4;
            this.cboxTransferConfigAndAuthOnUpdate.Text = "TransferConfigAndAuthOnUpdate";
            this.cboxTransferConfigAndAuthOnUpdate.UseVisualStyleBackColor = true;
            // 
            // grboxOldSetting
            // 
            this.grboxOldSetting.Controls.Add(this.txtOldConfigPath);
            this.grboxOldSetting.Controls.Add(this.lblOldConfigPath);
            this.grboxOldSetting.Controls.Add(this.btnOldConfigPath);
            this.grboxOldSetting.Controls.Add(this.btnUpdateSettings);
            this.grboxOldSetting.Location = new System.Drawing.Point(3, 12);
            this.grboxOldSetting.Name = "grboxOldSetting";
            this.grboxOldSetting.Size = new System.Drawing.Size(259, 83);
            this.grboxOldSetting.TabIndex = 8;
            this.grboxOldSetting.TabStop = false;
            this.grboxOldSetting.Text = "Old Config";
            // 
            // txtOldConfigPath
            // 
            this.txtOldConfigPath.Location = new System.Drawing.Point(92, 22);
            this.txtOldConfigPath.Name = "txtOldConfigPath";
            this.txtOldConfigPath.Size = new System.Drawing.Size(161, 20);
            this.txtOldConfigPath.TabIndex = 2;
            // 
            // lblOldConfigPath
            // 
            this.lblOldConfigPath.AutoSize = true;
            this.lblOldConfigPath.Location = new System.Drawing.Point(6, 25);
            this.lblOldConfigPath.Name = "lblOldConfigPath";
            this.lblOldConfigPath.Size = new System.Drawing.Size(80, 13);
            this.lblOldConfigPath.TabIndex = 6;
            this.lblOldConfigPath.Text = "Old Config path";
            // 
            // btnOldConfigPath
            // 
            this.btnOldConfigPath.Location = new System.Drawing.Point(9, 48);
            this.btnOldConfigPath.Name = "btnOldConfigPath";
            this.btnOldConfigPath.Size = new System.Drawing.Size(77, 23);
            this.btnOldConfigPath.TabIndex = 5;
            this.btnOldConfigPath.Text = "Browse";
            this.btnOldConfigPath.UseVisualStyleBackColor = true;
            this.btnOldConfigPath.Click += new System.EventHandler(this.btnOldConfigPath_Click);
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Location = new System.Drawing.Point(92, 48);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(161, 23);
            this.btnUpdateSettings.TabIndex = 7;
            this.btnUpdateSettings.Text = "Parse settings";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // txtMaxTravelDistanceInMeters
            // 
            this.txtMaxTravelDistanceInMeters.Location = new System.Drawing.Point(155, 126);
            this.txtMaxTravelDistanceInMeters.Name = "txtMaxTravelDistanceInMeters";
            this.txtMaxTravelDistanceInMeters.Size = new System.Drawing.Size(351, 20);
            this.txtMaxTravelDistanceInMeters.TabIndex = 14;
            this.txtMaxTravelDistanceInMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxTravelDistanceInMeters.TextChanged += new System.EventHandler(this.txtMaxTravelDistanceInMeters_TextChanged);
            this.txtMaxTravelDistanceInMeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "MaxTravelDistanceInMeters ";
            // 
            // cboxUseGPXPathing
            // 
            this.cboxUseGPXPathing.AutoSize = true;
            this.cboxUseGPXPathing.Location = new System.Drawing.Point(6, 154);
            this.cboxUseGPXPathing.Name = "cboxUseGPXPathing";
            this.cboxUseGPXPathing.Size = new System.Drawing.Size(103, 17);
            this.cboxUseGPXPathing.TabIndex = 24;
            this.cboxUseGPXPathing.Text = "UseGPXPathing";
            this.cboxUseGPXPathing.UseVisualStyleBackColor = true;
            this.cboxUseGPXPathing.CheckedChanged += new System.EventHandler(this.cboxUseGPXPathing_CheckedChanged);
            // 
            // txtGPXFile
            // 
            this.txtGPXFile.Enabled = false;
            this.txtGPXFile.Location = new System.Drawing.Point(203, 152);
            this.txtGPXFile.Name = "txtGPXFile";
            this.txtGPXFile.Size = new System.Drawing.Size(303, 20);
            this.txtGPXFile.TabIndex = 8;
            // 
            // grboxEvolution
            // 
            this.grboxEvolution.Controls.Add(this.txtEvolveKeptPokemonsAtStorageUsagePercentage);
            this.grboxEvolution.Controls.Add(this.lblEvolveKeptPokemonsAtStorageUsagePercentage);
            this.grboxEvolution.Controls.Add(this.cboxKeepPokemonsThatCanEvolve);
            this.grboxEvolution.Controls.Add(this.lstvwPokemonsToEvolve);
            this.grboxEvolution.Controls.Add(this.lblPokemonsToEvolve);
            this.grboxEvolution.Controls.Add(this.cboxEvolveAllPokemonWithEnoughCandy);
            this.grboxEvolution.Controls.Add(this.cboxEvolveAllPokemonAboveIV);
            this.grboxEvolution.Controls.Add(this.txtEvolveAboveIVValue);
            this.grboxEvolution.Controls.Add(this.lblEvolveAboveIVValue);
            this.grboxEvolution.Location = new System.Drawing.Point(268, 225);
            this.grboxEvolution.Name = "grboxEvolution";
            this.grboxEvolution.Size = new System.Drawing.Size(512, 237);
            this.grboxEvolution.TabIndex = 12;
            this.grboxEvolution.TabStop = false;
            this.grboxEvolution.Text = "Evolution";
            // 
            // lblGPXFile
            // 
            this.lblGPXFile.AutoSize = true;
            this.lblGPXFile.Location = new System.Drawing.Point(152, 155);
            this.lblGPXFile.Name = "lblGPXFile";
            this.lblGPXFile.Size = new System.Drawing.Size(45, 13);
            this.lblGPXFile.TabIndex = 25;
            this.lblGPXFile.Text = "GPXFile";
            // 
            // txtEvolveAboveIVValue
            // 
            this.txtEvolveAboveIVValue.Enabled = false;
            this.txtEvolveAboveIVValue.Location = new System.Drawing.Point(291, 40);
            this.txtEvolveAboveIVValue.Name = "txtEvolveAboveIVValue";
            this.txtEvolveAboveIVValue.Size = new System.Drawing.Size(215, 20);
            this.txtEvolveAboveIVValue.TabIndex = 26;
            this.txtEvolveAboveIVValue.Text = "0";
            this.txtEvolveAboveIVValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEvolveAboveIVValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // lblEvolveAboveIVValue
            // 
            this.lblEvolveAboveIVValue.AutoSize = true;
            this.lblEvolveAboveIVValue.Enabled = false;
            this.lblEvolveAboveIVValue.Location = new System.Drawing.Point(177, 43);
            this.lblEvolveAboveIVValue.Name = "lblEvolveAboveIVValue";
            this.lblEvolveAboveIVValue.Size = new System.Drawing.Size(108, 13);
            this.lblEvolveAboveIVValue.TabIndex = 27;
            this.lblEvolveAboveIVValue.Text = "EvolveAboveIVValue";
            // 
            // cboxEvolveAllPokemonAboveIV
            // 
            this.cboxEvolveAllPokemonAboveIV.AutoSize = true;
            this.cboxEvolveAllPokemonAboveIV.Location = new System.Drawing.Point(6, 42);
            this.cboxEvolveAllPokemonAboveIV.Name = "cboxEvolveAllPokemonAboveIV";
            this.cboxEvolveAllPokemonAboveIV.Size = new System.Drawing.Size(159, 17);
            this.cboxEvolveAllPokemonAboveIV.TabIndex = 13;
            this.cboxEvolveAllPokemonAboveIV.Text = "EvolveAllPokemonAboveIV ";
            this.cboxEvolveAllPokemonAboveIV.UseVisualStyleBackColor = true;
            this.cboxEvolveAllPokemonAboveIV.CheckedChanged += new System.EventHandler(this.cboxEvolveAllPokemonAboveIV_CheckedChanged);
            // 
            // cboxEvolveAllPokemonWithEnoughCandy
            // 
            this.cboxEvolveAllPokemonWithEnoughCandy.AutoSize = true;
            this.cboxEvolveAllPokemonWithEnoughCandy.Location = new System.Drawing.Point(6, 19);
            this.cboxEvolveAllPokemonWithEnoughCandy.Name = "cboxEvolveAllPokemonWithEnoughCandy";
            this.cboxEvolveAllPokemonWithEnoughCandy.Size = new System.Drawing.Size(204, 17);
            this.cboxEvolveAllPokemonWithEnoughCandy.TabIndex = 28;
            this.cboxEvolveAllPokemonWithEnoughCandy.Text = "EvolveAllPokemonWithEnoughCandy";
            this.cboxEvolveAllPokemonWithEnoughCandy.UseVisualStyleBackColor = true;
            this.cboxEvolveAllPokemonWithEnoughCandy.CheckedChanged += new System.EventHandler(this.cboxEvolveAllPokemonWithEnoughCandy_CheckedChanged);
            // 
            // lblPokemonsToEvolve
            // 
            this.lblPokemonsToEvolve.AutoSize = true;
            this.lblPokemonsToEvolve.Enabled = false;
            this.lblPokemonsToEvolve.Location = new System.Drawing.Point(3, 63);
            this.lblPokemonsToEvolve.Name = "lblPokemonsToEvolve";
            this.lblPokemonsToEvolve.Size = new System.Drawing.Size(103, 13);
            this.lblPokemonsToEvolve.TabIndex = 30;
            this.lblPokemonsToEvolve.Text = "PokemonsToEvolve";
            // 
            // lstvwPokemonsToEvolve
            // 
            this.lstvwPokemonsToEvolve.AllowDrop = true;
            this.lstvwPokemonsToEvolve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvwPokemonsToEvolve.CheckBoxes = true;
            this.lstvwPokemonsToEvolve.Enabled = false;
            this.lstvwPokemonsToEvolve.FullRowSelect = true;
            this.lstvwPokemonsToEvolve.GridLines = true;
            this.lstvwPokemonsToEvolve.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstvwPokemonsToEvolve.Location = new System.Drawing.Point(6, 79);
            this.lstvwPokemonsToEvolve.Name = "lstvwPokemonsToEvolve";
            this.lstvwPokemonsToEvolve.Size = new System.Drawing.Size(500, 122);
            this.lstvwPokemonsToEvolve.TabIndex = 13;
            this.lstvwPokemonsToEvolve.UseCompatibleStateImageBehavior = false;
            this.lstvwPokemonsToEvolve.View = System.Windows.Forms.View.List;
            // 
            // cboxKeepPokemonsThatCanEvolve
            // 
            this.cboxKeepPokemonsThatCanEvolve.AutoSize = true;
            this.cboxKeepPokemonsThatCanEvolve.Location = new System.Drawing.Point(6, 210);
            this.cboxKeepPokemonsThatCanEvolve.Name = "cboxKeepPokemonsThatCanEvolve";
            this.cboxKeepPokemonsThatCanEvolve.Size = new System.Drawing.Size(175, 17);
            this.cboxKeepPokemonsThatCanEvolve.TabIndex = 31;
            this.cboxKeepPokemonsThatCanEvolve.Text = "KeepPokemonsThatCanEvolve";
            this.cboxKeepPokemonsThatCanEvolve.UseVisualStyleBackColor = true;
            this.cboxKeepPokemonsThatCanEvolve.CheckedChanged += new System.EventHandler(this.cboxKeepPokemonsThatCanEvolve_CheckedChanged);
            // 
            // txtEvolveKeptPokemonsAtStorageUsagePercentage
            // 
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = false;
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.Location = new System.Drawing.Point(466, 207);
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.Name = "txtEvolveKeptPokemonsAtStorageUsagePercentage";
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.Size = new System.Drawing.Size(40, 20);
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.TabIndex = 32;
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.Text = "0";
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEvolveKeptPokemonsAtStorageUsagePercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // lblEvolveKeptPokemonsAtStorageUsagePercentage
            // 
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.AutoSize = true;
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.Enabled = false;
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.Location = new System.Drawing.Point(215, 210);
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.Name = "lblEvolveKeptPokemonsAtStorageUsagePercentage";
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.Size = new System.Drawing.Size(245, 13);
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.TabIndex = 33;
            this.lblEvolveKeptPokemonsAtStorageUsagePercentage.Text = "EvolveKeptPokemonsAtStorageUsagePercentage";
            // 
            // cboxRenamePokemon
            // 
            this.cboxRenamePokemon.AutoSize = true;
            this.cboxRenamePokemon.Location = new System.Drawing.Point(9, 238);
            this.cboxRenamePokemon.Name = "cboxRenamePokemon";
            this.cboxRenamePokemon.Size = new System.Drawing.Size(111, 17);
            this.cboxRenamePokemon.TabIndex = 24;
            this.cboxRenamePokemon.Text = "RenamePokemon";
            this.cboxRenamePokemon.UseVisualStyleBackColor = true;
            this.cboxRenamePokemon.CheckedChanged += new System.EventHandler(this.cboxRenamePokemon_CheckedChanged);
            // 
            // cboxRenameOnlyAboveIv
            // 
            this.cboxRenameOnlyAboveIv.AutoSize = true;
            this.cboxRenameOnlyAboveIv.Enabled = false;
            this.cboxRenameOnlyAboveIv.Location = new System.Drawing.Point(126, 238);
            this.cboxRenameOnlyAboveIv.Name = "cboxRenameOnlyAboveIv";
            this.cboxRenameOnlyAboveIv.Size = new System.Drawing.Size(127, 17);
            this.cboxRenameOnlyAboveIv.TabIndex = 25;
            this.cboxRenameOnlyAboveIv.Text = "RenameOnlyAboveIv";
            this.cboxRenameOnlyAboveIv.UseVisualStyleBackColor = true;
            // 
            // lblRenameTemplate
            // 
            this.lblRenameTemplate.AutoSize = true;
            this.lblRenameTemplate.Enabled = false;
            this.lblRenameTemplate.Location = new System.Drawing.Point(6, 264);
            this.lblRenameTemplate.Name = "lblRenameTemplate";
            this.lblRenameTemplate.Size = new System.Drawing.Size(91, 13);
            this.lblRenameTemplate.TabIndex = 26;
            this.lblRenameTemplate.Text = "RenameTemplate";
            // 
            // txtRenameTemplate
            // 
            this.txtRenameTemplate.Enabled = false;
            this.txtRenameTemplate.Location = new System.Drawing.Point(103, 261);
            this.txtRenameTemplate.Name = "txtRenameTemplate";
            this.txtRenameTemplate.Size = new System.Drawing.Size(150, 20);
            this.txtRenameTemplate.TabIndex = 13;
            this.txtRenameTemplate.Text = "{1}_{0}";
            this.txtRenameTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWebSocketPort
            // 
            this.txtWebSocketPort.Location = new System.Drawing.Point(103, 287);
            this.txtWebSocketPort.Name = "txtWebSocketPort";
            this.txtWebSocketPort.Size = new System.Drawing.Size(150, 20);
            this.txtWebSocketPort.TabIndex = 27;
            this.txtWebSocketPort.Text = "14251";
            this.txtWebSocketPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWebSocketPort.TextChanged += new System.EventHandler(this.txtWebSocketPort_TextChanged);
            this.txtWebSocketPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "WebSocketPort";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGetMinStarDustForLevelUp);
            this.groupBox2.Controls.Add(this.cbxUpgradePokemonMinimumStatsOperator);
            this.groupBox2.Controls.Add(this.lblGetMinStarDustForLevelUp);
            this.groupBox2.Controls.Add(this.cboxAutomaticallyLevelUpPokemon);
            this.groupBox2.Controls.Add(this.txtAmountOfTimesToUpgradeLoop);
            this.groupBox2.Controls.Add(this.lblUpgradePokemonMinimumStatsOperator);
            this.groupBox2.Controls.Add(this.lblAmountOfTimesToUpgradeLoop);
            this.groupBox2.Controls.Add(this.txtUpgradePokemonIvMinimum);
            this.groupBox2.Controls.Add(this.lblLevelUpByCPOrIv);
            this.groupBox2.Controls.Add(this.cbxLevelUpByCPOrIv);
            this.groupBox2.Controls.Add(this.lblUpgradePokemonIvMinimum);
            this.groupBox2.Controls.Add(this.lblUpgradePokemonCpMinimum);
            this.groupBox2.Controls.Add(this.txtUpgradePokemonCpMinimum);
            this.groupBox2.Location = new System.Drawing.Point(268, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 154);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upgrade";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 811);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.grboxAuthentication.ResumeLayout(false);
            this.grboxAuthentication.PerformLayout();
            this.grboxLocation.ResumeLayout(false);
            this.grboxLocation.PerformLayout();
            this.grboxGeneralConfig.ResumeLayout(false);
            this.grboxGeneralConfig.PerformLayout();
            this.grboxOldSetting.ResumeLayout(false);
            this.grboxOldSetting.PerformLayout();
            this.grboxEvolution.ResumeLayout(false);
            this.grboxEvolution.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxTranslationLanguageCode;
        private System.Windows.Forms.CheckBox cboxAutoUpdate;
        private System.Windows.Forms.CheckBox cboxTransferConfigAndAuthOnUpdate;
        private System.Windows.Forms.Button btnOldConfigPath;
        private System.Windows.Forms.TextBox txtOldConfigPath;
        private System.Windows.Forms.Label lblOldConfigPath;
        private System.Windows.Forms.Button btnUpdateSettings;
        private System.Windows.Forms.GroupBox grboxOldSetting;
        private System.Windows.Forms.GroupBox grboxGeneralConfig;
        private System.Windows.Forms.CheckBox cboxStartUpWelcomeDelay;
        private System.Windows.Forms.TextBox txtAmountOfPokemonToDisplayOnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxShowPokeballCountsBeforeRecycle;
        private System.Windows.Forms.CheckBox cboxAutomaticallyLevelUpPokemon;
        private System.Windows.Forms.TextBox txtAmountOfTimesToUpgradeLoop;
        private System.Windows.Forms.Label lblAmountOfTimesToUpgradeLoop;
        private System.Windows.Forms.TextBox txtGetMinStarDustForLevelUp;
        private System.Windows.Forms.Label lblGetMinStarDustForLevelUp;
        private System.Windows.Forms.Label lblLevelUpByCPOrIv;
        private System.Windows.Forms.ComboBox cbxLevelUpByCPOrIv;
        private System.Windows.Forms.Label lblUpgradePokemonCpMinimum;
        private System.Windows.Forms.TextBox txtUpgradePokemonCpMinimum;
        private System.Windows.Forms.TextBox txtUpgradePokemonIvMinimum;
        private System.Windows.Forms.Label lblUpgradePokemonIvMinimum;
        private System.Windows.Forms.ComboBox cbxUpgradePokemonMinimumStatsOperator;
        private System.Windows.Forms.Label lblUpgradePokemonMinimumStatsOperator;
        private System.Windows.Forms.CheckBox cboxDisableHumanWalking;
        private System.Windows.Forms.CheckBox cboxDumpPokemonStats;
        private System.Windows.Forms.GroupBox grboxLocation;
        private System.Windows.Forms.TextBox txtDefaultAltitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDefaultLongitude;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDefaultLatitude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWalkingSpeedInKilometerPerHour;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxSpawnLocationOffset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDelayBetweenPlayerActions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDelayBetweenPokemonCatch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grboxAuthentication;
        private System.Windows.Forms.Label lblGooglePassword;
        private System.Windows.Forms.TextBox txtGooglePassword;
        private System.Windows.Forms.Label lblGoogleUsername;
        private System.Windows.Forms.ComboBox cbxAuthType;
        private System.Windows.Forms.TextBox txtGoogleUsername;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPtcPassword;
        private System.Windows.Forms.TextBox txtPtcPassword;
        private System.Windows.Forms.Label lblPtcUsername;
        private System.Windows.Forms.TextBox txtPtcUsername;
        private System.Windows.Forms.TextBox txtMaxTravelDistanceInMeters;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cboxUseGPXPathing;
        private System.Windows.Forms.TextBox txtGPXFile;
        private System.Windows.Forms.GroupBox grboxEvolution;
        private System.Windows.Forms.Label lblGPXFile;
        private System.Windows.Forms.CheckBox cboxEvolveAllPokemonAboveIV;
        private System.Windows.Forms.TextBox txtEvolveAboveIVValue;
        private System.Windows.Forms.Label lblEvolveAboveIVValue;
        private System.Windows.Forms.CheckBox cboxEvolveAllPokemonWithEnoughCandy;
        private System.Windows.Forms.Label lblPokemonsToEvolve;
        private System.Windows.Forms.ListView lstvwPokemonsToEvolve;
        private System.Windows.Forms.CheckBox cboxKeepPokemonsThatCanEvolve;
        private System.Windows.Forms.TextBox txtEvolveKeptPokemonsAtStorageUsagePercentage;
        private System.Windows.Forms.Label lblEvolveKeptPokemonsAtStorageUsagePercentage;
        private System.Windows.Forms.CheckBox cboxRenamePokemon;
        private System.Windows.Forms.CheckBox cboxRenameOnlyAboveIv;
        private System.Windows.Forms.TextBox txtRenameTemplate;
        private System.Windows.Forms.Label lblRenameTemplate;
        private System.Windows.Forms.TextBox txtWebSocketPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

