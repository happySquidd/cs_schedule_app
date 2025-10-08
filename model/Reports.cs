using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduleApp.model
{
    internal class Reports
    {
        public static string GetMonthReport(int monthIdx, string type)
        {
            // uncomment returnText to see appointment names, and also switch to rich text box for output
            string title = "Number of appointments for the selected month of this type: ";
            //string returnText = "";
            int total = 0;


            if (string.IsNullOrEmpty(type) || monthIdx == -1)
            {
                return title + total.ToString();
            }

            foreach (Appointment appointment in Appointment.allAppointments)
            {
                int appMonth = Convert.ToDateTime(appointment.start).Month;
                if ((monthIdx+1) == appMonth)
                {
                    // month matches, check if type matches
                    if (type == appointment.type)
                    {
                        //returnText += appointment.title + "\n";
                        total++;
                    }
                }
            }
            return title + total.ToString();
        }
    }
}
