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
            this.cbxTranslationLanguageCode = new System.Windows.Forms.ComboBox();
            this.cboxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.cboxTransferConfigAndAuthOnUpdate = new System.Windows.Forms.CheckBox();
            this.txtOldConfigPath = new System.Windows.Forms.TextBox();
            this.btnOldConfigPath = new System.Windows.Forms.Button();
            this.lblOldConfigPath = new System.Windows.Forms.Label();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.grboxOldSetting = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grboxOldSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TranslationLanguageCode";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.cboxTransferConfigAndAuthOnUpdate);
            this.panel1.Controls.Add(this.cbxTranslationLanguageCode);
            this.panel1.Controls.Add(this.grboxOldSetting);
            this.panel1.Controls.Add(this.cboxAutoUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 620);
            this.panel1.TabIndex = 1;
            // 
            // cbxTranslationLanguageCode
            // 
            this.cbxTranslationLanguageCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTranslationLanguageCode.BackColor = System.Drawing.Color.White;
            this.cbxTranslationLanguageCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTranslationLanguageCode.DropDownWidth = 5;
            this.cbxTranslationLanguageCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cbxTranslationLanguageCode.Location = new System.Drawing.Point(430, 381);
            this.cbxTranslationLanguageCode.Name = "cbxTranslationLanguageCode";
            this.cbxTranslationLanguageCode.Size = new System.Drawing.Size(72, 21);
            this.cbxTranslationLanguageCode.TabIndex = 1;
            // 
            // cboxAutoUpdate
            // 
            this.cboxAutoUpdate.AutoSize = true;
            this.cboxAutoUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxAutoUpdate.Location = new System.Drawing.Point(203, 383);
            this.cboxAutoUpdate.Name = "cboxAutoUpdate";
            this.cboxAutoUpdate.Size = new System.Drawing.Size(83, 17);
            this.cboxAutoUpdate.TabIndex = 3;
            this.cboxAutoUpdate.Text = "AutoUpdate";
            this.cboxAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // cboxTransferConfigAndAuthOnUpdate
            // 
            this.cboxTransferConfigAndAuthOnUpdate.AutoSize = true;
            this.cboxTransferConfigAndAuthOnUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxTransferConfigAndAuthOnUpdate.Location = new System.Drawing.Point(12, 383);
            this.cboxTransferConfigAndAuthOnUpdate.Name = "cboxTransferConfigAndAuthOnUpdate";
            this.cboxTransferConfigAndAuthOnUpdate.Size = new System.Drawing.Size(185, 17);
            this.cboxTransferConfigAndAuthOnUpdate.TabIndex = 4;
            this.cboxTransferConfigAndAuthOnUpdate.Text = "TransferConfigAndAuthOnUpdate";
            this.cboxTransferConfigAndAuthOnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtOldConfigPath
            // 
            this.txtOldConfigPath.Location = new System.Drawing.Point(111, 22);
            this.txtOldConfigPath.Name = "txtOldConfigPath";
            this.txtOldConfigPath.Size = new System.Drawing.Size(237, 20);
            this.txtOldConfigPath.TabIndex = 2;
            // 
            // btnOldConfigPath
            // 
            this.btnOldConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOldConfigPath.Location = new System.Drawing.Point(354, 20);
            this.btnOldConfigPath.Name = "btnOldConfigPath";
            this.btnOldConfigPath.Size = new System.Drawing.Size(51, 23);
            this.btnOldConfigPath.TabIndex = 5;
            this.btnOldConfigPath.Text = "Browse";
            this.btnOldConfigPath.UseVisualStyleBackColor = true;
            this.btnOldConfigPath.Click += new System.EventHandler(this.btnOldConfigPath_Click);
            // 
            // lblOldConfigPath
            // 
            this.lblOldConfigPath.AutoSize = true;
            this.lblOldConfigPath.Location = new System.Drawing.Point(6, 25);
            this.lblOldConfigPath.Name = "lblOldConfigPath";
            this.lblOldConfigPath.Size = new System.Drawing.Size(99, 13);
            this.lblOldConfigPath.TabIndex = 6;
            this.lblOldConfigPath.Text = "Old Config directory";
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSettings.Location = new System.Drawing.Point(411, 20);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateSettings.TabIndex = 7;
            this.btnUpdateSettings.Text = "Parse settings";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // grboxOldSetting
            // 
            this.grboxOldSetting.Controls.Add(this.btnUpdateSettings);
            this.grboxOldSetting.Controls.Add(this.txtOldConfigPath);
            this.grboxOldSetting.Controls.Add(this.lblOldConfigPath);
            this.grboxOldSetting.Controls.Add(this.btnOldConfigPath);
            this.grboxOldSetting.Location = new System.Drawing.Point(12, 12);
            this.grboxOldSetting.Name = "grboxOldSetting";
            this.grboxOldSetting.Size = new System.Drawing.Size(502, 60);
            this.grboxOldSetting.TabIndex = 8;
            this.grboxOldSetting.TabStop = false;
            this.grboxOldSetting.Text = "Old Config";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 620);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grboxOldSetting.ResumeLayout(false);
            this.grboxOldSetting.PerformLayout();
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
    }
}

