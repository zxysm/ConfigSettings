namespace ConfigSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grboxGeneralConfig = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxShowPokeballCountsBeforeRecycle = new System.Windows.Forms.CheckBox();
            this.cboxAutomaticallyLevelUpPokemon = new System.Windows.Forms.CheckBox();
            this.txtAmountOfTimesToUpgradeLoop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGetMinStarDustForLevelUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLevelUpByCPOrIv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpgradePokemonCpMinimum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpgradePokemonIvMinimum = new System.Windows.Forms.TextBox();
            this.cbxUpgradePokemonMinimumStatsOperator = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxDisableHumanWalking = new System.Windows.Forms.CheckBox();
            this.cboxDumpPokemonStats = new System.Windows.Forms.CheckBox();
            this.grboxLocation = new System.Windows.Forms.GroupBox();
            this.txtDefaultAltitude = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDefaultLatitude = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDefaultLongitude = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWalkingSpeedInKilometerPerHour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaxSpawnLocationOffset = new System.Windows.Forms.TextBox();
            this.txtDelayBetweenPlayerActions = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDelayBetweenPokemonCatch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grboxGeneralConfig.SuspendLayout();
            this.grboxOldSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grboxLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TranslationLanguageCode";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
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
            // grboxGeneralConfig
            // 
            this.grboxGeneralConfig.Controls.Add(this.cboxDumpPokemonStats);
            this.grboxGeneralConfig.Controls.Add(this.cboxShowPokeballCountsBeforeRecycle);
            this.grboxGeneralConfig.Controls.Add(this.txtAmountOfPokemonToDisplayOnStart);
            this.grboxGeneralConfig.Controls.Add(this.label2);
            this.grboxGeneralConfig.Controls.Add(this.cboxStartUpWelcomeDelay);
            this.grboxGeneralConfig.Controls.Add(this.cboxAutoUpdate);
            this.grboxGeneralConfig.Controls.Add(this.cbxTranslationLanguageCode);
            this.grboxGeneralConfig.Controls.Add(this.cboxTransferConfigAndAuthOnUpdate);
            this.grboxGeneralConfig.Controls.Add(this.label1);
            this.grboxGeneralConfig.Location = new System.Drawing.Point(3, 101);
            this.grboxGeneralConfig.Name = "grboxGeneralConfig";
            this.grboxGeneralConfig.Size = new System.Drawing.Size(259, 189);
            this.grboxGeneralConfig.TabIndex = 9;
            this.grboxGeneralConfig.TabStop = false;
            this.grboxGeneralConfig.Text = "General Config";
            // 
            // txtAmountOfPokemonToDisplayOnStart
            // 
            this.txtAmountOfPokemonToDisplayOnStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOfPokemonToDisplayOnStart.Location = new System.Drawing.Point(191, 115);
            this.txtAmountOfPokemonToDisplayOnStart.Name = "txtAmountOfPokemonToDisplayOnStart";
            this.txtAmountOfPokemonToDisplayOnStart.Size = new System.Drawing.Size(45, 20);
            this.txtAmountOfPokemonToDisplayOnStart.TabIndex = 8;
            this.txtAmountOfPokemonToDisplayOnStart.Text = "10";
            this.txtAmountOfPokemonToDisplayOnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountOfPokemonToDisplayOnStart.TextChanged += new System.EventHandler(this.txtAmountOfPokemonToDisplayOnStart_TextChanged_1);
            this.txtAmountOfPokemonToDisplayOnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AmountOfPokemonToDisplayOnStart";
            // 
            // cboxStartUpWelcomeDelay
            // 
            this.cboxStartUpWelcomeDelay.AutoSize = true;
            this.cboxStartUpWelcomeDelay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxStartUpWelcomeDelay.Location = new System.Drawing.Point(6, 92);
            this.cboxStartUpWelcomeDelay.Name = "cboxStartUpWelcomeDelay";
            this.cboxStartUpWelcomeDelay.Size = new System.Drawing.Size(134, 17);
            this.cboxStartUpWelcomeDelay.TabIndex = 5;
            this.cboxStartUpWelcomeDelay.Text = "StartUpWelcomeDelay";
            this.cboxStartUpWelcomeDelay.UseVisualStyleBackColor = true;
            // 
            // cboxAutoUpdate
            // 
            this.cboxAutoUpdate.AutoSize = true;
            this.cboxAutoUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxAutoUpdate.Location = new System.Drawing.Point(6, 19);
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
            this.cbxTranslationLanguageCode.Location = new System.Drawing.Point(141, 42);
            this.cbxTranslationLanguageCode.Name = "cbxTranslationLanguageCode";
            this.cbxTranslationLanguageCode.Size = new System.Drawing.Size(60, 21);
            this.cbxTranslationLanguageCode.TabIndex = 1;
            // 
            // cboxTransferConfigAndAuthOnUpdate
            // 
            this.cboxTransferConfigAndAuthOnUpdate.AutoSize = true;
            this.cboxTransferConfigAndAuthOnUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxTransferConfigAndAuthOnUpdate.Location = new System.Drawing.Point(6, 69);
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
            this.txtOldConfigPath.Location = new System.Drawing.Point(89, 22);
            this.txtOldConfigPath.Name = "txtOldConfigPath";
            this.txtOldConfigPath.Size = new System.Drawing.Size(164, 20);
            this.txtOldConfigPath.TabIndex = 2;
            // 
            // lblOldConfigPath
            // 
            this.lblOldConfigPath.AutoSize = true;
            this.lblOldConfigPath.Location = new System.Drawing.Point(3, 25);
            this.lblOldConfigPath.Name = "lblOldConfigPath";
            this.lblOldConfigPath.Size = new System.Drawing.Size(80, 13);
            this.lblOldConfigPath.TabIndex = 6;
            this.lblOldConfigPath.Text = "Old Config path";
            // 
            // btnOldConfigPath
            // 
            this.btnOldConfigPath.Location = new System.Drawing.Point(6, 48);
            this.btnOldConfigPath.Name = "btnOldConfigPath";
            this.btnOldConfigPath.Size = new System.Drawing.Size(77, 23);
            this.btnOldConfigPath.TabIndex = 5;
            this.btnOldConfigPath.Text = "Browse";
            this.btnOldConfigPath.UseVisualStyleBackColor = true;
            this.btnOldConfigPath.Click += new System.EventHandler(this.btnOldConfigPath_Click);
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Location = new System.Drawing.Point(89, 48);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(164, 23);
            this.btnUpdateSettings.TabIndex = 7;
            this.btnUpdateSettings.Text = "Parse settings";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDelayBetweenPokemonCatch);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDelayBetweenPlayerActions);
            this.groupBox1.Controls.Add(this.cboxDisableHumanWalking);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbxUpgradePokemonMinimumStatsOperator);
            this.groupBox1.Controls.Add(this.txtUpgradePokemonIvMinimum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUpgradePokemonCpMinimum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxLevelUpByCPOrIv);
            this.groupBox1.Controls.Add(this.txtGetMinStarDustForLevelUp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmountOfTimesToUpgradeLoop);
            this.groupBox1.Controls.Add(this.cboxAutomaticallyLevelUpPokemon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 628);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Config";
            // 
            // cboxShowPokeballCountsBeforeRecycle
            // 
            this.cboxShowPokeballCountsBeforeRecycle.AutoSize = true;
            this.cboxShowPokeballCountsBeforeRecycle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxShowPokeballCountsBeforeRecycle.Location = new System.Drawing.Point(6, 141);
            this.cboxShowPokeballCountsBeforeRecycle.Name = "cboxShowPokeballCountsBeforeRecycle";
            this.cboxShowPokeballCountsBeforeRecycle.Size = new System.Drawing.Size(197, 17);
            this.cboxShowPokeballCountsBeforeRecycle.TabIndex = 10;
            this.cboxShowPokeballCountsBeforeRecycle.Text = "ShowPokeballCountsBeforeRecycle";
            this.cboxShowPokeballCountsBeforeRecycle.UseVisualStyleBackColor = true;
            // 
            // cboxAutomaticallyLevelUpPokemon
            // 
            this.cboxAutomaticallyLevelUpPokemon.AutoSize = true;
            this.cboxAutomaticallyLevelUpPokemon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxAutomaticallyLevelUpPokemon.Location = new System.Drawing.Point(6, 19);
            this.cboxAutomaticallyLevelUpPokemon.Name = "cboxAutomaticallyLevelUpPokemon";
            this.cboxAutomaticallyLevelUpPokemon.Size = new System.Drawing.Size(173, 17);
            this.cboxAutomaticallyLevelUpPokemon.TabIndex = 10;
            this.cboxAutomaticallyLevelUpPokemon.Text = "AutomaticallyLevelUpPokemon";
            this.cboxAutomaticallyLevelUpPokemon.UseVisualStyleBackColor = true;
            // 
            // txtAmountOfTimesToUpgradeLoop
            // 
            this.txtAmountOfTimesToUpgradeLoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOfTimesToUpgradeLoop.Location = new System.Drawing.Point(169, 42);
            this.txtAmountOfTimesToUpgradeLoop.Name = "txtAmountOfTimesToUpgradeLoop";
            this.txtAmountOfTimesToUpgradeLoop.Size = new System.Drawing.Size(45, 20);
            this.txtAmountOfTimesToUpgradeLoop.TabIndex = 12;
            this.txtAmountOfTimesToUpgradeLoop.Text = "0";
            this.txtAmountOfTimesToUpgradeLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountOfTimesToUpgradeLoop.TextChanged += new System.EventHandler(this.txtAmountOfTimesToUpgradeLoop_TextChanged);
            this.txtAmountOfTimesToUpgradeLoop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "AmountOfTimesToUpgradeLoop";
            // 
            // txtGetMinStarDustForLevelUp
            // 
            this.txtGetMinStarDustForLevelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetMinStarDustForLevelUp.Location = new System.Drawing.Point(146, 68);
            this.txtGetMinStarDustForLevelUp.Name = "txtGetMinStarDustForLevelUp";
            this.txtGetMinStarDustForLevelUp.Size = new System.Drawing.Size(68, 20);
            this.txtGetMinStarDustForLevelUp.TabIndex = 14;
            this.txtGetMinStarDustForLevelUp.Text = "0";
            this.txtGetMinStarDustForLevelUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGetMinStarDustForLevelUp.TextChanged += new System.EventHandler(this.txtGetMinStarDustForLevelUp_TextChanged);
            this.txtGetMinStarDustForLevelUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "GetMinStarDustForLevelUp";
            // 
            // cbxLevelUpByCPOrIv
            // 
            this.cbxLevelUpByCPOrIv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevelUpByCPOrIv.FormattingEnabled = true;
            this.cbxLevelUpByCPOrIv.Location = new System.Drawing.Point(102, 94);
            this.cbxLevelUpByCPOrIv.Name = "cbxLevelUpByCPOrIv";
            this.cbxLevelUpByCPOrIv.Size = new System.Drawing.Size(38, 21);
            this.cbxLevelUpByCPOrIv.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "LevelUpByCPOrIv";
            // 
            // txtUpgradePokemonCpMinimum
            // 
            this.txtUpgradePokemonCpMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpgradePokemonCpMinimum.Location = new System.Drawing.Point(156, 121);
            this.txtUpgradePokemonCpMinimum.Name = "txtUpgradePokemonCpMinimum";
            this.txtUpgradePokemonCpMinimum.Size = new System.Drawing.Size(80, 20);
            this.txtUpgradePokemonCpMinimum.TabIndex = 16;
            this.txtUpgradePokemonCpMinimum.Text = "0";
            this.txtUpgradePokemonCpMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUpgradePokemonCpMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "UpgradePokemonCpMinimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "UpgradePokemonIvMinimum";
            // 
            // txtUpgradePokemonIvMinimum
            // 
            this.txtUpgradePokemonIvMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpgradePokemonIvMinimum.Location = new System.Drawing.Point(152, 147);
            this.txtUpgradePokemonIvMinimum.Name = "txtUpgradePokemonIvMinimum";
            this.txtUpgradePokemonIvMinimum.Size = new System.Drawing.Size(51, 20);
            this.txtUpgradePokemonIvMinimum.TabIndex = 19;
            this.txtUpgradePokemonIvMinimum.Text = "0";
            this.txtUpgradePokemonIvMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUpgradePokemonIvMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // cbxUpgradePokemonMinimumStatsOperator
            // 
            this.cbxUpgradePokemonMinimumStatsOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpgradePokemonMinimumStatsOperator.FormattingEnabled = true;
            this.cbxUpgradePokemonMinimumStatsOperator.Location = new System.Drawing.Point(208, 173);
            this.cbxUpgradePokemonMinimumStatsOperator.Name = "cbxUpgradePokemonMinimumStatsOperator";
            this.cbxUpgradePokemonMinimumStatsOperator.Size = new System.Drawing.Size(45, 21);
            this.cbxUpgradePokemonMinimumStatsOperator.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "UpgradePokemonMinimumStatsOperator";
            // 
            // cboxDisableHumanWalking
            // 
            this.cboxDisableHumanWalking.AutoSize = true;
            this.cboxDisableHumanWalking.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxDisableHumanWalking.Location = new System.Drawing.Point(6, 200);
            this.cboxDisableHumanWalking.Name = "cboxDisableHumanWalking";
            this.cboxDisableHumanWalking.Size = new System.Drawing.Size(134, 17);
            this.cboxDisableHumanWalking.TabIndex = 21;
            this.cboxDisableHumanWalking.Text = "DisableHumanWalking";
            this.cboxDisableHumanWalking.UseVisualStyleBackColor = true;
            // 
            // cboxDumpPokemonStats
            // 
            this.cboxDumpPokemonStats.AutoSize = true;
            this.cboxDumpPokemonStats.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxDumpPokemonStats.Location = new System.Drawing.Point(6, 164);
            this.cboxDumpPokemonStats.Name = "cboxDumpPokemonStats";
            this.cboxDumpPokemonStats.Size = new System.Drawing.Size(123, 17);
            this.cboxDumpPokemonStats.TabIndex = 22;
            this.cboxDumpPokemonStats.Text = "DumpPokemonStats";
            this.cboxDumpPokemonStats.UseVisualStyleBackColor = true;
            // 
            // grboxLocation
            // 
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
            this.grboxLocation.Size = new System.Drawing.Size(512, 160);
            this.grboxLocation.TabIndex = 10;
            this.grboxLocation.TabStop = false;
            this.grboxLocation.Text = "Location Settings";
            // 
            // txtDefaultAltitude
            // 
            this.txtDefaultAltitude.Location = new System.Drawing.Point(180, 22);
            this.txtDefaultAltitude.Name = "txtDefaultAltitude";
            this.txtDefaultAltitude.Size = new System.Drawing.Size(326, 20);
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
            // txtDefaultLatitude
            // 
            this.txtDefaultLatitude.Location = new System.Drawing.Point(180, 48);
            this.txtDefaultLatitude.Name = "txtDefaultLatitude";
            this.txtDefaultLatitude.Size = new System.Drawing.Size(326, 20);
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
            // txtDefaultLongitude
            // 
            this.txtDefaultLongitude.Location = new System.Drawing.Point(180, 74);
            this.txtDefaultLongitude.Name = "txtDefaultLongitude";
            this.txtDefaultLongitude.Size = new System.Drawing.Size(326, 20);
            this.txtDefaultLongitude.TabIndex = 12;
            this.txtDefaultLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "WalkingSpeedInKilometerPerHour";
            // 
            // txtWalkingSpeedInKilometerPerHour
            // 
            this.txtWalkingSpeedInKilometerPerHour.Location = new System.Drawing.Point(180, 100);
            this.txtWalkingSpeedInKilometerPerHour.Name = "txtWalkingSpeedInKilometerPerHour";
            this.txtWalkingSpeedInKilometerPerHour.Size = new System.Drawing.Size(326, 20);
            this.txtWalkingSpeedInKilometerPerHour.TabIndex = 12;
            this.txtWalkingSpeedInKilometerPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWalkingSpeedInKilometerPerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpgradePokemonCpMinimum_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "MaxSpawnLocationOffset";
            // 
            // txtMaxSpawnLocationOffset
            // 
            this.txtMaxSpawnLocationOffset.Location = new System.Drawing.Point(180, 126);
            this.txtMaxSpawnLocationOffset.Name = "txtMaxSpawnLocationOffset";
            this.txtMaxSpawnLocationOffset.Size = new System.Drawing.Size(326, 20);
            this.txtMaxSpawnLocationOffset.TabIndex = 12;
            this.txtMaxSpawnLocationOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxSpawnLocationOffset.TextChanged += new System.EventHandler(this.txtMaxSpawnLocationOffset_TextChanged);
            this.txtMaxSpawnLocationOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // txtDelayBetweenPlayerActions
            // 
            this.txtDelayBetweenPlayerActions.Location = new System.Drawing.Point(152, 223);
            this.txtDelayBetweenPlayerActions.Name = "txtDelayBetweenPlayerActions";
            this.txtDelayBetweenPlayerActions.Size = new System.Drawing.Size(101, 20);
            this.txtDelayBetweenPlayerActions.TabIndex = 14;
            this.txtDelayBetweenPlayerActions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayBetweenPlayerActions.TextChanged += new System.EventHandler(this.txtDelayBetweenPlayerActions_TextChanged);
            this.txtDelayBetweenPlayerActions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "DelayBetweenPlayerActions";
            // 
            // txtDelayBetweenPokemonCatch
            // 
            this.txtDelayBetweenPokemonCatch.Location = new System.Drawing.Point(152, 249);
            this.txtDelayBetweenPokemonCatch.Name = "txtDelayBetweenPokemonCatch";
            this.txtDelayBetweenPokemonCatch.Size = new System.Drawing.Size(101, 20);
            this.txtDelayBetweenPokemonCatch.TabIndex = 22;
            this.txtDelayBetweenPokemonCatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelayBetweenPokemonCatch.TextChanged += new System.EventHandler(this.txtDelayBetweenPokemonCatch_TextChanged);
            this.txtDelayBetweenPokemonCatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountOfPokemonToDisplayOnStart_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "DelayBetweenPokemonCatch";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 811);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.grboxGeneralConfig.ResumeLayout(false);
            this.grboxGeneralConfig.PerformLayout();
            this.grboxOldSetting.ResumeLayout(false);
            this.grboxOldSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grboxLocation.ResumeLayout(false);
            this.grboxLocation.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGetMinStarDustForLevelUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLevelUpByCPOrIv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpgradePokemonCpMinimum;
        private System.Windows.Forms.TextBox txtUpgradePokemonIvMinimum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxUpgradePokemonMinimumStatsOperator;
        private System.Windows.Forms.Label label8;
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
    }
}

