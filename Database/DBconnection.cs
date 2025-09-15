using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.Database
{
    internal class DBconnection
    {
        public static MySqlConnection connection { get; set; }


        public static bool openConnection()
        {
            try
            {
                // get the connection string
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                connection = new MySqlConnection(constr);

                connection.Open();
                //MessageBox.Show("connected");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (connection != null){ connection.Close(); }
                connection = null;
                //MessageBox.Show("closed");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
