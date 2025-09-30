using Org.BouncyCastle.Crypto.Operators;
using scheduleApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.model
{
    internal class Calendar
    {
        private static DateTime currentDate = DateTime.Now;
        public static void DisplayDay(MonthCalendar calendar)
        {
            DateTime selectedDate = calendar.SelectionStart;
            calendar.RemoveAllBoldedDates();
            calendar.AddBoldedDate(selectedDate);
            calendar.UpdateBoldedDates();
        }

        public static void DisplayWeek(MonthCalendar calendar)
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
            string endDate = ConvertDateFormat(currentDate.AddDays(7 - dayOfWeek).Date);
            string query =
                // continuation of the query "WHERE userid = x AND"
                $"AND ap.start BETWEEN '{startDate}' " +
                $"AND '{endDate}'";
            DBconnection.GetAppointments(query);
        }

        public static void DisplayMonth(MonthCalendar calendar)
        {
            DateTime selectedDate = calendar.SelectionStart;
            calendar.RemoveAllBoldedDates();
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            int days;
            string startDate = month.ToString() + "/01/" + year.ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            switch (month)
            {
                case 2:
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
                calendar.AddBoldedDate(tempDate.AddDays(i));
            }
            calendar.UpdateBoldedDates();
            string endDate = month.ToString() + "/" + days.ToString() + "/" + year.ToString();
        }
        
        private static string ConvertDateFormat(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
