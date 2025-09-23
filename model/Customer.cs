using MySql.Data.MySqlClient;
using scheduleApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleApp.model
{
    public class Customer
    {
        public static BindingList<Customer> allCustomers = DBconnection.getCustomers();

        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public int active { get; set; }
        public string createdDate { get; set; }
        public string createdBy { get; set; }
        public string lastUpdated { get; set; }
        public string lastUpdatedBy { get; set; }

        // additional info
       
    }
}
