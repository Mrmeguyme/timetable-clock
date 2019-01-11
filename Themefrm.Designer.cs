namespace SchoolManager
{
    partial class Themefrm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Derp",
            "1",
            "Torca"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themefrm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Previewbox = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemAuthor = new System.Windows.Forms.Label();
            this.ItemVer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Folderbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Previewbox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Ver,
            this.Author});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 42);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 373);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "TItle";
            this.Title.Width = 147;
            // 
            // Ver
            // 
            this.Ver.Text = "Version";
            this.Ver.Width = 54;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 163;
            // 
            // Previewbox
            // 
            this.Previewbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previewbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Previewbox.Location = new System.Drawing.Point(386, 13);
            this.Previewbox.Name = "Previewbox";
            this.Previewbox.Size = new System.Drawing.Size(206, 206);
            this.Previewbox.TabIndex = 1;
            this.Previewbox.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(386, 226);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(33, 13);
            this.ItemName.TabIndex = 2;
            this.ItemName.Text = "Title: ";
            // 
            // ItemAuthor
            // 
            this.ItemAuthor.AutoSize = true;
            this.ItemAuthor.Location = new System.Drawing.Point(386, 241);
            this.ItemAuthor.Name = "ItemAuthor";
            this.ItemAuthor.Size = new System.Drawing.Size(44, 13);
            this.ItemAuthor.TabIndex = 3;
            this.ItemAuthor.Text = "Author: ";
            // 
            // ItemVer
            // 
            this.ItemVer.AutoSize = true;
            this.ItemVer.Location = new System.Drawing.Point(386, 257);
            this.ItemVer.Name = "ItemVer";
            this.ItemVer.Size = new System.Drawing.Size(48, 13);
            this.ItemVer.TabIndex = 4;
            this.ItemVer.Text = "Version: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Folderbutton
            // 
            this.Folderbutton.Location = new System.Drawing.Point(12, 13);
            this.Folderbutton.Name = "Folderbutton";
            this.Folderbutton.Size = new System.Drawing.Size(75, 23);
            this.Folderbutton.TabIndex = 6;
            this.Folderbutton.Text = "Open Folder";
            this.Folderbutton.UseVisualStyleBackColor = true;
            this.Folderbutton.Click += new System.EventHandler(this.Folderbutton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Unload";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(94, 12);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(75, 23);
            this.Refreshbutton.TabIndex = 9;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Workshop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Themefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Folderbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ItemVer);
            this.Controls.Add(this.ItemAuthor);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.Previewbox);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 466);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(620, 466);
            this.Name = "Themefrm";
            this.Text = "Themes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Themefrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Previewbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox Previewbox;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label ItemAuthor;
        private System.Windows.Forms.Label ItemVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Folderbutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Ver;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.Button button2;
    }
}