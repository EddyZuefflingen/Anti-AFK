using Anti_AFK.Classes;
using Anti_AFK.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Anti_AFK
{
    public partial class MainForm : MetroForm
    {
        private KeyHandler ghk;

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private bool AntiAFKOn = false;

        BackgroundWorker keypressWorker = new BackgroundWorker();


        public MainForm()
        {
            InitializeComponent();
            LoadRunningApps();
            InitializeWorker();
            InitializeKeyhandler();
        }

        private void InitializeWorker()
        {
            keypressWorker.DoWork += keypressWorker_DoWork;
            keypressWorker.RunWorkerCompleted += keypressWorker_RunWorkerCompleted;
            keypressWorker.WorkerSupportsCancellation = true;
            keypressWorker.WorkerReportsProgress = true;
            keypressWorker.ProgressChanged += keypressWorker_ProgressChanged;
        }

        private void LoadRunningApps()
        {
            bool SettingFound = false;
            foreach (Process p in Process.GetProcesses())
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    cbApps.Items.Add(p.MainWindowTitle);
                    if (Settings.Default.LastProcess == p.MainWindowTitle)
                        SettingFound = true;
                }

            if (!SettingFound && Settings.Default.LastProcess != "")
                cbApps.Items.Add(Settings.Default.LastProcess);
        }

        private void InitializeKeyhandler()
        {
            ghk = new KeyHandler(Keys.F1, this);
            ghk.Register();
        }

        private void keypressWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> args = e.Argument as List<object>;
            int iCounterSec = 0;
            bool bFirst = true;

            while (!keypressWorker.CancellationPending)
            {
                if (iCounterSec == (int)args[0] || bFirst)
                {
                    keypressWorker.ReportProgress(-1);
                    IntPtr handle = GetForegroundWindow();


                    bFirst = false;
                    foreach (Process proc in Process.GetProcesses())
                    {
                        if (proc.MainWindowTitle == (string)args[1])
                        {
                            SetForegroundWindow(proc.MainWindowHandle);
                            if ((string)args[3] != "")
                                SendKeys.SendWait("{" + txtKeypressCostum.Text.Replace("{", "").Replace("}", "") + "}");
                            else if ((int)args[2] == 0)
                            {
                                SendKeys.SendWait("{W}");
                                SendKeys.SendWait("{A}");
                                SendKeys.SendWait("{D}");
                                SendKeys.SendWait("{S}");
                            }
                            else if ((int)args[2] == 1)
                            {
                                SendKeys.SendWait("{1}");
                                SendKeys.SendWait("{2}");
                                SendKeys.SendWait("{3}");
                                SendKeys.SendWait("{4}");
                            }
                            else if ((int)args[2] == 2)
                            {
                                InputSimulator inputSim = new InputSimulator();
                                //1 Sek. W drücken
                                inputSim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                                Thread.Sleep(1000);
                                inputSim.Keyboard.KeyUp(VirtualKeyCode.VK_W);

                                //Linke Maustaste
                                inputSim.Mouse.LeftButtonClick();
                                Thread.Sleep(3000);

                                //1 Sek. S drücken
                                inputSim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
                                Thread.Sleep(1000);
                                inputSim.Keyboard.KeyUp(VirtualKeyCode.VK_S);

                                //Linke Maustaste
                                inputSim.Mouse.LeftButtonClick();
                            }
                        }
                    }
                    SetForegroundWindow(handle);
                    iCounterSec = 0;
                }
                Thread.Sleep(1000);
                keypressWorker.ReportProgress(iCounterSec);
                iCounterSec++;
            }
        }

        private void keypressWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0)
            {
                TimeSpan TimeIntervall;
                if (txtCostumIntervall.Text != "")
                    TimeIntervall = new TimeSpan(0, 0, Convert.ToInt32(txtCostumIntervall.Text));
                else
                    TimeIntervall = new TimeSpan(0, 0, Convert.ToInt32(ckbIntervall.Text) * 60);
                TimeSpan timeGone = TimeSpan.FromSeconds(e.ProgressPercentage);
                lblNextKeyVal.Text = (TimeIntervall - timeGone).ToString(@"mm\:ss");
            }
            else
                lblLastKeyPressVal.Text = DateTime.Now.ToString("HH:mm");
        }

        private void keypressWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStateVal.Text = "Off";
            AntiAFKOn = false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void HandleHotkey()
        {
            if (!AntiAFKOn)
            {
                if (!keypressWorker.IsBusy)
                {
                    lblStateVal.Text = "On";
                    AntiAFKOn = true;

                    List<object> args = new List<object>();
                    if (txtCostumIntervall.Text != "")
                        args.Add(Convert.ToInt32(txtCostumIntervall.Text));
                    else
                        args.Add((Convert.ToInt32(ckbIntervall.Text) * 60));
                    args.Add(cbApps.Text);
                    args.Add(cbKeypresses.SelectedIndex);
                    args.Add(txtKeypressCostum.Text);

                    keypressWorker.RunWorkerAsync(args);
                }
            }
            else { keypressWorker.CancelAsync(); }
        }

        private void SettingsChange(object sender, EventArgs e)
        {
            //It does not take over the last character of the Costum Keypress when you take it over.
            Settings.Default.CostumKeypress = txtKeypressCostum.Text;
            Settings.Default.Save();
        }

        private void btnCostumKeyInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For simple letters or numbers, just write the character in.");
            MessageBox.Show("For something such as 'ENTER' or 'SPACE', use the following page.");
            Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys?redirectedfrom=MSDN&view=windowsdesktop-6.0");
        }
    }
}
