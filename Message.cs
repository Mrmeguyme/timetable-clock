using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            Hide();
        }

        private void Message_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);  // this cancels the close event.
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Hide();
            BackgroundImage = null;
            Width = 300;
            Height = 300;
        }
    }
}
