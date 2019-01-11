using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SplashScreen;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace SchoolManager
{
    public partial class Expanded : Form
    {
        private bool colorbox = false;
        private Timer Timer1 = new Timer();
        private PointF mouseclick;
        private bool drag;
        private int offsetDragX, offsetDragY;
        private float dx;

        public Expanded()
        {
            InitializeComponent();
            MissingLabel.Visible = false;
            Timer1.Enabled = true;
            Timer1.Interval = 100;
            Timer1.Tick += Timer1tick;
            Timer1.Start();
            using (Graphics g = CreateGraphics())
            {
                dx = 96 / g.DpiX;
            }
        }

        private void Timer1tick(object sender, EventArgs e)
        {
            if(Visible && !drag)
                UpdateFormDisplay(Program.Themedata.Timetableimage);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (colorbox)
                return;
            Hide();
        }

        private void Expanded_Activated(object sender, EventArgs e)
        {
            if (Program.TimetableList.Count == 0)
            {
                MissingLabel.BringToFront();
                MissingLabel.Show();
            }
            else
            {
                MissingLabel.Hide();
            }
        }

        private void Expanded_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);  // this cancels the close event.
        }


        #region CUSTOM PAINT METHODS ----------------------------------------------

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00080000; // Required: set WS_EX_LAYERED extended style
                return cp;
            }
        }

        public void UpdateFormDisplay(Image backgroundImage)
        {
            IntPtr screenDc = API.GetDC(IntPtr.Zero);
            IntPtr memDc = API.CreateCompatibleDC(screenDc);
            IntPtr hBitmap;
            IntPtr oldBitmap;


                //Display-image
                Bitmap bmp = new Bitmap(backgroundImage);
                Graphics g = Graphics.FromImage(bmp);

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (!Controls[i].Visible)
                        continue;
                    Bitmap bmmp = new Bitmap(Controls[i].Width,Controls[i].Height);
                    Controls[i].DrawToBitmap(bmmp,Controls[i].ClientRectangle);
                    g.DrawImage(bmmp,Controls[i].Location);
                }

                PointF mousepos = new PointF(MousePosition.X-Left,MousePosition.Y-Top);
                for (int i = 0; i < 10; i++)
                {
                    if (i + 1 == Program.curDay)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(150,120,120,120)), 110 * i, 0,120,590);
                    }
                    for (int j = 0; j < 7; j++)
                    {
                        Brush pencolourl = Brushes.Aqua;
                        PointF curloc = new PointF(110 * i + 10, 82 * j + 10);
                        RectangleF containerF = new RectangleF(curloc.X,curloc.Y,100,80);
                        int alpha = 255;
                    if (Program.TimetableList.ContainsKey((i + 1) + j.ToString()))
                    {
                        Period curp = Program.TimetableList[(i + 1) + j.ToString()];
                        pencolourl = new SolidBrush(Color.FromArgb(alpha, Program.ColorRef[curp.ClassCode]));
                        Brush textbrush = new SolidBrush(Color.FromArgb(alpha, Color.Black));
                        g.FillRectangle(pencolourl, containerF);
                        g.DrawString(curp.Room, SystemFonts.DefaultFont, textbrush, curloc.X + 60, curloc.Y + 65);
                        g.DrawString(curp.ClassCode, SystemFonts.DefaultFont, textbrush, curloc.X, curloc.Y + 65);
                        g.DrawString(curp.SchoolStaffCode, SystemFonts.DefaultFont, textbrush, curloc.X, curloc.Y + 55);
                        g.DrawString(curp.ClassDescription, SystemFonts.DefaultFont, textbrush, new RectangleF(curloc.X, curloc.Y + 1, 98, 50));
                        textbrush.Dispose();
                    }
                        if (mouseclick.X!=-10000 && containerF.Contains(mouseclick)&& Program.TimetableList.ContainsKey((i + 1) + j.ToString()))
                        {
                            mouseclick = new PointF(-10000, 0);
                            colorbox = true;
                            colorDialog1.Color = Program.ColorRef[Program.TimetableList[(i + 1) + j.ToString()].ClassCode];
                            var results = colorDialog1.ShowDialog();
                            if (results == DialogResult.OK)
                            {
                                Program.ColorRef[Program.TimetableList[(i + 1) + j.ToString()].ClassCode] = colorDialog1.Color;
                            }               
                            colorbox = false;
                        }
                    pencolourl.Dispose();
                }
                }
                    using (Font bigfont = new Font("Trebuchet MS", dx * 18 ))
                    {
                        g.DrawString("Term " + Program.SettingsData.Curterm, bigfont, Brushes.White, 1098, 5);
                    }

                mouseclick = new PointF(-10000, 0);
                hBitmap = bmp.GetHbitmap(Color.FromArgb(0));  //Set the fact that background is transparent
                oldBitmap = API.SelectObject(memDc, hBitmap);

                //Display-rectangle
                Size size = bmp.Size;
                Point pointSource = new Point(0, 0);
                Point topPos = new Point(Left, Top);

                //Set up blending options
                API.BLENDFUNCTION blend = new API.BLENDFUNCTION();
                blend.BlendOp = API.AC_SRC_OVER;
                blend.BlendFlags = 0;
                blend.SourceConstantAlpha = Convert.ToByte(255);
                blend.AlphaFormat = API.AC_SRC_ALPHA;

                API.UpdateLayeredWindow(Handle, screenDc, ref topPos, ref size, memDc, ref pointSource, 0, ref blend, API.ULW_ALPHA);

                //Clean-up
                g.Dispose();
                bmp.Dispose();
                API.ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    API.SelectObject(memDc, oldBitmap);
                    API.DeleteObject(hBitmap);
                }
                API.DeleteDC(memDc);

        }
        #endregion

        private void Expanded_MouseClick(object sender, MouseEventArgs e)
        {
            mouseclick = e.Location;
        }

        private void Expanded_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y < 10 && e.Y > 0 || e.X > 1100 && e.X < 1200)
            {
                drag = true;
                offsetDragX = e.X;
                offsetDragY = e.Y;
            }
        }

        private void Expanded_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Expanded_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Left += e.X-offsetDragX;
                Top += e.Y-offsetDragY;
            }
        }
    }

}

