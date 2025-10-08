using Org.BouncyCastle.Crypto.Operators;
using scheduleApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.model
{
    internal class Calendar
    {
        public static BindingList<Appointment> DisplayDay(MonthCalendar calendar)
        {
            DateTime selectedDate = calendar.SelectionStart;
            calendar.RemoveAllBoldedDates();
            calendar.AddBoldedDate(selectedDate);
            calendar.UpdateBoldedDates();

            string startDate = ConvertDateFormat(selectedDate.Date);
            string endDate = ConvertDateFormat(selectedDate.AddDays(1).Date);
            // continuation of the query "WHERE userid = x AND"
            string query = $"AND ap.start BETWEEN '{startDate}' AND '{endDate}'";
            //Console.WriteLine("query for day: " + query);
            return DBconnection.GetAppointments(query);
        }

        public static BindingList<Appointment> DisplayWeek(MonthCalendar calendar)
        {
            DateTime selectedDate = calendar.SelectionStart.Date;
            calendar.RemoveAllBoldedDates();
            int dayOfWeek = (int)selectedDate.DayOfWeek;
            string startOfWeek = selectedDate.AddDays(-dayOfWeek).ToString();
            DateTime tempStartDate = Convert.ToDateTime(startOfWeek);
            for (int i = 0;  i < 7; i++)
            {
                calendar.AddBoldedDate(tempStartDate.AddDays(i));
            }
            calendar.UpdateBoldedDates();
            string startDate = ConvertDateFormat(tempStartDate.Date);
            string endDate = ConvertDateFormat(selectedDate.AddDays(7 - dayOfWeek).Date);
            // continuation of the query "WHERE userid = x AND"
            string query = $"AND ap.start BETWEEN '{startDate}' AND '{endDate}'";
            //Console.WriteLine("query for week: " + query);
            return DBconnection.GetAppointments(query);
        }

        public static BindingList<Appointment> DisplayMonth(MonthCalendar calendar)
        {
            DateTime selectedDate = calendar.SelectionStart.Date;
            calendar.RemoveAllBoldedDates();
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            int days;
            string startDate = month.ToString() + "/01/" + year.ToString();
            DateTime tempStartDate = Convert.ToDateTime(startDate);
            switch (month)
            {
                case 2:
                    // february
                    days = 29;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 31;
                    break;
            }
            for (int i = 0; i < days; i++)
            {
                calendar.AddBoldedDate(tempStartDate.AddDays(i));
            }
            calendar.UpdateBoldedDates();

            DateTime endDate = tempStartDate.AddDays(days);
            string queryStartDate = ConvertDateFormat(tempStartDate.Date);
            string queryEndDate = ConvertDateFormat(endDate.Date);
            // continuation of the query "WHERE userid = x AND"
            string query =  $"AND ap.start BETWEEN '{queryStartDate}' AND '{queryEndDate}'";
            //Console.WriteLine("query for month: " + query);
            return DBconnection.GetAppointments(query);
        }
        
        // converts DateTime format to the database format of year first
        private static string ConvertDateFormat(DateTime date)
        {
            // since the displayed time is converted to local time, this next line helps convert the time back to UTC for the database.
            // this prevents edge cases such as if utc is -4 (the displayed time in the data grid is 4 hours behind the time in the databse),
            // the displayed days can be off by one if the time is near midnight. This basically esnures the readable time is correlated to the databse time
            // by converting it to utc before sending the query and when displying it converts it back into local time. so if we see day 27,
            // it might be day 26 at night in the database, and if we select day 27 expecting to see it we would see it there but we would see the day 27 on the 26th
            // this solves that issue.
            date = TimeZoneInfo.ConvertTimeToUtc(date.Date);
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
