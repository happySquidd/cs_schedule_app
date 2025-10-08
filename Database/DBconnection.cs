using MySql.Data.MySqlClient;
using scheduleApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
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
                if (connection != null) { connection.Close(); }
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
                $"SELECT DISTINCT cu.customerId, cu.customerName, cu.addressId, cu.active, cu.createDate AS cuCreateDate, cu.createdBy AS cuCreatedBy, cu.lastUpdate AS cuLastUpdate, cu.lastUpdateBy AS cuLastUpdateBy, " +
                $"ad.address, ad.address2, ad.cityId, ad.postalCode, ad.phone, ad.createDate AS adCreateDate, ad.createdBy AS adCreatedBy, ad.lastUpdate AS adLastUpdate, ad.lastUpdateBy AS adLastUpdateBy, " +
                $"ci.city, ci.countryId, ci.createDate AS ciCreateDate, ci.createdBy AS ciCreatedBy, ci.lastUpdate AS ciLastUpdate, ci.lastUpdateBy AS ciLastUpdateBy, " +
                $"cy.country, cy.createDate AS cyCreateDate, cy.createdBy AS cyCreatedBy, cy.lastUpdate AS cyLastUpdate, cy.lastUpdateBy AS cyLastUpdateBy " +
                $"FROM customer cu " +
                $"INNER JOIN address ad ON cu.addressId = ad.addressId " +
                $"INNER JOIN city ci ON ad.cityId = ci.cityId " +
                $"INNER JOIN country cy ON ci.countryId = cy.countryId";

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
                        createdDate = ConvertDataReaderToLocalDate(reader["cuCreateDate"]),
                        createdBy = Convert.ToString(reader["cuCreatedBy"]),
                        lastUpdated = ConvertDataReaderToLocalDate(reader["cuLastUpdate"]),
                        lastUpdatedBy = Convert.ToString(reader["cuLastUpdateBy"]),

                        // address
                        address = Convert.ToString(reader["address"]),
                        address2 = Convert.ToString(reader["address2"]),
                        cityId = Convert.ToInt32(reader["cityId"]),
                        postalCode = Convert.ToString(reader["postalCode"]),
                        phone = Convert.ToString(reader["phone"]),
                        addressCreatedDate = ConvertDataReaderToLocalDate(reader["adCreateDate"]),
                        addressCreatedBy = Convert.ToString(reader["adCreatedBy"]),
                        addressLastUpdated = ConvertDataReaderToLocalDate(reader["adLastUpdate"]),
                        addressLastUpdatedBy = Convert.ToString(reader["adLastUpdateBy"]),

                        // city
                        city = Convert.ToString(reader["city"]),
                        countryId = Convert.ToInt32(reader["countryId"]),
                        cityCreatedDate = ConvertDataReaderToLocalDate(reader["ciCreateDate"]),
                        cityCreatedBy = Convert.ToString(reader["ciCreatedBy"]),
                        cityLastUpdatedDate = ConvertDataReaderToLocalDate(reader["ciLastUpdate"]),
                        cityLastUpdatedBy = Convert.ToString(reader["ciLastUpdateBy"]),

                        // country 
                        country = Convert.ToString(reader["country"]),
                        countryCreatedDate = ConvertDataReaderToLocalDate(reader["cyCreateDate"]),
                        countryCreatedBy = Convert.ToString(reader["cyCreatedBy"]),
                        countryLastUpdatedDate = ConvertDataReaderToLocalDate(reader["cyLastUpdate"]),
                        countryLastUpdatedBy = Convert.ToString(reader["cyLastUpdateBy"])
                    };
                    customers.Add(customer);
                }
                reader.Close();
            }
            return customers;
        }

        public static BindingList<Customer> GetRelatedCustomers()
        {
            BindingList<Customer> relatedCustomers = new BindingList<Customer>();
            
            string query =
                $"SELECT DISTINCT cu.customerId, cu.customerName, cu.addressId, cu.active, cu.createDate AS cuCreateDate, cu.createdBy AS cuCreatedBy, cu.lastUpdate AS cuLastUpdate, cu.lastUpdateBy AS cuLastUpdateBy, " +
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

            using (MySqlCommand command = new MySqlCommand(query, connection))
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
                        createdDate = ConvertDataReaderToLocalDate(reader["cuCreateDate"]),
                        createdBy = Convert.ToString(reader["cuCreatedBy"]),
                        lastUpdated = ConvertDataReaderToLocalDate(reader["cuLastUpdate"]),
                        lastUpdatedBy = Convert.ToString(reader["cuLastUpdateBy"]),

                        // address
                        address = Convert.ToString(reader["address"]),
                        address2 = Convert.ToString(reader["address2"]),
                        cityId = Convert.ToInt32(reader["cityId"]),
                        postalCode = Convert.ToString(reader["postalCode"]),
                        phone = Convert.ToString(reader["phone"]),
                        addressCreatedDate = ConvertDataReaderToLocalDate(reader["adCreateDate"]),
                        addressCreatedBy = Convert.ToString(reader["adCreatedBy"]),
                        addressLastUpdated = ConvertDataReaderToLocalDate(reader["adLastUpdate"]),
                        addressLastUpdatedBy = Convert.ToString(reader["adLastUpdateBy"]),

                        // city
                        city = Convert.ToString(reader["city"]),
                        countryId = Convert.ToInt32(reader["countryId"]),
                        cityCreatedDate = ConvertDataReaderToLocalDate(reader["ciCreateDate"]),
                        cityCreatedBy = Convert.ToString(reader["ciCreatedBy"]),
                        cityLastUpdatedDate = ConvertDataReaderToLocalDate(reader["ciLastUpdate"]),
                        cityLastUpdatedBy = Convert.ToString(reader["ciLastUpdateBy"]),

                        // country 
                        country = Convert.ToString(reader["country"]),
                        countryCreatedDate = ConvertDataReaderToLocalDate(reader["cyCreateDate"]),
                        countryCreatedBy = Convert.ToString(reader["cyCreatedBy"]),
                        countryLastUpdatedDate = ConvertDataReaderToLocalDate(reader["cyLastUpdate"]),
                        countryLastUpdatedBy = Convert.ToString(reader["cyLastUpdateBy"])
                    };
                    relatedCustomers.Add(customer);
                }
                reader.Close();
            }
            return relatedCustomers;
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
                        start = ConvertDataReaderToLocalDate(reader["start"]),
                        end = ConvertDataReaderToLocalDate(reader["end"]),
                        createDate = ConvertDataReaderToLocalDate(reader["createDate"]),
                        createdBy = Convert.ToString(reader["createdBy"]),
                        lastUpdate = ConvertDataReaderToLocalDate(reader["lastUpdate"]),
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

        private static string ConvertDataReaderToLocalDate(object reader)
        {
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(Convert.ToString(reader)), TimeZoneInfo.Local);
            return localTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

        // Customer handling functions
        public static bool AddCustomer(string customerName, string address, string address2, string postalCode, string phone, string city, string country)
        {
            int countryId = 0;
            int cityId = 0;
            int addressId = 0;


            // see if the country exists and create it if not
            string queryCountry = 
                "USE client_schedule; " +
                "SELECT countryId " +
                "FROM country " +
                "WHERE country = @country;";

            using (MySqlCommand com = new MySqlCommand(queryCountry, connection))
            {
                
                com.Parameters.AddWithValue("@country", country);

                try
                {
                    object exists = com.ExecuteScalar();
                    if (exists != null)
                    {
                        // country exists, get id
                        countryId = Convert.ToInt32(com.ExecuteScalar());
                        Console.WriteLine("db return: country exists");
                        // continue after the try catch block
                    }
                    else
                    {
                        // country doesn't exist, try creating it
                        countryId = CreateCountry(country);
                        if (countryId == 0)
                        {
                            Console.WriteLine("create country crashed");
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 6: " + ex.Message);
                    return false;
                }
            }

            // check if city exists, make it if not
            string queryCity =
                $"USE client_schedule; " +
                $"SELECT cityId " +
                $"FROM city " +
                $"WHERE city = @city AND countryID = {countryId};";
            try
            {
                using (MySqlCommand com = new MySqlCommand(queryCity, connection))
                {
                    com.Parameters.AddWithValue("@city", city);
                    object exists = com.ExecuteScalar();

                    if (exists != null)
                    {
                        // city exists, set id
                        cityId = Convert.ToInt32(com.ExecuteScalar());
                        Console.WriteLine("db return: city exists");
                    }
                    else
                    {
                        //create city
                        cityId = CreateCity(countryId, city);
                        if (cityId == 0)
                        {
                            Console.WriteLine("create city crashed");
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("sql error 5: " + ex.Message);
            }


            // check if address exists
            string queryAddress =
                $"USE client_schedule; " +
                $"SELECT addressId " +
                $"FROM address " +
                $"WHERE address = @address AND cityId = {cityId};";
            try
            {
                using (MySqlCommand com = new MySqlCommand(queryAddress, connection))
                {
                    com.Parameters.AddWithValue("@address", address);
                    object exists = com.ExecuteScalar();
                    if (exists != null)
                    {
                        //address exists
                        addressId = Convert.ToInt32(exists);
                        Console.WriteLine("db return: address exists");
                    }
                    else
                    {
                        // doesn't exist, create it
                        addressId = CreateAddress(address, address2, cityId, postalCode, phone);
                        if (addressId == 0)
                        {
                            Console.WriteLine("create address crashed");
                            return false;
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("sql error 8:" + ex.Message);
                return false;
            }
            

            // if here then ready to create user
            string queryCustomer =
                "USE client_schedule; " +
                "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES (@name, @addressId, 1, NOW(), 'user', NOW(), 'user');";
            using (MySqlCommand com = new MySqlCommand(queryCustomer, connection))
            {
                com.Parameters.AddWithValue("@name", customerName);
                com.Parameters.AddWithValue("@addressId", addressId);
                try
                {
                    com.ExecuteNonQuery();
                    // if here then everything is a success!
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 9: " + ex.Message);
                    return false;
                }
            }

        }

        public static bool UpdateCustomer(int customerId, string country, string city, string address, string address2, string postal, string phone, string name)
        {
            string query =
                "USE client_schedule; " +
                "UPDATE country co " +
                "JOIN city ci ON co.countryId = ci.countryId " +
                "JOIN address ad ON ci.cityId = ad.cityId " +
                "JOIN customer ON ad.addressId = customer.addressId " +
                "SET co.country = @country, ci.city = @city, " +
                "ad.address = @address, ad.address2 = @address2, ad.postalCode = @postal, ad.phone = @phone, " +
                "customer.customerName = @name " +
                "WHERE customer.customerId = @customerId;";

            using (MySqlCommand com = new MySqlCommand(query, connection))
            {
                com.Parameters.AddWithValue("@country", country);
                com.Parameters.AddWithValue("@city", city);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@address2", address2);
                com.Parameters.AddWithValue("@postal", postal);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@customerId", customerId);

                try
                { 
                    com.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool DeleteCustomer(int customerId)
        {
            string appQuery =
                $"USE client_schedule; " +
                $"DELETE FROM appointment " +
                $"WHERE appointment.customerId = {customerId};";
            string customerQuery =
                $"USE client_schedule; " +
                $"DELETE FROM customer " +
                $"WHERE customerId = {customerId};";

            using (MySqlCommand com = new MySqlCommand(appQuery, connection))
            {
                com.ExecuteNonQuery();
            }

            using (MySqlCommand com = new MySqlCommand(customerQuery, connection))
            {
                var complete = com.ExecuteNonQuery();
                if (complete == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Appointment handling functions
        public static bool CreateAppointment(int customerId, string title, string description, string location,
            string contact, string type, string url, DateTime startTime, DateTime endTime)
        {
            string start = ConvertToUTC(startTime).ToString("yyyy-MM-dd HH:mm:ss");
            string end = ConvertToUTC(endTime).ToString("yyyy-MM-dd HH:mm:ss");
            var query =
                $"USE client_schedule; " +
                $"INSERT INTO appointment " +
                $"(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                $"VALUES (@cuId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, NOW(), 'user', NOW(), 'user')";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cuId", customerId);
                command.Parameters.AddWithValue("@userId", Form1.userId);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@url", url);
                command.Parameters.AddWithValue("@start", start);
                command.Parameters.AddWithValue("@end", end);
                try
                {
                    int result = command.ExecuteNonQuery();
                    if (result == 1)
                    {
                        Console.WriteLine("successfully entered data");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("error creating appointment");
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 1: " + ex.Message);
                    return false;
                }
            }

        }

        public static bool UpdateAppointment(int appointmentId, string title, string description, string location,
            string contact, string type, string url, DateTime startTime, DateTime endTime)
        {
            string start = ConvertToUTC(startTime).ToString("yyyy-MM-dd HH:mm:ss");
            string end = ConvertToUTC(endTime).ToString("yyyy-MM-dd HH:mm:ss");
            string query =
                "USE client_schedule; " +
                "UPDATE appointment " +
                "SET title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, lastUpdate = NOW() " +
                "WHERE appointmentId = @appId;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@url", url);
                command.Parameters.AddWithValue("@start", start);
                command.Parameters.AddWithValue("@end", end);
                command.Parameters.AddWithValue("@appId", appointmentId);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("updated one row");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("error in the update");
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 2: " + ex.Message);
                    return false;
                }
                
            }
        }

        public static bool DeleteAppointment(int appointmentId)
        {
            string query = 
                $"USE client_schedule; " +
                $"DELETE FROM appointment " +
                $"WHERE appointmentId = {appointmentId}";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
                if (result == 1) { Console.WriteLine("deleted one row"); return true; }
                else { return false; }
            }
        }

        private static DateTime ConvertToUTC(DateTime local)
        {
            return TimeZoneInfo.ConvertTimeToUtc(local, TimeZoneInfo.Local);
        }

        // helper functions
        private static int CreateCountry(string country)
        {
            string query =
                "USE client_schedule; " +
                "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES (@country, NOW(), 'user', NOW(), 'user');";
            using (MySqlCommand com = new MySqlCommand(query, connection))
            {
                com.Parameters.AddWithValue("@country", country);

                try
                {
                    if (com.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("created country");
                        com.CommandText =
                            "USE client_schedule; " +
                            "SELECT countryId " +
                            "FROM country " +
                            "WHERE country = @country";
                        //Console.WriteLine("grabbing country id");
                        return Convert.ToInt32(com.ExecuteScalar());
                    }
                    else
                    {
                        Console.WriteLine("error inserting country");
                        return 0;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 3: " + ex.Message);
                    return 0;
                }
            }
        }

        private static int CreateCity(int countryId, string cityName)
        {
            string query =
                "USE client_schedule; " +
                "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES (@city, @countryId, NOW(), 'user', NOW(), 'user');";

            using (MySqlCommand com = new MySqlCommand(query, connection))
            {
                com.Parameters.AddWithValue("@city", cityName);
                com.Parameters.AddWithValue("@countryId", countryId);

                try
                {
                    if (com.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("created city");
                        com.CommandText =
                            $"USE client_schedule; " +
                            $"SELECT cityId " +
                            $"FROM city " +
                            $"WHERE countryId = {countryId};";
                        //Console.WriteLine("grabbing new city id");
                        return Convert.ToInt32(com.ExecuteScalar());
                    }
                    else 
                    {
                        Console.WriteLine("error inserting into city");
                        return 0; 
                    }
                } 
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 4: " + ex.Message);
                    return 0;
                }
            }
        }

        private static int CreateAddress(string address, string address2, int cityId, string postalCode, string phone)
        {
            string query =
                "USE client_schedule; " +
                "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES (@address, @address2, @cityId, @postalCode, @phone, NOW(), 'user', NOW(), 'user');";
            using (MySqlCommand com = new MySqlCommand(query, connection))
            {
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@address2", address2);
                com.Parameters.AddWithValue("@cityId", cityId);
                com.Parameters.AddWithValue("@postalCode", postalCode);
                com.Parameters.AddWithValue("@phone", phone);

                try
                {
                    if (com.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("created address");
                        com.CommandText =
                            $"USE client_schedule; " +
                            $"SELECT addressId " +
                            $"FROM address " +
                            $"WHERE cityId = {cityId};";
                        //Console.WriteLine("grabbing address id");
                        return Convert.ToInt32(com.ExecuteScalar());
                    }
                    else
                    {
                        Console.WriteLine("error creating address");
                        return 0;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("sql error 7: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}
