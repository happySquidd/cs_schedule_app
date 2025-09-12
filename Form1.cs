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

namespace scheduleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get the connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            // make the connection
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(constr);

                conn.Open();
                MessageBox.Show("Connected to db");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close the connection
                if(conn != null) { conn.Close(); }
            }
        }
    }
}
