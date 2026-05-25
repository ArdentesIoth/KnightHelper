namespace KnightHelper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PanelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogs = new Guna.UI2.WinForms.Guna2Button();
            this.btnMain = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.nudMPDelay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblMPDelay = new System.Windows.Forms.Label();
            this.nudHPDelay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblHPDelay = new System.Windows.Forms.Label();
            this.cmbMPKey = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMPKey = new System.Windows.Forms.Label();
            this.cmbHPKey = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHPKey = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lblMPValue = new System.Windows.Forms.Label();
            this.trackMP = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblAutoMP = new System.Windows.Forms.Label();
            this.toggleAutoMP = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblHPValue = new System.Windows.Forms.Label();
            this.trackHP = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblAutoHP = new System.Windows.Forms.Label();
            this.toggleAutoHP = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.chkOnlyWhenActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnRefreshWindows = new Guna.UI2.WinForms.Guna2Button();
            this.cmbWindows = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSelectWindow = new System.Windows.Forms.Label();
            this.guna2PanelTop.SuspendLayout();
            this.guna2PanelLeft.SuspendLayout();
            this.guna2PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMPDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPDelay)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PanelTop
            // 
            this.guna2PanelTop.BackColor = System.Drawing.Color.FromArgb(22, 22, 30);
            this.guna2PanelTop.Controls.Add(this.lblTitle);
            this.guna2PanelTop.Controls.Add(this.btnClose);
            this.guna2PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTop.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTop.Size = new System.Drawing.Size(850, 40);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Text = "KnightHelper • TheHitKO";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(22, 22, 30);
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(810, 5);
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2PanelLeft
            // 
            this.guna2PanelLeft.BackColor = System.Drawing.Color.FromArgb(28, 28, 38);
            this.guna2PanelLeft.Controls.Add(this.btnSettings);
            this.guna2PanelLeft.Controls.Add(this.btnLogs);
            this.guna2PanelLeft.Controls.Add(this.btnMain);
            this.guna2PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PanelLeft.Size = new System.Drawing.Size(180, 460);
            // 
            // btnMain
            // 
            this.btnMain.BorderRadius = 6;
            this.btnMain.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMain.Checked = true;
            this.btnMain.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Location = new System.Drawing.Point(10, 20);
            this.btnMain.Size = new System.Drawing.Size(160, 40);
            this.btnMain.Text = "Potion";
            this.btnMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BorderRadius = 6;
            this.btnLogs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogs.FillColor = System.Drawing.Color.Transparent;
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogs.ForeColor = System.Drawing.Color.Silver;
            this.btnLogs.Location = new System.Drawing.Point(10, 70);
            this.btnLogs.Size = new System.Drawing.Size(160, 40);
            this.btnLogs.Text = "Loglar";
            this.btnLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderRadius = 6;
            this.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(10, 120);
            this.btnSettings.Size = new System.Drawing.Size(160, 40);
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // guna2PanelMain
            // 
            this.guna2PanelMain.BackColor = System.Drawing.Color.FromArgb(34, 34, 46);
            this.guna2PanelMain.Controls.Add(this.nudMPDelay);
            this.guna2PanelMain.Controls.Add(this.lblMPDelay);
            this.guna2PanelMain.Controls.Add(this.nudHPDelay);
            this.guna2PanelMain.Controls.Add(this.lblHPDelay);
            this.guna2PanelMain.Controls.Add(this.cmbMPKey);
            this.guna2PanelMain.Controls.Add(this.lblMPKey);
            this.guna2PanelMain.Controls.Add(this.cmbHPKey);
            this.guna2PanelMain.Controls.Add(this.lblHPKey);
            this.guna2PanelMain.Controls.Add(this.lblStatus);
            this.guna2PanelMain.Controls.Add(this.btnStop);
            this.guna2PanelMain.Controls.Add(this.btnStart);
            this.guna2PanelMain.Controls.Add(this.lblMPValue);
            this.guna2PanelMain.Controls.Add(this.trackMP);
            this.guna2PanelMain.Controls.Add(this.lblAutoMP);
            this.guna2PanelMain.Controls.Add(this.toggleAutoMP);
            this.guna2PanelMain.Controls.Add(this.lblHPValue);
            this.guna2PanelMain.Controls.Add(this.trackHP);
            this.guna2PanelMain.Controls.Add(this.lblAutoHP);
            this.guna2PanelMain.Controls.Add(this.toggleAutoHP);
            this.guna2PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelMain.Location = new System.Drawing.Point(180, 40);
            this.guna2PanelMain.Size = new System.Drawing.Size(670, 460);
            // 
            // toggleAutoHP
            // 
            this.toggleAutoHP.CheckedState.FillColor = System.Drawing.Color.FromArgb(0, 192, 0);
            this.toggleAutoHP.Location = new System.Drawing.Point(30, 30);
            this.toggleAutoHP.Size = new System.Drawing.Size(50, 25);
            // 
            // lblAutoHP
            // 
            this.lblAutoHP.AutoSize = true;
            this.lblAutoHP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAutoHP.ForeColor = System.Drawing.Color.White;
            this.lblAutoHP.Location = new System.Drawing.Point(90, 34);
            this.lblAutoHP.Text = "Auto HP Pot";
            // 
            // trackHP
            // 
            this.trackHP.Location = new System.Drawing.Point(30, 65);
            this.trackHP.Size = new System.Drawing.Size(200, 23);
            this.trackHP.ThumbColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.trackHP.Value = 45;
            // 
            // lblHPValue
            // 
            this.lblHPValue.AutoSize = true;
            this.lblHPValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHPValue.ForeColor = System.Drawing.Color.Silver;
            this.lblHPValue.Location = new System.Drawing.Point(240, 68);
            this.lblHPValue.Text = "%45";
            // 
            // lblHPKey
            // 
            this.lblHPKey.AutoSize = true;
            this.lblHPKey.ForeColor = System.Drawing.Color.Silver;
            this.lblHPKey.Location = new System.Drawing.Point(280, 68);
            this.lblHPKey.Text = "Tuş:";
            // 
            // cmbHPKey
            // 
            this.cmbHPKey.BackColor = System.Drawing.Color.Transparent;
            this.cmbHPKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHPKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHPKey.FillColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.cmbHPKey.FocusedColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.cmbHPKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHPKey.ForeColor = System.Drawing.Color.White;
            this.cmbHPKey.ItemHeight = 24;
            this.cmbHPKey.Location = new System.Drawing.Point(315, 62);
            this.cmbHPKey.Size = new System.Drawing.Size(60, 30);
            // 
            // lblHPDelay
            // 
            this.lblHPDelay.AutoSize = true;
            this.lblHPDelay.ForeColor = System.Drawing.Color.Silver;
            this.lblHPDelay.Location = new System.Drawing.Point(390, 68);
            this.lblHPDelay.Text = "ms:";
            // 
            // nudHPDelay
            // 
            this.nudHPDelay.BackColor = System.Drawing.Color.Transparent;
            this.nudHPDelay.FillColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.nudHPDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudHPDelay.ForeColor = System.Drawing.Color.White;
            this.nudHPDelay.Location = new System.Drawing.Point(420, 62);
            this.nudHPDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudHPDelay.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudHPDelay.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            this.nudHPDelay.Size = new System.Drawing.Size(80, 30);
            // 
            // toggleAutoMP
            // 
            this.toggleAutoMP.CheckedState.FillColor = System.Drawing.Color.FromArgb(0, 192, 192);
            this.toggleAutoMP.Location = new System.Drawing.Point(30, 120);
            this.toggleAutoMP.Size = new System.Drawing.Size(50, 25);
            // 
            // lblAutoMP
            // 
            this.lblAutoMP.AutoSize = true;
            this.lblAutoMP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAutoMP.ForeColor = System.Drawing.Color.White;
            this.lblAutoMP.Location = new System.Drawing.Point(90, 124);
            this.lblAutoMP.Text = "Auto MP Pot";
            // 
            // trackMP
            // 
            this.trackMP.Location = new System.Drawing.Point(30, 155);
            this.trackMP.Size = new System.Drawing.Size(200, 23);
            this.trackMP.ThumbColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.trackMP.Value = 60;
            // 
            // lblMPValue
            // 
            this.lblMPValue.AutoSize = true;
            this.lblMPValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMPValue.ForeColor = System.Drawing.Color.Silver;
            this.lblMPValue.Location = new System.Drawing.Point(240, 158);
            this.lblMPValue.Text = "%60";
            // 
            // lblMPKey
            // 
            this.lblMPKey.AutoSize = true;
            this.lblMPKey.ForeColor = System.Drawing.Color.Silver;
            this.lblMPKey.Location = new System.Drawing.Point(280, 158);
            this.lblMPKey.Text = "Tuş:";
            // 
            // cmbMPKey
            // 
            this.cmbMPKey.BackColor = System.Drawing.Color.Transparent;
            this.cmbMPKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMPKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMPKey.FillColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.cmbMPKey.FocusedColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.cmbMPKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMPKey.ForeColor = System.Drawing.Color.White;
            this.cmbMPKey.ItemHeight = 24;
            this.cmbMPKey.Location = new System.Drawing.Point(315, 152);
            this.cmbMPKey.Size = new System.Drawing.Size(60, 30);
            // 
            // lblMPDelay
            // 
            this.lblMPDelay.AutoSize = true;
            this.lblMPDelay.ForeColor = System.Drawing.Color.Silver;
            this.lblMPDelay.Location = new System.Drawing.Point(390, 158);
            this.lblMPDelay.Text = "ms:";
            // 
            // nudMPDelay
            // 
            this.nudMPDelay.BackColor = System.Drawing.Color.Transparent;
            this.nudMPDelay.FillColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.nudMPDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudMPDelay.ForeColor = System.Drawing.Color.White;
            this.nudMPDelay.Location = new System.Drawing.Point(420, 152);
            this.nudMPDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudMPDelay.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudMPDelay.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            this.nudMPDelay.Size = new System.Drawing.Size(80, 30);
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 8;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(30, 220);
            this.btnStart.Size = new System.Drawing.Size(140, 45);
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 8;
            this.btnStop.Enabled = false;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(185, 220);
            this.btnStop.Size = new System.Drawing.Size(140, 45);
            this.btnStop.Text = "DURDUR";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Orange;
            this.lblStatus.Location = new System.Drawing.Point(30, 290);
            this.lblStatus.Text = "Durum: Beklemede";
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(34, 34, 46);
            this.panelSettings.Controls.Add(this.chkOnlyWhenActive);
            this.panelSettings.Controls.Add(this.btnRefreshWindows);
            this.panelSettings.Controls.Add(this.cmbWindows);
            this.panelSettings.Controls.Add(this.lblSelectWindow);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(180, 40);
            this.panelSettings.Size = new System.Drawing.Size(670, 460);
            this.panelSettings.Visible = false;
            // 
            // lblSelectWindow
            // 
            this.lblSelectWindow.AutoSize = true;
            this.lblSelectWindow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectWindow.ForeColor = System.Drawing.Color.White;
            this.lblSelectWindow.Location = new System.Drawing.Point(30, 30);
            this.lblSelectWindow.Text = "Hedef Pencere Seç";
            // 
            // cmbWindows
            // 
            this.cmbWindows.BackColor = System.Drawing.Color.Transparent;
            this.cmbWindows.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindows.FillColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.cmbWindows.FocusedColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.cmbWindows.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbWindows.ForeColor = System.Drawing.Color.White;
            this.cmbWindows.ItemHeight = 30;
            this.cmbWindows.Location = new System.Drawing.Point(30, 60);
            this.cmbWindows.Size = new System.Drawing.Size(400, 36);
            // 
            // btnRefreshWindows
            // 
            this.btnRefreshWindows.BorderRadius = 6;
            this.btnRefreshWindows.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnRefreshWindows.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshWindows.ForeColor = System.Drawing.Color.White;
            this.btnRefreshWindows.Location = new System.Drawing.Point(440, 60);
            this.btnRefreshWindows.Size = new System.Drawing.Size(100, 36);
            this.btnRefreshWindows.Text = "Yenile";
            this.btnRefreshWindows.Click += new System.EventHandler(this.btnRefreshWindows_Click);
            // 
            // chkOnlyWhenActive
            // 
            this.chkOnlyWhenActive.Checked = true;
            this.chkOnlyWhenActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.chkOnlyWhenActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.chkOnlyWhenActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkOnlyWhenActive.ForeColor = System.Drawing.Color.White;
            this.chkOnlyWhenActive.Location = new System.Drawing.Point(30, 110);
            this.chkOnlyWhenActive.Size = new System.Drawing.Size(300, 20);
            this.chkOnlyWhenActive.Text = "Sadece seçili pencere aktifken çalış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(34, 34, 46);
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.guna2PanelMain);
            this.Controls.Add(this.guna2PanelLeft);
            this.Controls.Add(this.guna2PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnightHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2PanelTop.ResumeLayout(false);
            this.guna2PanelTop.PerformLayout();
            this.guna2PanelLeft.ResumeLayout(false);
            this.guna2PanelMain.ResumeLayout(false);
            this.guna2PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMPDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPDelay)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelLeft;
        private Guna.UI2.WinForms.Guna2Button btnMain;
        private Guna.UI2.WinForms.Guna2Button btnLogs;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleAutoHP;
        private System.Windows.Forms.Label lblAutoHP;
        private Guna.UI2.WinForms.Guna2TrackBar trackHP;
        private System.Windows.Forms.Label lblHPValue;
        private System.Windows.Forms.Label lblHPKey;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHPKey;
        private System.Windows.Forms.Label lblHPDelay;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHPDelay;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleAutoMP;
        private System.Windows.Forms.Label lblAutoMP;
        private Guna.UI2.WinForms.Guna2TrackBar trackMP;
        private System.Windows.Forms.Label lblMPValue;
        private System.Windows.Forms.Label lblMPKey;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMPKey;
        private System.Windows.Forms.Label lblMPDelay;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMPDelay;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Panel panelSettings;
        private System.Windows.Forms.Label lblSelectWindow;
        private Guna.UI2.WinForms.Guna2ComboBox cmbWindows;
        private Guna.UI2.WinForms.Guna2Button btnRefreshWindows;
        private Guna.UI2.WinForms.Guna2CheckBox chkOnlyWhenActive;
    }
}