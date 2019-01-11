using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SplashScreen;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SchoolManager
{
    public partial class Settingsforms : Form
    {
        private bool Savebox = false;
        public int Download
        {
            get { return _Download; }
            set
            {
                if (100 > value && value > 0)
                {
                    SafeUpdatemsg(bytesreceived.ToString("0.###") + "/" + Bytesneeded.ToString("0.###") + " MB");
                    if (progressBar1.InvokeRequired)
                    {
                        Errormsg.Invoke(new Action(() => progressBar1.Value = value));
                        Errormsg.Invoke(new Action(() => progressBar1.Visible = true));
                    }
                    else
                    {
                        progressBar1.Value = value;
                        progressBar1.Visible = true;
                    }
                }
                else if (progressBar1.Visible)
                {
                    if (progressBar1.InvokeRequired)
                        Errormsg.Invoke(new Action(() => progressBar1.Visible = false));
                    else
                        progressBar1.Visible = false;
                    if (value==100)
                        SafeUpdatemsg("Downloaded");
                }

                _Download = value;
            }
        }

        public decimal bytesreceived;
        public decimal Bytesneeded;

        private int _Download;
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        public Settingsforms()
        {
            InitializeComponent();
            label2.Text += Program.APP_VERSION;
        }

        private void Settingsforms_Deactivate(object sender, EventArgs e)
        {
            if (!Savebox)
                Hide();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Errormsg.Text = "Attempting fetch...";
            string usertxt = Userbox.Text;
            string passtxt = Passbox.Text;
            Userbox.Clear();
            Passbox.Clear();
            Task.Run(() =>
            {
                SetLabel1TextSafe(Timetable.UpdateTimetable(usertxt, passtxt).Item1);
                usertxt = "";
                passtxt = "";
            });
        }

        private void SetLabel1TextSafe(string txt)
        {
            if (Errormsg.InvokeRequired)
            {
                Errormsg.Invoke(new Action(() => Errormsg.Text = txt));
                return;
            }
            Errormsg.Text = txt;
        }

        public void SafeUpdatemsg(string txt)
        {
            if (progresslabel.InvokeRequired)
            {
                progresslabel.Invoke(new Action(() => progresslabel.Text = txt));
                progresslabel.Invoke(new Action(() => progresslabel.Update()));
                return;
            }
            progresslabel.Text = txt;
            if (txt.StartsWith("Untrusted")&&Timetable.CertHash!="")
            {
                button1.Visible = true;
                button2.Visible = true;
            }
            progresslabel.Update();
        }

        private void Settingsforms_Shown(object sender, EventArgs e)
        {
            Checksettings();
            SendMessage(Userbox.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(Passbox.Handle, EM_SETCUEBANNER, 0, "Password");
        }

        public void Checksettings()
        {
            Doublescheckbox.Checked = Program.SettingsData.Doubles;
            Hideonend.Checked = Program.SettingsData.Hideonend;
            numericUpDown1.Value = Program.SettingsData.TimeOffset;
            EarlyBox.Checked = Program.SettingsData.EarlyDate.Date == DateTime.Now.Date;
        }

        private void Passbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Loginbutton.PerformClick();
        }

        private void Settingsforms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);  // this cancels the close event.
        }

        private void Weekoverride_Click(object sender, EventArgs e)
        {
            if (Program.SettingsData.Dayoffset == 0)
            {
                Program.SettingsData.Dayoffset = 7;
            }
            else
            {
                Program.SettingsData.Dayoffset = 0;
            }

            Program.curDay = Program.Fetchday();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.SettingsData.TimeOffset = int.Parse(numericUpDown1.Value.ToString());
        }

        private void Doublescheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Program.SettingsData.Doubles = Doublescheckbox.Checked;
        }

        private void Hideonend_CheckedChanged(object sender, EventArgs e)
        {
            Program.SettingsData.Hideonend = Hideonend.Checked;
        }

        private void EarlyBox_Click(object sender, EventArgs e)
        {
            if (Program.SettingsData.EarlyDate.Date != DateTime.Now.Date)
            {
                Program.SettingsData.EarlyDate = DateTime.Now;
                EarlyBox.Checked = true;
            }
            else
            {
                Program.SettingsData.EarlyDate = new DateTime(2017, 1, 1);
                EarlyBox.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SettingsData.Thumbprintlist.Add(Timetable.CertHash);
            progresslabel.Text = "Trusted " + Timetable.CertHash;
            Timetable.CertHash = "";
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timetable.CertHash = "";
            progresslabel.Text = "Untrusted Update Server";
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }


        //Program.BackImage = ResizeImage(Image.FromFile(Program.SETTINGS_DIRECTORY + "/Backimage.png"), 1180,590);
    }

}