using System;
using System.Windows.Forms;

namespace Chat_Forms
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loadForm = new LoadingForm();

            loadForm.Show();

            while (loadForm.bunifuCircleProgressbar1.Value != 100)
                Application.DoEvents();

            loadForm.Close();
            loadForm.Dispose();

            Application.Run(new LoginForm());
        }
    }
}