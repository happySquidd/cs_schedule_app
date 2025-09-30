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
            Console.WriteLine("query for day: " + query);
            return DBconnection.GetAppointments(query);
        }

        public static BindingList<Appointment> DisplayWeek(MonthCalendar calendar)
        {
            DateTime selectedDate = calendar.SelectionStart.Date;
            Console.WriteLine("debug should be just date: "+ selectedDate);
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
            string query =
                // continuation of the query "WHERE userid = x AND"
                $"AND ap.start BETWEEN '{startDate}' AND '{endDate}'";
            Console.WriteLine("query for week: " + query);
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
            Console.WriteLine("query for month: " + query);
            return DBconnection.GetAppointments(query);
        }
        
        private static string ConvertDateFormat(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
