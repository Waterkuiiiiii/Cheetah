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
using KingdomTwoCrownsCheater.Properties;
using System.Globalization;
using System.Diagnostics;

namespace KingdomTwoCrownsCheater
{
    public partial class MainForm : MaterialForm
    {
        string CoinsMemAddr1 = "GameAssembly.dll+01C92C58,5C,4,10,F8,70,70,94";
        string GemsMemAddr1 = "GameAssembly.dll+01C92C58,5C,4,10,FC,70,6C,38";
        string SpeedMemAddr1 = "GameAssembly.dll+01C0EABC,408,50,70,48,8,5C,40";
        string CoinsMemAddr2 = "GameAssembly.dll+01CB58A4,20,5C,34,10,54,70,94";
        string GemsMemAddr2 = "GameAssembly.dll+01C8CC20,3C,5C,8,10,54,6C,38";
        string SpeedMemAddr2 = "GameAssembly.dll+01C97988,5C,50,90,54,8,5C,40";

        Mem Mem = new Mem();
        bool IsOpenProc = false;

        int CoinsCount1 = 0;
        int GemsCount1 = 0;
        int PlayerSpeed1 = 0;
        int CoinsCount2 = 0;
        int GemsCount2 = 0;
        int PlayerSpeed2 = 0;

        Hotkey HotkeyZ = new Hotkey(Keys.Z);
        Hotkey HotkeyX = new Hotkey(Keys.X);
        Hotkey HotkeyC = new Hotkey(Keys.C);
        Hotkey HotkeyDel = new Hotkey(Keys.Delete);
        Hotkey HotkeyEnd = new Hotkey(Keys.End);
        Hotkey HotkeyPgDn = new Hotkey(Keys.PageDown);

        int PlayerSpeedRight = 1080000000;
        int PlayerSpeedLeft = -1070000000;
        int PlayerSpeedOffset = 10000000;

