using scheduleApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBconnection.openConnection();
            using (Form1 login = new Form1())
            {
                // if login successful then show the main window
                if (login.ShowDialog() == DialogResult.OK) 
                {
                    Application.Run(new UserForm());
                }
            }
            DBconnection.closeConnection();
        }
    }
}
