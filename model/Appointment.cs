using scheduleApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleApp.model
{
    public class Appointment
    {
        public static BindingList<Appointment> allAppointments = DBconnection.GetAppointments();
        public static List<string> types = new List<string>() { "Onboarding", "Advising", "Questions", "Presentation", "Scrum"};

        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string createDate { get; set; }
        public string createdBy { get; set; }
        public string lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        // additional info 
        public string customerName { get; set; }
        public string phone { get; set; }

    }
}
