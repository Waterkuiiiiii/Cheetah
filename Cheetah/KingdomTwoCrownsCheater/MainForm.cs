using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using WK.Libraries.HotkeyListenerNS;
using MaterialSkin.Controls;
using MaterialSkin;

namespace KingdomTwoCrownsCheater
{
    public partial class MainForm : MaterialForm
    {
        Mem Mem = new Mem();
        bool IsOpenProc = false;

        int CoinsCount = 0;
        int PlayerSpeed = 0;

        Hotkey HotkeyZ = new Hotkey(Keys.Z);
        Hotkey HotkeyX = new Hotkey(Keys.X);
        Hotkey HotkeyC = new Hotkey(Keys.C);

        int PlayerSpeedRight = 1080000000;
        int PlayerSpeedLeft = -1070000000;
        int PlayerSpeedOffset = 10000000;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            HotkeyListener hkl = new HotkeyListener();
            hkl.HotkeyPressed += hkl_HotkeyPressed;
            hkl.Add(HotkeyZ);
            hkl.Add(HotkeyX);
            hkl.Add(HotkeyC);
        }
        private void hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == HotkeyZ)
            {
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    while (SpeedCheckBox.Checked)
                    {
                        if (e.Hotkey == HotkeyC)
                        {
                            return;
                        }
                        Mem.WriteMemory("UnityPlayer.dll+012AC734,6C,4,0,0,4,10,40", "int", (PlayerSpeedLeft + PlayerSpeedOffset).ToString());
                        Thread.Sleep(1);
                    }
                });
            }

            if (e.Hotkey == HotkeyX)
            {
                SpeedCheckBox.Checked = false;
                Thread.Sleep(100);
                SpeedCheckBox.Checked = true;
            }

            if (e.Hotkey == HotkeyC)
            {
                ThreadPool.QueueUserWorkItem((state) =>
                {
                    while (SpeedCheckBox.Checked)
                    {
                        Mem.WriteMemory("UnityPlayer.dll+012AC734,6C,4,0,0,4,10,40", "int", (PlayerSpeedRight + PlayerSpeedOffset).ToString());
                        Thread.Sleep(1);
                    }
                });
            }
        }
        private void SpeedSlider_onValueChanged(object sender, int newValue)
        {
            PlayerSpeedOffset = 10000000;
            int speedSliderValue = SpeedSlider.Value / 10;
            PlayerSpeedOffset *= speedSliderValue;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                Application.Exit();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IsOpenProc = Mem.OpenProcess("KingdomTwoCrowns.exe");
            if (!IsOpenProc)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!IsOpenProc)
            {
                return;
            }

            ProcOpenLable.Text = "Game Found";

            CoinsCount = Mem.ReadMemory<int>("GameAssembly.dll+01C0EABC,408,FC,DC,60,70,6C,34");
            CoinsCoutLabel.Text = CoinsCount.ToString();

            PlayerSpeed = Mem.ReadMemory<int>("UnityPlayer.dll+012AC734,6C,4,0,0,4,10,40");
            SpeedLabel.Text = PlayerSpeed.ToString();
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void CoinsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!CoinsCheckBox.Checked)
            {
                return;
            }

            string freezeValue = CoinsCoutLabel.Text;
            ThreadPool.QueueUserWorkItem((state) =>
            {
                while (CoinsCheckBox.Checked)
                {
                    Mem.WriteMemory("GameAssembly.dll+01C0EABC,408,FC,DC,60,70,6C,34", "int", freezeValue);
                    Thread.Sleep(1);
                }
            });
        }

        private void SendCoinsButton_Click(object sender, EventArgs e)
        {
            bool isDigital = false;
            byte[] bytes = Encoding.ASCII.GetBytes(CoinsTextBox.Text);

            foreach (var item in bytes)
            {
                if (item <= 57 && item >= 48)
                {
                    isDigital = true;
                }
                else
                {
                    isDigital = false;
                    break;
                }
            }

            if (CoinsTextBox.Text == "" || !isDigital)
            {
                return;
            }

            Mem.WriteMemory("GameAssembly.dll+01C0EABC,408,FC,DC,60,70,6C,34", "int", CoinsTextBox.Text);
        }

        private void CoinsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool isDigital = false;
            byte[] bytes = Encoding.ASCII.GetBytes(CoinsTextBox.Text);

            foreach (var item in bytes)
            {
                if (item <= 57 && item >= 48)
                {
                    isDigital = true;
                }
                else
                {
                    isDigital = false;
                    break;
                }
            }

            if (CoinsTextBox.Text == "" || !isDigital)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Mem.WriteMemory("GameAssembly.dll+01C0EABC,408,FC,DC,60,70,6C,34", "int", CoinsTextBox.Text);
            }
        }
    }
}
