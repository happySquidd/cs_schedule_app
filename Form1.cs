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

namespace scheduleApp
{
    public partial class Form1 : Form
    {
        readonly string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

        public Form1()
        {
            InitializeComponent();

            // set text based on language
            if (culture == "es") 
            { 
                languageLabel.Text = "Spanish";
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                submit.Text = "Acceso";
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

            MessageBox.Show(culture);
        }

    }
}
