using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KnightHelper
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private System.Windows.Forms.Timer potionTimer;
        private DateTime lastHPTime = DateTime.MinValue;
        private DateTime lastMPTime = DateTime.MinValue;
        private string targetWindowTitle = "";

        // --- HP/MP Bar Koordinatları (senin screenshot'a göre) ---
        private int hpBarX = 130; // bar sol
        private int hpBarY = 10; // bar üst
        private int mpBarX = 130;
        private int mpBarY = 25;
        private int barWidth = 98; // bar genişliği

        // API'lar
        [DllImport("user32.dll")] static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")] static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")] static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")] static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")] static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        [DllImport("user32.dll")] static extern short VkKeyScan(char ch);
        [DllImport("user32.dll")] static extern uint MapVirtualKey(uint uCode, uint uMapType);
        [DllImport("user32.dll")] static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")] static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")] static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);
        [DllImport("gdi32.dll")] static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT { public int Left; public int Top; public int Right; public int Bottom; }

        const uint KEYEVENTF_KEYUP = 0x0002;

        public Form1()
        {
            InitializeComponent();
            InitTimer();
        }

        private void InitTimer()
        {
            potionTimer = new System.Windows.Forms.Timer();
            potionTimer.Interval = 100; // 100ms'de bir kontrol et
            potionTimer.Tick += PotionTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2PanelTop.MouseDown += (s, ev) => { if (ev.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); } };
            lblTitle.MouseDown += (s, ev) => { if (ev.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); } };

            trackHP.Scroll += (s, ev) => lblHPValue.Text = $"%{trackHP.Value}";
            trackMP.Scroll += (s, ev) => lblMPValue.Text = $"%{trackMP.Value}";
            lblHPValue.Text = $"%{trackHP.Value}";
            lblMPValue.Text = $"%{trackMP.Value}";

            for (int i = 1; i <= 8; i++) { cmbHPKey.Items.Add(i.ToString()); cmbMPKey.Items.Add(i.ToString()); }
            cmbHPKey.SelectedIndex = 0; // 1
            cmbMPKey.SelectedIndex = 1; // 2

            RefreshWindowList();
            UpdateStatus("Beklemede", Color.Orange);
        }

        private void RefreshWindowList()
        {
            cmbWindows.Items.Clear();
            var list = Process.GetProcesses().Where(p => !string.IsNullOrEmpty(p.MainWindowTitle)).OrderBy(p => p.MainWindowTitle);
            foreach (var p in list) cmbWindows.Items.Add(p.MainWindowTitle);
            var hitko = cmbWindows.Items.Cast<string>().FirstOrDefault(s => s.Contains("Knight") || s.Contains("HitKO"));
            if (hitko != null) cmbWindows.SelectedItem = hitko;
        }

        private void btnRefreshWindows_Click(object sender, EventArgs e) => RefreshWindowList();

        private void PotionTimer_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(targetWindowTitle)) return;
            IntPtr hWnd = FindWindow(null, targetWindowTitle);
            if (hWnd == IntPtr.Zero) return;

            if (chkOnlyWhenActive.Checked)
            {
                IntPtr fg = GetForegroundWindow();
                var sb = new StringBuilder(256);
                GetWindowText(fg, sb, 256);
                if (!sb.ToString().Equals(targetWindowTitle)) return;
            }

            var now = DateTime.Now;

            // HP KONTROL
            if (toggleAutoHP.Checked && IsHpBelow(trackHP.Value) && (now - lastHPTime).TotalMilliseconds >= (double)nudHPDelay.Value)
            {
                PressKey(cmbHPKey.Text[0]);
                lastHPTime = now;
                UpdateStatus($"HP Pot basıldı %{trackHP.Value}", Color.Lime);
            }

            // MP KONTROL
            if (toggleAutoMP.Checked && IsMpBelow(trackMP.Value) && (now - lastMPTime).TotalMilliseconds >= (double)nudMPDelay.Value)
            {
                PressKey(cmbMPKey.Text[0]);
                lastMPTime = now;
                UpdateStatus($"MP Pot basıldı %{trackMP.Value}", Color.Cyan);
            }
        }

        private bool IsHpBelow(int percent)
        {
            IntPtr hWnd = FindWindow(null, targetWindowTitle);
            if (!GetWindowRect(hWnd, out RECT r)) return false;

            int checkX = r.Left + hpBarX + (barWidth * percent / 100);
            int checkY = r.Top + hpBarY;

            Color c = GetPixelColor(checkX, checkY);
            // HP barı kırmızıdır, eğer kırmızı yoksa can düşmüş
            return c.R < 100; // kırmızı < 100 ise boş
        }

        private bool IsMpBelow(int percent)
        {
            IntPtr hWnd = FindWindow(null, targetWindowTitle);
            if (!GetWindowRect(hWnd, out RECT r)) return false;

            int checkX = r.Left + mpBarX + (barWidth * percent / 100);
            int checkY = r.Top + mpBarY;

            Color c = GetPixelColor(checkX, checkY);
            // MP barı mavidir
            return c.B < 100;
        }

        private Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            return Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
        }

        private void PressKey(char key)
        {
            IntPtr hWnd = FindWindow(null, targetWindowTitle);
            if (hWnd == IntPtr.Zero) return;

            ShowWindow(hWnd, 9);
            SetForegroundWindow(hWnd);
            System.Threading.Thread.Sleep(30);

            short vk = VkKeyScan(key);
            byte vkCode = (byte)(vk & 0xff);
            uint scan = MapVirtualKey(vkCode, 0);

            keybd_event(vkCode, (byte)scan, 0, 0);
            System.Threading.Thread.Sleep(20);
            keybd_event(vkCode, (byte)scan, KEYEVENTF_KEYUP, 0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbWindows.SelectedItem == null) { MessageBox.Show("Ayarlardan hedef pencere seç!"); return; }
            targetWindowTitle = cmbWindows.SelectedItem.ToString();
            isRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            potionTimer.Start();
            UpdateStatus("Pixel okuma aktif", Color.Lime);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            potionTimer.Stop();
            UpdateStatus("Durduruldu", Color.Red);
        }

        private void UpdateStatus(string text, Color color) { lblStatus.Text = $"Durum: {text}"; lblStatus.ForeColor = color; }

        private void btnMain_Click(object sender, EventArgs e) { SetActiveButton(btnMain); panelSettings.Visible = false; guna2PanelMain.Visible = true; }
        private void btnLogs_Click(object sender, EventArgs e) { SetActiveButton(btnLogs); MessageBox.Show("Log paneli yakında"); }
        private void btnSettings_Click(object sender, EventArgs e) { SetActiveButton(btnSettings); guna2PanelMain.Visible = false; panelSettings.Visible = true; panelSettings.BringToFront(); RefreshWindowList(); }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            btnMain.FillColor = Color.Transparent; btnLogs.FillColor = Color.Transparent; btnSettings.FillColor = Color.Transparent;
            btnMain.ForeColor = Color.Silver; btnLogs.ForeColor = Color.Silver; btnSettings.ForeColor = Color.Silver;
            btn.FillColor = Color.FromArgb(0, 122, 204); btn.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
    }
}