using Org.BouncyCastle.Crypto.Operators;
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
            DateTime selectedDate = calendar.SelectionStart;
            calendar.RemoveAllBoldedDates();
            int dayOfWeek = (int)selectedDate.DayOfWeek;
            string startOfWeek = selectedDate.AddDays(-dayOfWeek).ToString();
            DateTime tempDate = Convert.ToDateTime(startOfWeek);
            for (int i = 0;  i < 7; i++)
            {
                calendar.AddBoldedDate(tempDate.AddDays(i));
            }
            calendar.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dayOfWeek).ToString();
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
        
    }
}
