using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using scheduleApp.Database;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace scheduleApp
{
    public partial class Form1 : Form
    {
        private readonly string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        public static int userId = 0;
        private bool success = false;
        private readonly string fileName = "Login_History.txt";
        private readonly string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            // set text based on language
            if (culture == "es")
            {
                languageLabel.Text = "Spanish";
                usernameLabel.Text = "Nombre de usuario:";
                passwordLabel.Text = "Contraseña:";
                submit.Text = "Acceso";
                this.Text = "Acceso";
            }
            else
            {
                languageLabel.Text = "English";
            }
            passwordBox.UseSystemPasswordChar = true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text))
            {
                if (culture == "es") { MessageBox.Show("Por favor ingrese un nombre de usuario"); return; }
                else { MessageBox.Show("Please enter a username"); return; }
            }
            if (string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                if (culture == "es") { MessageBox.Show("Por favor ingrese una contraseña"); return; }
                else { MessageBox.Show("Please enter a password"); return; }
            }

            // find the user from database
            string sql = $"SELECT COUNT(*) FROM user WHERE userName = '{usernameBox.Text}' AND password = '{passwordBox.Text}'";
            string id = $"SELECT userId FROM user WHERE userName = '{usernameBox.Text}' AND password = '{passwordBox.Text}'";


            using (MySqlCommand sqlQuery = new MySqlCommand(sql, DBconnection.connection))
            {
                int count = Convert.ToInt32(sqlQuery.ExecuteScalar());
                if (count > 0)
                { // success
                    Console.WriteLine("user logged in");

                    // execute query to get user id
                    using (MySqlCommand getId = new MySqlCommand(id, DBconnection.connection))
                    {
                        // very important line
                        userId = Convert.ToInt32(getId.ExecuteScalar());
                        Console.WriteLine("user id : " + userId);
                    }


                    // see any appointments within 15 minutes
                    if (upcomingAppointment())
                    {
                        MessageBox.Show("You have an appointment in the next 15 minutes.");
                    }
                    success = true;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    success = false;
                    if (culture == "es") { MessageBox.Show("Nombre de usuario o contraseña incorrectos"); }
                    else { MessageBox.Show("Incorrect username or password"); }
                }
            }

            // log into Login_History.txt in desktop
            string filePath = Path.Combine(folderPath, fileName);
            if (success)
            {
                string text = $"Successful login for user: '{usernameBox.Text}' at " + DateTime.UtcNow.ToString() + " UTC" + Environment.NewLine;
                File.AppendAllText(filePath, text);

                this.Close();
            }
            else
            {
                string text = $"Failed login attempt for user: '{usernameBox.Text}' at " + DateTime.UtcNow.ToString() + " UTC" + Environment.NewLine;
                File.AppendAllText(filePath, text);
            }

        }

        // check for any upcoming appointments in the next 15 minutes, return true if there are
        private bool upcomingAppointment()
        {
            DateTime currentTime = DateTime.Now;
            DateTime currentUtcTime = currentTime.ToUniversalTime();
            DateTime timeIn15 = currentUtcTime.AddMinutes(15);
            //Console.WriteLine("current time: " + currentUtcTime.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine("time in 15: " + timeIn15);
            // query to find any appointments within the next 15 minutes
            string sql = $"SELECT COUNT(*) FROM appointment WHERE userId = '{userId}' AND start BETWEEN '{currentUtcTime.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{timeIn15.ToString("yyyy-MM-dd HH:mm:ss")}'";
            using (MySqlCommand command = new MySqlCommand(sql, DBconnection.connection))
            {
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
}
