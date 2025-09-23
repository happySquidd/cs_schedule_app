using MySql.Data.MySqlClient;
using scheduleApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                Console.WriteLine("mysql connected");
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
                Console.WriteLine("connection closed");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static BindingList<Customer> getCustomers()
        {
            BindingList<Customer> customers = new BindingList<Customer>();

            // double join user and appointment and appointment and customer to retrieve all customers
            string sql = $"SELECT * FROM user INNER JOIN appointment a ON user.userId = a.userId INNER JOIN customer c ON a.customerId = c.customerId WHERE user.userId = '{Form1.userId}'";

            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer()
                    {
                        customerId = Convert.ToInt32(reader["customerId"]),
                        customerName = Convert.ToString(reader["customerName"]),
                        addressId = Convert.ToInt32(reader["addressId"]),
                        active = Convert.ToInt32(reader["active"]),
                        createdBy = Convert.ToString(reader["createdBy"]),
                        lastUpdated = Convert.ToString(reader["lastUpdate"]),
                        lastUpdatedBy = Convert.ToString(reader["lastUpdateBy"])
                    };
                    customers.Add(customer);
                }
                reader.Close();
            }
            return customers;
        }
    }
}
