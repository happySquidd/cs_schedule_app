using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleApp.model
{
    internal class Reports
    {
        // lambda that is assigned to a Func delegate, taking in int of month index and a string of type, outputting a string
        // this lambda will output a string which will calculate the amount of appointments of a single type a user has in a specific month
        public static Func<int, string, string> getMonthReport = (monthIdx, type) =>
        {
            string title = "Number of appointments for the selected month of this type: ";
            int total = 0;


            if (string.IsNullOrEmpty(type) || monthIdx == -1)
            {
                return title + total.ToString();
            }

            foreach (Appointment appointment in Appointment.allAppointments)
            {
                int appMonth = Convert.ToDateTime(appointment.start).Month;
                if ((monthIdx + 1) == appMonth)
                {
                    // month matches, check if type matches
                    if (type == appointment.type)
                    {
                        total++;
                    }
                }
            }
            return title + total.ToString();
        };

    }
}