        MaterialSkinManager MaterialSkinManager = MaterialSkinManager.Instance;
        public MainForm()
        {
            // Initialize Languge
            switch (Settings.Default.Language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    InitializeComponent();
                    break;
                case "Chinese":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
                    InitializeComponent();
                    break;
                default:
                    InitializeComponent();
                    break;
            }

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            // Initialize Dark Mode
            if (Settings.Default.IsDarkMode)
            {
                MaterialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                darkModeSwtich.Checked = true;
            }
            // Initialize Color Scheme
            switch (Settings.Default.ColorScheme)
            {
                case "Red":
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red300, Accent.Red200, TextShade.WHITE);
                    redRadioButton.Checked = true;
                    break;
                case "Green":
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green300, Accent.Green200, TextShade.WHITE);
                    greenRadioButton.Checked = true;
                    break;
                case "Blue":
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue300, Accent.Blue200, TextShade.WHITE);
                    blueRadioButton.Checked = true;
                    break;
                case "Pink":
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Pink300, Accent.Pink200, TextShade.WHITE);
                    pinkRadioButton.Checked = true;
                    break;
                case "BlueGrey":
                    MaterialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey700, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
                    blueGreyRadioButton.Checked = true;
                    break;
                default:
                    break;
            }

            HotkeyListener hkl = new HotkeyListener();
            hkl.HotkeyPressed += hkl_HotkeyPressed;
            hkl.Add(HotkeyZ);
            hkl.Add(HotkeyX);
            hkl.Add(HotkeyC);
            hkl.Add(HotkeyDel);
            hkl.Add(HotkeyEnd);
            hkl.Add(HotkeyPgDn);
        }
        private void hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            // Player 1
            if (e.Hotkey == HotkeyZ)
            {
                speedCheckBox1.Checked = false;
                Thread.Sleep(100);
                speedCheckBox1.Checked = true;

                ThreadPool.QueueUserWorkItem((state) =>
                {
                    while (speedCheckBox1.Checked)
                    {
                        if (e.Hotkey == HotkeyC)
                        {
                            return;
                        }
                        Mem.WriteMemory(SpeedMemAddr1, "int", (PlayerSpeedLeft + PlayerSpeedOffset).ToString());
                        Thread.Sleep(1);
                    }
                });
            }

            if (e.Hotkey == HotkeyX)
            {
                speedCheckBox1.Checked = false;
                Thread.Sleep(100);
                speedCheckBox1.Checked = true;
            }

            if (e.Hotkey == HotkeyC)
            {
                speedCheckBox1.Checked = false;
                Thread.Sleep(100);
                speedCheckBox1.Checked = true;

                ThreadPool.QueueUserWorkItem((state) =>
                {
                    while (speedCheckBox1.Checked)
                    {
                        Mem.WriteMemory(SpeedMemAddr1, "int", (PlayerSpeedRight + PlayerSpeedOffset).ToString());
                        Thread.Sleep(1);
                    }
                });
            }

            // Player 2
            if (e.Hotkey == HotkeyDel)
            {
                speedCheckBox2.Checked = false;
                Thread.Sleep(100);
                speedCheckBox2.Checked = true;

                ThreadPool.QueueUserWorkItem((state) =>
                {
                    while (speedCheckBox2.Checked)
                    {
                        Mem.WriteMemory(SpeedMemAddr2, "int", (PlayerSpeedLeft + PlayerSpeedOffset).ToString());
                        Thread.Sleep(1);
                    }
                });
            }

            if (e.Hotkey == HotkeyEnd)
            {
                speedCheckBox2.Checked = false;
                Thread.Sleep(100);
                speedCheckBox2.Checked = true;
            }

            if (e.Hotkey == HotkeyPgDn)
            {
                speedCheckBox2.Checked = false;
                Thread.Sleep(100);
                speedCheckBox2.Checked = true;

                ThreadPool.QueueUserWorkItem((state) =>
                {
                    while (speedCheckBox2.Checked)
                    {
                        Mem.WriteMemory(SpeedMemAddr2, "int", (PlayerSpeedRight + PlayerSpeedOffset).ToString());
                        Thread.Sleep(1);
                    }
                });
            }
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
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IsOpenProc = Mem.OpenProcess("KingdomTwoCrowns.exe");
            if (!IsOpenProc)
            {
                Thread.Sleep(1000);
                return;
            }

            Thread.Sleep(1000);
            bgWorker.ReportProgress(0);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!IsOpenProc)
            {
                return;
            }

            procOpenLable1.Text = "Game Found";
            procOpenLable2.Text = "Game Found";

            CoinsCount1 = Mem.ReadMemory<int>(CoinsMemAddr1);
            coinsCountLabel1.Text = CoinsCount1.ToString();

            GemsCount1 = Mem.ReadMemory<int>(GemsMemAddr1);
            gemsCountLabel1.Text = GemsCount1.ToString();

            PlayerSpeed1 = Mem.ReadMemory<int>(SpeedMemAddr1);
            speedLabel1.Text = PlayerSpeed1.ToString();

            CoinsCount2 = Mem.ReadMemory<int>(CoinsMemAddr2);
            coinsCountLabel2.Text = CoinsCount2.ToString();

            GemsCount2 = Mem.ReadMemory<int>(GemsMemAddr2);
            gemsCountLabel2.Text = GemsCount2.ToString();

            PlayerSpeed2 = Mem.ReadMemory<int>(SpeedMemAddr2);
            speedLabel2.Text = PlayerSpeed2.ToString();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        // Reuse Methods
        private bool UnDigitalFilter(string input)
        {
            bool isDigital = false;
            byte[] bytes = Encoding.ASCII.GetBytes(input);

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

            return isDigital;
        }

        #region Player
        /// <summary>
        /// Player 1
        /// <summary>

        // Coins
        private void coinsTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(coinsTextBox1.Text);

            if (coinsTextBox1.Text == "" || !isDigital)
            {
                return;
            }

            // Write Memory Code
            if (e.KeyCode == Keys.Enter)
            {
                Mem.WriteMemory(CoinsMemAddr1, "int", coinsTextBox1.Text);
            }
        }

        private void coinsSendButton1_Click(object sender, EventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(coinsTextBox1.Text);

            if (coinsTextBox1.Text == "" || !isDigital)
            {
                return;
            }

            // Write Memory Code
            Mem.WriteMemory(CoinsMemAddr1, "int", coinsTextBox1.Text);
        }

        private void coinsCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!coinsCheckBox1.Checked)
            {
                return;
            }

            string freezeValue = coinsCountLabel1.Text;
            ThreadPool.QueueUserWorkItem((state) =>
            {
                while (coinsCheckBox1.Checked)
                {
                    Mem.WriteMemory(CoinsMemAddr1, "int", freezeValue);
                    Thread.Sleep(1);
                }
            });
        }

        // Gems
        private void gemsTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(gemsTextBox1.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if (gemsTextBox1.Text == "" || !isDigital)
                {
                    return;
                }

                // Write Memory Code
                Mem.WriteMemory(GemsMemAddr1, "int", gemsTextBox1.Text);
            }
        }

        private void gemsSendButton1_Click(object sender, EventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(gemsTextBox1.Text);

            if (gemsTextBox1.Text == "" || !isDigital)
            {
                return;
            }

            // Write Memory Code
            Mem.WriteMemory(GemsMemAddr1, "int", gemsTextBox1.Text);
        }

        private void gemsCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!gemsCheckBox1.Checked)
            {
                return;
            }

            string freezeValue = gemsCountLabel1.Text;
            ThreadPool.QueueUserWorkItem((state) =>
            {
                while (gemsCheckBox1.Checked)
                {
                    Mem.WriteMemory(GemsMemAddr1, "int", freezeValue);
                    Thread.Sleep(1);
                }
            });
        }

        // Speed
        private void speedSlider1_onValueChanged(object sender, int newValue)
        {
            PlayerSpeedOffset = 10000000;
            int speedSliderValue = speedSlider1.Value / 10;
            PlayerSpeedOffset *= speedSliderValue;
        }

        /// <summary>
        /// Player 2
        /// <summary>

        // Coins
        private void coinsTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(coinsTextBox2.Text);

            if (coinsTextBox2.Text == "" || !isDigital)
            {
                return;
            }

            // Write Memory Code
            if (e.KeyCode == Keys.Enter)
            {
                Mem.WriteMemory(CoinsMemAddr2, "int", coinsTextBox2.Text);
            }
        }

        private void coinsSendButton2_Click(object sender, EventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(coinsTextBox2.Text);

            if (coinsTextBox2.Text == "" || !isDigital)
            {
                return;
            }

            // Write Memory Code
            Mem.WriteMemory(CoinsMemAddr2, "int", coinsTextBox2.Text);
        }

        private void coinsCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!coinsCheckBox2.Checked)
            {
                return;
            }

            string freezeValue = coinsCountLabel2.Text;
            ThreadPool.QueueUserWorkItem((state) =>
            {
                while (coinsCheckBox2.Checked)
                {
                    Mem.WriteMemory(CoinsMemAddr2, "int", freezeValue);
                    Thread.Sleep(1);
                }
            });
        }

        // Gems
        private void gemsTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            bool isDigital = UnDigitalFilter(gemsTextBox2.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if (gemsTextBox2.Text == "" || !isDigital)
                {
                    return;
                }

                Mem.WriteMemory(GemsMemAddr2, "int", gemsTextBox2.Text);
            }
        }

        private void gemsSendButton2_Click(object sender, EventArgs e)
        {
            // Protection Code
            bool isDigital = UnDigitalFilter(gemsTextBox2.Text);

            if (gemsTextBox2.Text == "" || !isDigital)
            {
                return;
            }

            // Write Memory Code
            Mem.WriteMemory(GemsMemAddr2, "int", gemsTextBox2.Text);
        }

        private void gemsCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!gemsCheckBox2.Checked)
            {
                return;
            }

            string freezeValue = gemsCountLabel2.Text;
            ThreadPool.QueueUserWorkItem((state) =>
            {
                while (gemsCheckBox2.Checked)
                {
                    Mem.WriteMemory(GemsMemAddr2, "int", freezeValue);
                    Thread.Sleep(1);
                }
            });
        }

        // Speed
        private void speedSlider2_onValueChanged(object sender, int newValue)
        {
            PlayerSpeedOffset = 10000000;
            int speedSliderValue = speedSlider2.Value / 10;
            PlayerSpeedOffset *= speedSliderValue;
        }
        #endregion

        #region Theme
        //Dark Mode
        private void darkModeSwtich_CheckedChanged(object sender, EventArgs e)
        {
            if (darkModeSwtich.Checked)
            {
                MaterialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                Settings.Default.IsDarkMode = true;
                Settings.Default.Save();
            }
            else
            {
                MaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                Settings.Default.IsDarkMode = false;
                Settings.Default.Save();
            }
        }

        // Color Scheme
        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red300, Accent.Red200, TextShade.WHITE);

            Settings.Default.ColorScheme = "Red";
            Settings.Default.Save();
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green300, Accent.Green200, TextShade.WHITE);

            Settings.Default.ColorScheme = "Green";
            Settings.Default.Save();
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue300, Accent.Blue200, TextShade.WHITE);

            Settings.Default.ColorScheme = "Blue";
            Settings.Default.Save();
        }

        private void pinkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Pink300, Accent.Pink200, TextShade.WHITE);

            Settings.Default.ColorScheme = "Pink";
            Settings.Default.Save();
        }

        private void blueGreyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey700, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);

            Settings.Default.ColorScheme = "BlueGrey";
            Settings.Default.Save();
        }
        #endregion

        // Language
        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (langComboBox.SelectedIndex)
            {
                case 1:
                    Settings.Default.Language = "English";
                    Settings.Default.Save();
                    MaterialMessageBox.Show("The application needs to be restated when changing the language.");
                    break;
                case 2:
                    Settings.Default.Language = "Chinese";
                    Settings.Default.Save();
                    MaterialMessageBox.Show("该应用更换语言时需要重启。");
                    break;
                default:
                    MaterialMessageBox.Show("Σ(っ °Д °;)っ");
                    break;
            }

            Application.Restart();
        }

        // About Me
        private void aboutButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Waterkuiiiiii/Cheetah");
        }
    }
}
