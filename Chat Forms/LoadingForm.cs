using System;
using System.Windows.Forms;

namespace Chat_Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value == 100)
                timer1.Stop();

            bunifuCircleProgressbar1.Value += 1;
        }
    }
}