namespace SchoolManager
{
    partial class Expanded
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expanded));
            this.MissingLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // MissingLabel
            // 
            this.MissingLabel.AutoSize = true;
            this.MissingLabel.BackColor = System.Drawing.SystemColors.Window;
            this.MissingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.MissingLabel.ForeColor = System.Drawing.Color.Red;
            this.MissingLabel.Location = new System.Drawing.Point(394, 285);
            this.MissingLabel.Name = "MissingLabel";
            this.MissingLabel.Size = new System.Drawing.Size(351, 65);
            this.MissingLabel.TabIndex = 0;
            this.MissingLabel.Text = "No Timetable";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // Expanded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1180, 590);
            this.ControlBox = false;
            this.Controls.Add(this.MissingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1180, 590);
            this.MinimumSize = new System.Drawing.Size(1180, 590);
            this.Name = "Expanded";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Two-Week Timetable";
            this.Activated += new System.EventHandler(this.Expanded_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Expanded_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Expanded_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Expanded_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Expanded_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Expanded_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MissingLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}