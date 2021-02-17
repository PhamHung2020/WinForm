using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlan
{
    public static class DateTimeExtension
    {
        public static int DaysOfMonth(this DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (date.Month % 4 == 0 && date.Month % 100 != 0 || date.Month % 400 == 0)
                    {
                        return 29;
                    }
                    return 28;
                default:
                    return 30;
            }
        }

        public static bool IsEqualDate(this DateTime date1, DateTime date2)
        {
            return (date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year);
        }
    }
}
