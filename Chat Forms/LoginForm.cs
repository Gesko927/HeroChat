using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms
{
    public partial class LoginForm : Form
    {
        private ChatClientForm form;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            form = new ChatClientForm();
            form.Owner = this;
            form.Show();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
        }
    }
}
