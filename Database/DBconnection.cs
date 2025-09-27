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
                        createdDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cuCreateDate"].ToString()), TimeZoneInfo.Local)),
                        createdBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cuCreatedBy"].ToString()), TimeZoneInfo.Local)),
                        lastUpdated = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cuLastUpdate"].ToString()), TimeZoneInfo.Local)),
                        lastUpdatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cuLastUpdateBy"].ToString()), TimeZoneInfo.Local)),

                        // address
                        address = Convert.ToString(reader["address"]),
                        address2 = Convert.ToString(reader["address2"]),
                        cityId = Convert.ToInt32(reader["cityId"]),
                        postalCode = Convert.ToString(reader["postalCode"]),
                        phone = Convert.ToString(reader["phone"]),
                        addressCreatedDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["adCreateDate"].ToString()), TimeZoneInfo.Local)),
                        addressCreatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["adCreatedBy"].ToString()), TimeZoneInfo.Local)),
                        addressLastUpdated = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["adLastUpdate"].ToString()), TimeZoneInfo.Local)),
                        addressLastUpdatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["adLastUpdateBy"].ToString()), TimeZoneInfo.Local)),

                        // city
                        city = Convert.ToString(reader["city"]),
                        countryId = Convert.ToInt32(reader["countryId"]),
                        cityCreatedDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["ciCreateDate"].ToString()), TimeZoneInfo.Local)),
                        cityCreatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["ciCreatedBy"].ToString()), TimeZoneInfo.Local)),
                        cityLastUpdatedDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["ciLastUpdate"].ToString()), TimeZoneInfo.Local)),
                        cityLastUpdatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["ciLastUpdateBy"].ToString()), TimeZoneInfo.Local)),

                        // country 
                        country = Convert.ToString(reader["country"]),
                        countryCreatedDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cyCreateDate"].ToString()), TimeZoneInfo.Local)),
                        countryCreatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cyCreatedBy"].ToString()), TimeZoneInfo.Local)),
                        countryLastUpdatedDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cyLastUpdate"].ToString()), TimeZoneInfo.Local)),
                        countryLastUpdatedBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["cyLastUpdateBy"].ToString()), TimeZoneInfo.Local))
                    };
                    customers.Add(customer);
                }
                reader.Close();
            }
            return customers;
        }

        public static BindingList<Appointment> GetAppointments()
        {
            BindingList<Appointment> appointments = new BindingList<Appointment>();

            // select all appointments that match user id and list customer name based on customer id
            string command = 
                $"SELECT ap.*, cu.customerName, ad.phone " +
                $"FROM user " +
                $"INNER JOIN appointment ap ON user.userId = ap.userId " +
                $"INNER JOIN customer cu ON ap.customerId = cu.customerId " +
                $"INNER JOIN address ad ON cu.addressId = ad.addressId " +
                $"WHERE user.userId = '{Form1.userId}'";

            using (MySqlCommand com = new MySqlCommand(command, connection)) 
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
                        start = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["start"].ToString()), TimeZoneInfo.Local)),
                        end = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["end"].ToString()), TimeZoneInfo.Local)),
                        createDate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["createDate"].ToString()), TimeZoneInfo.Local)),
                        createdBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["createdBy"].ToString()), TimeZoneInfo.Local)),
                        lastUpdate = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["lastUpdate"].ToString()), TimeZoneInfo.Local)),
                        lastUpdateBy = Convert.ToString(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(reader["lastUpdateBy"].ToString()), TimeZoneInfo.Local)),

                        customerName = Convert.ToString(reader["customerName"]),
                        phone = Convert.ToString(reader["phone"])
                    };
                    appointments.Add(appointment);

                }
                reader.Close();
            }
            return appointments;
        }
    }
}
