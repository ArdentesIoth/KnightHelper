using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KnightHelper
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        DateTime lastHpPot = DateTime.MinValue;
        DateTime lastMpPot = DateTime.MinValue;

        TextBox hpKeyBox;
        TextBox mpKeyBox;

        TextBox hpPercentBox;
        TextBox mpPercentBox;

        TextBox hpDelayBox;
        TextBox mpDelayBox;

        Label statusLabel;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        const int KEYEVENTF_KEYUP = 0x0002;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Knight Helper";
            this.Width = 500;
            this.Height = 450;

            // TAB CONTROL
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // SADECE 1 TAB
            TabPage potionTab = new TabPage("Potion");

            tabControl.TabPages.Add(potionTab);

            this.Controls.Add(tabControl);

            // HP POT TUŞU
            Label hpKeyLabel = new Label();
            hpKeyLabel.Text = "HP Pot Tuşu";
            hpKeyLabel.Top = 30;
            hpKeyLabel.Left = 20;
            hpKeyLabel.AutoSize = true;

            potionTab.Controls.Add(hpKeyLabel);

            hpKeyBox = new TextBox();
            hpKeyBox.Top = 50;
            hpKeyBox.Left = 20;
            hpKeyBox.Width = 100;
            hpKeyBox.Text = "7";

            potionTab.Controls.Add(hpKeyBox);

            // MP POT TUŞU
            Label mpKeyLabel = new Label();
            mpKeyLabel.Text = "MP Pot Tuşu";
            mpKeyLabel.Top = 90;
            mpKeyLabel.Left = 20;
            mpKeyLabel.AutoSize = true;

            potionTab.Controls.Add(mpKeyLabel);

            mpKeyBox = new TextBox();
            mpKeyBox.Top = 110;
            mpKeyBox.Left = 20;
            mpKeyBox.Width = 100;
            mpKeyBox.Text = "8";

            potionTab.Controls.Add(mpKeyBox);

            // HP YÜZDE
            Label hpPercentLabel = new Label();
            hpPercentLabel.Text = "HP Pot Yüzdesi";
            hpPercentLabel.Top = 150;
            hpPercentLabel.Left = 20;
            hpPercentLabel.AutoSize = true;

            potionTab.Controls.Add(hpPercentLabel);

            hpPercentBox = new TextBox();
            hpPercentBox.Top = 170;
            hpPercentBox.Left = 20;
            hpPercentBox.Width = 100;
            hpPercentBox.Text = "60";

            potionTab.Controls.Add(hpPercentBox);

            // MP YÜZDE
            Label mpPercentLabel = new Label();
            mpPercentLabel.Text = "MP Pot Yüzdesi";
            mpPercentLabel.Top = 210;
            mpPercentLabel.Left = 20;
            mpPercentLabel.AutoSize = true;

            potionTab.Controls.Add(mpPercentLabel);

            mpPercentBox = new TextBox();
            mpPercentBox.Top = 230;
            mpPercentBox.Left = 20;
            mpPercentBox.Width = 100;
            mpPercentBox.Text = "40";

            potionTab.Controls.Add(mpPercentBox);

            // HP GECİKME
            Label hpDelayLabel = new Label();
            hpDelayLabel.Text = "HP Gecikme (ms)";
            hpDelayLabel.Top = 30;
            hpDelayLabel.Left = 180;
            hpDelayLabel.AutoSize = true;

            potionTab.Controls.Add(hpDelayLabel);

            hpDelayBox = new TextBox();
            hpDelayBox.Top = 50;
            hpDelayBox.Left = 180;
            hpDelayBox.Width = 100;
            hpDelayBox.Text = "2500";

            potionTab.Controls.Add(hpDelayBox);

            // MP GECİKME
            Label mpDelayLabel = new Label();
            mpDelayLabel.Text = "MP Gecikme (ms)";
            mpDelayLabel.Top = 90;
            mpDelayLabel.Left = 180;
            mpDelayLabel.AutoSize = true;

            potionTab.Controls.Add(mpDelayLabel);

            mpDelayBox = new TextBox();
            mpDelayBox.Top = 110;
            mpDelayBox.Left = 180;
            mpDelayBox.Width = 100;
            mpDelayBox.Text = "2500";

            potionTab.Controls.Add(mpDelayBox);

            // START
            Button startButton = new Button();
            startButton.Text = "START";
            startButton.Top = 300;
            startButton.Left = 20;
            startButton.Width = 120;
            startButton.Height = 40;

            potionTab.Controls.Add(startButton);

            // STOP
            Button stopButton = new Button();
            stopButton.Text = "STOP";
            stopButton.Top = 300;
            stopButton.Left = 160;
            stopButton.Width = 120;
            stopButton.Height = 40;

            potionTab.Controls.Add(stopButton);

            // STATUS
            statusLabel = new Label();
            statusLabel.Text = "Durum : Kapalı";
            statusLabel.Top = 360;
            statusLabel.Left = 20;
            statusLabel.AutoSize = true;

            potionTab.Controls.Add(statusLabel);

            // TIMER
            timer.Interval = 100;

            timer.Tick += Timer_Tick;

            // START EVENT
            startButton.Click += (s, e) =>
            {
                timer.Start();
                statusLabel.Text = "Durum : Aktif";
            };

            // STOP EVENT
            stopButton.Click += (s, e) =>
            {
                timer.Stop();
                statusLabel.Text = "Durum : Kapalı";
            };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // HP KOORDİNAT
            Color hpColor = GetPixelColor(274, 18);

            // MP KOORDİNAT
            Color mpColor = GetPixelColor(273, 35);

            int hpPercent = int.Parse(hpPercentBox.Text);
            int mpPercent = int.Parse(mpPercentBox.Text);

            int hpDelay = int.Parse(hpDelayBox.Text);
            int mpDelay = int.Parse(mpDelayBox.Text);

            // HP ORANI
            int currentHp = hpColor.R;

            // MP ORANI
            int currentMp = mpColor.B;

            // HP POT
            if (currentHp < hpPercent)
            {
                if ((DateTime.Now - lastHpPot).TotalMilliseconds >= hpDelay)
                {
                    SendKey(hpKeyBox.Text);
                    lastHpPot = DateTime.Now;
                }
            }

            // MP POT
            if (currentMp < mpPercent)
            {
                if ((DateTime.Now - lastMpPot).TotalMilliseconds >= mpDelay)
                {
                    SendKey(mpKeyBox.Text);
                    lastMpPot = DateTime.Now;
                }
            }
        }

        void SendKey(string key)
        {
            SendKeys.Send(key);
        }

        Color GetPixelColor(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            }

            return bmp.GetPixel(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}