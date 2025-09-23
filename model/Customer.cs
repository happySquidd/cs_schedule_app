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

        // customer info
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public int active { get; set; }
        public string createdDate { get; set; }
        public string createdBy { get; set; }
        public string lastUpdated { get; set; }
        public string lastUpdatedBy { get; set; }

        // address info
        public string address {  get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public string addressCreatedDate { get; set; }
        public string addressCreatedBy { get; set; }
        public string addressLastUpdated { get; set; }
        public string addressLastUpdatedBy { get; set; }

        // city info 
        public string city { get; set; }
        public int countryId { get; set; }
        public string cityCreatedDate { get; set; }
        public string cityCreatedBy { get; set; }
        public string cityLastUpdatedDate { get; set; }
        public string cityLastUpdatedBy { get; set; }

        // country info 
        public string country { get; set; }
        public string countryCreatedDate { get; set; }
        public string countryCreatedBy { get; set; }
        public string countryLastUpdatedDate { get; set; }
        public string countryLastUpdatedBy { get; set; }


    }
}
