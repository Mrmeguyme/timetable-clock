using System;
using SplashScreen;

namespace SchoolManager
{
    partial class Settingsforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settingsforms));
            this.Userbox = new System.Windows.Forms.TextBox();
            this.Errormsg = new System.Windows.Forms.Label();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Weekoverride = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Doublescheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Hideonend = new System.Windows.Forms.CheckBox();
            this.EarlyBox = new System.Windows.Forms.CheckBox();
            this.progresslabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Userbox
            // 
            this.Userbox.Location = new System.Drawing.Point(3, 348);
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(100, 20);
            this.Userbox.TabIndex = 1;
            // 
            // Errormsg
            // 
            this.Errormsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Errormsg.AutoSize = true;
            this.Errormsg.Location = new System.Drawing.Point(2, 371);
            this.Errormsg.Name = "Errormsg";
            this.Errormsg.Size = new System.Drawing.Size(124, 13);
            this.Errormsg.TabIndex = 2;
            this.Errormsg.Text = "Login to Fetch Timetable";
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(109, 348);
            this.Passbox.Name = "Passbox";
            this.Passbox.PasswordChar = '*';
            this.Passbox.Size = new System.Drawing.Size(100, 20);
            this.Passbox.TabIndex = 3;
            this.Passbox.UseSystemPasswordChar = true;
            this.Passbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passbox_KeyDown);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(215, 348);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "Fetch";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.progresslabel);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Loginbutton);
            this.panel1.Controls.Add(this.Passbox);
            this.panel1.Controls.Add(this.Errormsg);
            this.panel1.Controls.Add(this.Userbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 384);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Not trusted";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Trust";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 334);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.01923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.98077F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(button3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Weekoverride, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Doublescheckbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Hideonend, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EarlyBox, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.36264F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.63736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 310);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Check for Update";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(135, 170);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 22);
            button3.TabIndex = 16;
            button3.Text = "Check";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Early Finish";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(135, 49);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time offset (secs)";
            // 
            // Weekoverride
            // 
            this.Weekoverride.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Weekoverride.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Weekoverride.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Weekoverride.Location = new System.Drawing.Point(135, 4);
            this.Weekoverride.Name = "Weekoverride";
            this.Weekoverride.Size = new System.Drawing.Size(75, 23);
            this.Weekoverride.TabIndex = 8;
            this.Weekoverride.Text = "Switch";
            this.Weekoverride.UseVisualStyleBackColor = false;
            this.Weekoverride.Click += new System.EventHandler(this.Weekoverride_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Switch Week";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Combine Doubles";
            // 
            // Doublescheckbox
            // 
            this.Doublescheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Doublescheckbox.AutoSize = true;
            this.Doublescheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Doublescheckbox.Checked = true;
            this.Doublescheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Doublescheckbox.Location = new System.Drawing.Point(135, 94);
            this.Doublescheckbox.Name = "Doublescheckbox";
            this.Doublescheckbox.Size = new System.Drawing.Size(75, 14);
            this.Doublescheckbox.TabIndex = 13;
            this.Doublescheckbox.UseVisualStyleBackColor = true;
            this.Doublescheckbox.CheckedChanged += new System.EventHandler(this.Doublescheckbox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hide when end";
            // 
            // Hideonend
            // 
            this.Hideonend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Hideonend.AutoSize = true;
            this.Hideonend.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hideonend.Checked = true;
            this.Hideonend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Hideonend.Location = new System.Drawing.Point(135, 119);
            this.Hideonend.Name = "Hideonend";
            this.Hideonend.Size = new System.Drawing.Size(75, 14);
            this.Hideonend.TabIndex = 15;
            this.Hideonend.UseVisualStyleBackColor = true;
            this.Hideonend.CheckedChanged += new System.EventHandler(this.Hideonend_CheckedChanged);
            // 
            // EarlyBox
            // 
            this.EarlyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EarlyBox.AutoSize = true;
            this.EarlyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EarlyBox.Location = new System.Drawing.Point(135, 145);
            this.EarlyBox.Name = "EarlyBox";
            this.EarlyBox.Size = new System.Drawing.Size(75, 14);
            this.EarlyBox.TabIndex = 16;
            this.EarlyBox.UseVisualStyleBackColor = true;
            this.EarlyBox.Click += new System.EventHandler(this.EarlyBox_Click);
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Location = new System.Drawing.Point(469, 95);
            this.progresslabel.MaximumSize = new System.Drawing.Size(170, 150);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(114, 13);
            this.progresslabel.TabIndex = 7;
            this.progresslabel.Text = "Checking for Update...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(472, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 78);
            this.label2.TabIndex = 5;
            this.label2.Text = "About\r\nTimetable Clock made by\r\nWilliam C\r\nDistributed by\r\nJosh Harper\r\nVersion: " +
    "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.FileName = "image.png";
            this.openFileDialog1.InitialDirectory = "pictures";
            this.openFileDialog1.Title = "Background image import";
            // 
            // Settingsforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 384);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settingsforms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Deactivate += new System.EventHandler(this.Settingsforms_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settingsforms_FormClosing);
            this.Shown += new System.EventHandler(this.Settingsforms_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.Label Errormsg;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progresslabel;
        private System.Windows.Forms.Button Weekoverride;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Doublescheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Hideonend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox EarlyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}