using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadingForm loadForm = new LoadingForm();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            loadForm.Show();

            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }

            loadForm.Close();
            loadForm.Dispose();

            Application.Run(new LoginForm());
        }

       
    }
}
