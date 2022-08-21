namespace Anti_AFK
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pMain = new MetroFramework.Controls.MetroPanel();
            this.btnCostumKeyInfo = new MetroFramework.Controls.MetroButton();
            this.txtKeypressCostum = new MetroFramework.Controls.MetroTextBox();
            this.lblKeypressIndividuell = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbKeypresses = new MetroFramework.Controls.MetroComboBox();
            this.lblProcess = new MetroFramework.Controls.MetroLabel();
            this.cbApps = new MetroFramework.Controls.MetroComboBox();
            this.lblNextKeyVal = new MetroFramework.Controls.MetroLabel();
            this.lblNextKey = new MetroFramework.Controls.MetroLabel();
            this.lblInterval = new MetroFramework.Controls.MetroLabel();
            this.ckbIntervall = new MetroFramework.Controls.MetroComboBox();
            this.lblLastKeyPressVal = new MetroFramework.Controls.MetroLabel();
            this.lblLastKeyPress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblState = new MetroFramework.Controls.MetroLabel();
            this.lblStateVal = new MetroFramework.Controls.MetroLabel();
            this.lblKeyActivate = new MetroFramework.Controls.MetroLabel();
            this.txtCostumIntervall = new MetroFramework.Controls.MetroTextBox();
            this.lblCostumInterval = new MetroFramework.Controls.MetroLabel();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.txtCostumIntervall);
            this.pMain.Controls.Add(this.lblCostumInterval);
            this.pMain.Controls.Add(this.btnCostumKeyInfo);
            this.pMain.Controls.Add(this.txtKeypressCostum);
            this.pMain.Controls.Add(this.lblKeypressIndividuell);
            this.pMain.Controls.Add(this.metroLabel2);
            this.pMain.Controls.Add(this.cbKeypresses);
            this.pMain.Controls.Add(this.lblProcess);
            this.pMain.Controls.Add(this.cbApps);
            this.pMain.Controls.Add(this.lblNextKeyVal);
            this.pMain.Controls.Add(this.lblNextKey);
            this.pMain.Controls.Add(this.lblInterval);
            this.pMain.Controls.Add(this.ckbIntervall);
            this.pMain.Controls.Add(this.lblLastKeyPressVal);
            this.pMain.Controls.Add(this.lblLastKeyPress);
            this.pMain.Controls.Add(this.metroLabel1);
            this.pMain.Controls.Add(this.lblState);
            this.pMain.Controls.Add(this.lblStateVal);
            this.pMain.Controls.Add(this.lblKeyActivate);
            this.pMain.HorizontalScrollbarBarColor = true;
            this.pMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pMain.HorizontalScrollbarSize = 10;
            this.pMain.Location = new System.Drawing.Point(23, 63);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(246, 420);
            this.pMain.TabIndex = 4;
            this.pMain.VerticalScrollbarBarColor = true;
            this.pMain.VerticalScrollbarHighlightOnWheel = false;
            this.pMain.VerticalScrollbarSize = 10;
            // 
            // btnCostumKeyInfo
            // 
            this.btnCostumKeyInfo.Location = new System.Drawing.Point(4, 384);
            this.btnCostumKeyInfo.Name = "btnCostumKeyInfo";
            this.btnCostumKeyInfo.Size = new System.Drawing.Size(234, 23);
            this.btnCostumKeyInfo.TabIndex = 16;
            this.btnCostumKeyInfo.Text = "Info über Indivduelle Taste";
            this.btnCostumKeyInfo.UseSelectable = true;
            this.btnCostumKeyInfo.Click += new System.EventHandler(this.btnCostumKeyInfo_Click);
            // 
            // txtKeypressCostum
            // 
            // 
            // 
            // 
            this.txtKeypressCostum.CustomButton.Image = null;
            this.txtKeypressCostum.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtKeypressCostum.CustomButton.Name = "";
            this.txtKeypressCostum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKeypressCostum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeypressCostum.CustomButton.TabIndex = 1;
            this.txtKeypressCostum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeypressCostum.CustomButton.UseSelectable = true;
            this.txtKeypressCostum.CustomButton.Visible = false;
            this.txtKeypressCostum.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Anti_AFK.Properties.Settings.Default, "CostumKeypress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtKeypressCostum.Lines = new string[0];
            this.txtKeypressCostum.Location = new System.Drawing.Point(4, 355);
            this.txtKeypressCostum.MaxLength = 32767;
            this.txtKeypressCostum.Name = "txtKeypressCostum";
            this.txtKeypressCostum.PasswordChar = '\0';
            this.txtKeypressCostum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeypressCostum.SelectedText = "";
            this.txtKeypressCostum.SelectionLength = 0;
            this.txtKeypressCostum.SelectionStart = 0;
            this.txtKeypressCostum.ShortcutsEnabled = true;
            this.txtKeypressCostum.Size = new System.Drawing.Size(237, 23);
            this.txtKeypressCostum.TabIndex = 15;
            this.txtKeypressCostum.Text = global::Anti_AFK.Properties.Settings.Default.CostumKeypress;
            this.txtKeypressCostum.UseSelectable = true;
            this.txtKeypressCostum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeypressCostum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKeypressCostum.TextChanged += new System.EventHandler(this.SettingsChange);
            // 
            // lblKeypressIndividuell
            // 
            this.lblKeypressIndividuell.AutoSize = true;
            this.lblKeypressIndividuell.Location = new System.Drawing.Point(2, 333);
            this.lblKeypressIndividuell.Name = "lblKeypressIndividuell";
            this.lblKeypressIndividuell.Size = new System.Drawing.Size(106, 19);
            this.lblKeypressIndividuell.TabIndex = 14;
            this.lblKeypressIndividuell.Text = "Individuelle Taste";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 272);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Tastendrücke:";
            // 
            // cbKeypresses
            // 
            this.cbKeypresses.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Anti_AFK.Properties.Settings.Default, "KeyPress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbKeypresses.FormattingEnabled = true;
            this.cbKeypresses.ItemHeight = 23;
            this.cbKeypresses.Items.AddRange(new object[] {
            "W A S D",
            "1 2 3 4",
            "Marvin Mode"});
            this.cbKeypresses.Location = new System.Drawing.Point(4, 294);
            this.cbKeypresses.Name = "cbKeypresses";
            this.cbKeypresses.Size = new System.Drawing.Size(238, 29);
            this.cbKeypresses.TabIndex = 0;
            this.cbKeypresses.Text = global::Anti_AFK.Properties.Settings.Default.KeyPress;
            this.cbKeypresses.UseSelectable = true;
            this.cbKeypresses.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(3, 102);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(56, 19);
            this.lblProcess.TabIndex = 11;
            this.lblProcess.Text = "Prozess:";
            // 
            // cbApps
            // 
            this.cbApps.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Anti_AFK.Properties.Settings.Default, "LastProcess", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbApps.FormattingEnabled = true;
            this.cbApps.ItemHeight = 23;
            this.cbApps.Location = new System.Drawing.Point(3, 124);
            this.cbApps.Name = "cbApps";
            this.cbApps.Size = new System.Drawing.Size(238, 29);
            this.cbApps.TabIndex = 10;
            this.cbApps.Text = global::Anti_AFK.Properties.Settings.Default.LastProcess;
            this.cbApps.UseSelectable = true;
            this.cbApps.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // lblNextKeyVal
            // 
            this.lblNextKeyVal.AutoSize = true;
            this.lblNextKeyVal.Location = new System.Drawing.Point(123, 77);
            this.lblNextKeyVal.Name = "lblNextKeyVal";
            this.lblNextKeyVal.Size = new System.Drawing.Size(40, 19);
            this.lblNextKeyVal.TabIndex = 9;
            this.lblNextKeyVal.Text = "00:00";
            // 
            // lblNextKey
            // 
            this.lblNextKey.AutoSize = true;
            this.lblNextKey.Location = new System.Drawing.Point(3, 76);
            this.lblNextKey.Name = "lblNextKey";
            this.lblNextKey.Size = new System.Drawing.Size(123, 19);
            this.lblNextKey.TabIndex = 8;
            this.lblNextKey.Text = "Nächste Bewegung:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(4, 158);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(55, 19);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval:";
            // 
            // ckbIntervall
            // 
            this.ckbIntervall.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Anti_AFK.Properties.Settings.Default, "LastInvervall", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ckbIntervall.FormattingEnabled = true;
            this.ckbIntervall.ItemHeight = 23;
            this.ckbIntervall.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20"});
            this.ckbIntervall.Location = new System.Drawing.Point(4, 180);
            this.ckbIntervall.Name = "ckbIntervall";
            this.ckbIntervall.Size = new System.Drawing.Size(238, 29);
            this.ckbIntervall.TabIndex = 6;
            this.ckbIntervall.Text = global::Anti_AFK.Properties.Settings.Default.LastInvervall;
            this.ckbIntervall.UseSelectable = true;
            this.ckbIntervall.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // lblLastKeyPressVal
            // 
            this.lblLastKeyPressVal.AutoSize = true;
            this.lblLastKeyPressVal.Location = new System.Drawing.Point(111, 57);
            this.lblLastKeyPressVal.Name = "lblLastKeyPressVal";
            this.lblLastKeyPressVal.Size = new System.Drawing.Size(40, 19);
            this.lblLastKeyPressVal.TabIndex = 5;
            this.lblLastKeyPressVal.Text = "00:00";
            // 
            // lblLastKeyPress
            // 
            this.lblLastKeyPress.AutoSize = true;
            this.lblLastKeyPress.Location = new System.Drawing.Point(3, 57);
            this.lblLastKeyPress.Name = "lblLastKeyPress";
            this.lblLastKeyPress.Size = new System.Drawing.Size(111, 19);
            this.lblLastKeyPress.TabIndex = 4;
            this.lblLastKeyPress.Text = "Letzte Bewegung:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(255, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "_________________________________________";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(3, 23);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 19);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Status:";
            // 
            // lblStateVal
            // 
            this.lblStateVal.AutoSize = true;
            this.lblStateVal.ForeColor = System.Drawing.Color.Red;
            this.lblStateVal.Location = new System.Drawing.Point(52, 23);
            this.lblStateVal.Name = "lblStateVal";
            this.lblStateVal.Size = new System.Drawing.Size(30, 19);
            this.lblStateVal.TabIndex = 2;
            this.lblStateVal.Text = "Aus";
            // 
            // lblKeyActivate
            // 
            this.lblKeyActivate.AutoSize = true;
            this.lblKeyActivate.Location = new System.Drawing.Point(3, 4);
            this.lblKeyActivate.Name = "lblKeyActivate";
            this.lblKeyActivate.Size = new System.Drawing.Size(169, 19);
            this.lblKeyActivate.TabIndex = 0;
            this.lblKeyActivate.Text = "Aktivieren / Deaktivieren: F1";
            // 
            // txtCostumIntervall
            // 
            // 
            // 
            // 
            this.txtCostumIntervall.CustomButton.Image = null;
            this.txtCostumIntervall.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtCostumIntervall.CustomButton.Name = "";
            this.txtCostumIntervall.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCostumIntervall.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCostumIntervall.CustomButton.TabIndex = 1;
            this.txtCostumIntervall.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCostumIntervall.CustomButton.UseSelectable = true;
            this.txtCostumIntervall.CustomButton.Visible = false;
            this.txtCostumIntervall.Lines = new string[0];
            this.txtCostumIntervall.Location = new System.Drawing.Point(4, 238);
            this.txtCostumIntervall.MaxLength = 32767;
            this.txtCostumIntervall.Name = "txtCostumIntervall";
            this.txtCostumIntervall.PasswordChar = '\0';
            this.txtCostumIntervall.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCostumIntervall.SelectedText = "";
            this.txtCostumIntervall.SelectionLength = 0;
            this.txtCostumIntervall.SelectionStart = 0;
            this.txtCostumIntervall.ShortcutsEnabled = true;
            this.txtCostumIntervall.Size = new System.Drawing.Size(238, 23);
            this.txtCostumIntervall.TabIndex = 18;
            this.txtCostumIntervall.UseSelectable = true;
            this.txtCostumIntervall.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCostumIntervall.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCostumInterval
            // 
            this.lblCostumInterval.AutoSize = true;
            this.lblCostumInterval.Location = new System.Drawing.Point(2, 216);
            this.lblCostumInterval.Name = "lblCostumInterval";
            this.lblCostumInterval.Size = new System.Drawing.Size(195, 19);
            this.lblCostumInterval.TabIndex = 17;
            this.lblCostumInterval.Text = "Individueller Intervall (sekunden)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 495);
            this.Controls.Add(this.pMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Anti AFK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pMain;
        private MetroFramework.Controls.MetroButton btnCostumKeyInfo;
        private MetroFramework.Controls.MetroTextBox txtKeypressCostum;
        private MetroFramework.Controls.MetroLabel lblKeypressIndividuell;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbKeypresses;
        private MetroFramework.Controls.MetroLabel lblProcess;
        private MetroFramework.Controls.MetroComboBox cbApps;
        private MetroFramework.Controls.MetroLabel lblNextKeyVal;
        private MetroFramework.Controls.MetroLabel lblNextKey;
        private MetroFramework.Controls.MetroLabel lblInterval;
        private MetroFramework.Controls.MetroComboBox ckbIntervall;
        private MetroFramework.Controls.MetroLabel lblLastKeyPressVal;
        private MetroFramework.Controls.MetroLabel lblLastKeyPress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblState;
        private MetroFramework.Controls.MetroLabel lblStateVal;
        private MetroFramework.Controls.MetroLabel lblKeyActivate;
        private MetroFramework.Controls.MetroTextBox txtCostumIntervall;
        private MetroFramework.Controls.MetroLabel lblCostumInterval;
    }
}

