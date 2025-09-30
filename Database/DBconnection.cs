using MySql.Data.MySqlClient;
using scheduleApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.Database
{
    internal class DBconnection
    {
        public static MySqlConnection connection { get; set; }

        // open sql connection
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

        // close sql connection
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
            // create a list to add customers to and then return
            BindingList<Customer> customers = new BindingList<Customer>();

            // join user, appointment, customer, address, city, and country tables to retrieve all customers' data
            string sql = 
                $"SELECT cu.customerId, cu.customerName, cu.addressId, cu.active, cu.createDate AS cuCreateDate, cu.createdBy AS cuCreatedBy, cu.lastUpdate AS cuLastUpdate, cu.lastUpdateBy AS cuLastUpdateBy, " +
                $"ad.address, ad.address2, ad.cityId, ad.postalCode, ad.phone, ad.createDate AS adCreateDate, ad.createdBy AS adCreatedBy, ad.lastUpdate AS adLastUpdate, ad.lastUpdateBy AS adLastUpdateBy, " +
                $"ci.city, ci.countryId, ci.createDate AS ciCreateDate, ci.createdBy AS ciCreatedBy, ci.lastUpdate AS ciLastUpdate, ci.lastUpdateBy AS ciLastUpdateBy, " +
                $"cy.country, cy.createDate AS cyCreateDate, cy.createdBy AS cyCreatedBy, cy.lastUpdate AS cyLastUpdate, cy.lastUpdateBy AS cyLastUpdateBy " +
                $"FROM user " +
                $"INNER JOIN appointment ap ON user.userId = ap.userId " +
                $"INNER JOIN customer cu ON ap.customerId = cu.customerId " +
                $"INNER JOIN address ad ON cu.addressId = ad.addressId " +
                $"INNER JOIN city ci ON ad.cityId = ci.cityId " +
                $"INNER JOIN country cy ON ci.countryId = cy.countryId " +
                $"WHERE user.userId = '{Form1.userId}'";

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
                        createdDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["cuCreateDate"])),
                        createdBy = Convert.ToString(reader["cuCreatedBy"]),
                        lastUpdated = Convert.ToString(ConvertDataReaderToLocalDate(reader["cuLastUpdate"])),
                        lastUpdatedBy = Convert.ToString(reader["cuLastUpdateBy"]),

                        // address
                        address = Convert.ToString(reader["address"]),
                        address2 = Convert.ToString(reader["address2"]),
                        cityId = Convert.ToInt32(reader["cityId"]),
                        postalCode = Convert.ToString(reader["postalCode"]),
                        phone = Convert.ToString(reader["phone"]),
                        addressCreatedDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["adCreateDate"])),
                        addressCreatedBy = Convert.ToString(reader["adCreatedBy"]),
                        addressLastUpdated = Convert.ToString(ConvertDataReaderToLocalDate(reader["adLastUpdate"])),
                        addressLastUpdatedBy = Convert.ToString(reader["adLastUpdateBy"]),

                        // city
                        city = Convert.ToString(reader["city"]),
                        countryId = Convert.ToInt32(reader["countryId"]),
                        cityCreatedDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["ciCreateDate"])),
                        cityCreatedBy = Convert.ToString(reader["ciCreatedBy"]),
                        cityLastUpdatedDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["ciLastUpdate"])),
                        cityLastUpdatedBy = Convert.ToString(reader["ciLastUpdateBy"]),

                        // country 
                        country = Convert.ToString(reader["country"]),
                        countryCreatedDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["cyCreateDate"])),
                        countryCreatedBy = Convert.ToString(reader["cyCreatedBy"]),
                        countryLastUpdatedDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["cyLastUpdate"])),
                        countryLastUpdatedBy = Convert.ToString(reader["cyLastUpdateBy"])
                    };
                    customers.Add(customer);
                }
                reader.Close();
            }
            return customers;
        }

        public static BindingList<Appointment> GetAppointments(string query = "none")
        {
            BindingList<Appointment> appointments = new BindingList<Appointment>();

            // select all appointments that match user id and list customer name based on customer id
            string basicQuery =
                $"SELECT ap.*, cu.customerName, ad.phone " +
                $"FROM user " +
                $"INNER JOIN appointment ap ON user.userId = ap.userId " +
                $"INNER JOIN customer cu ON ap.customerId = cu.customerId " +
                $"INNER JOIN address ad ON cu.addressId = ad.addressId " +
                $"WHERE user.userId = '{Form1.userId}'";

            // if no query is given then pull all data
            if (query == "none")
            {
                query = basicQuery;
            } 
            else
            {
                query = basicQuery + " " + query;
                Console.WriteLine("custom query: " + query);
            }

                using (MySqlCommand com = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment()
                        {
                            appointmentId = Convert.ToInt32(reader["appointmentId"]),
                            customerId = Convert.ToInt32(reader["customerId"]),
                            userId = Convert.ToInt32(reader["userId"]),
                            title = Convert.ToString(reader["title"]),
                            description = Convert.ToString(reader["description"]),
                            location = Convert.ToString(reader["location"]),
                            contact = Convert.ToString(reader["contact"]),
                            type = Convert.ToString(reader["type"]),
                            url = Convert.ToString(reader["url"]),
                            start = Convert.ToString(ConvertDataReaderToLocalDate(reader["start"])),
                            end = Convert.ToString(ConvertDataReaderToLocalDate(reader["end"])),
                            createDate = Convert.ToString(ConvertDataReaderToLocalDate(reader["createDate"])),
                            createdBy = Convert.ToString(reader["createdBy"]),
                            lastUpdate = Convert.ToString(ConvertDataReaderToLocalDate(reader["lastUpdate"])),
                            lastUpdateBy = Convert.ToString(reader["lastUpdateBy"]),

                            customerName = Convert.ToString(reader["customerName"]),
                            phone = Convert.ToString(reader["phone"])
                        };
                        appointments.Add(appointment);

                    }
                    reader.Close();
                }
            return appointments;
        }

        private static DateTime ConvertDataReaderToLocalDate(object reader)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(Convert.ToString(reader)), TimeZoneInfo.Local);
        }

    }
}
