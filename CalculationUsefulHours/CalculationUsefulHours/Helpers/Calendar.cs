using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationUsefulHours.Helpers
{
    public class Calendar
    {
        private readonly Dictionary<DateTime, DateTime> holidays;
        private readonly bool sundayHoliday;

        public Calendar(IEnumerable<DateTime> holidays = null, bool sundayHoliday = true)
        {
            holidays = holidays ?? new List<DateTime>();
            this.holidays = holidays.Distinct().Select(x => x.Date).ToDictionary(x => x);
            this.sundayHoliday = sundayHoliday;
        }

        public bool IsMinuteUseful(DateTime day, double extraTime)
        {
            if ((day.DayOfWeek == DayOfWeek.Sunday && sundayHoliday) || holidays.ContainsKey(day.Date))//Domingos y feriados
            {
                return false;
            }
            else if (day.DayOfWeek == DayOfWeek.Saturday)//Sábados
            {
                if (
                    (day.TimeOfDay > new TimeSpan(8, 30, 0) && day.TimeOfDay < new TimeSpan(16, 30, 0))
                    ||
                    ((day.TimeOfDay > new TimeSpan(8, 30, 0) && extraTime > 0) && (day.TimeOfDay <= new TimeSpan(16, 30, 0) && extraTime > 0))
                    )
                    return true;
                else
                    return false;
            }
            else//Días de Semana
            {
                if (
                    (day.TimeOfDay > new TimeSpan(7, 0, 0) && day.TimeOfDay < new TimeSpan(21, 0, 0))
                    ||
                    ((day.TimeOfDay > new TimeSpan(7, 0, 0) && extraTime > 0) && (day.TimeOfDay <= new TimeSpan(21, 0, 0) && extraTime > 0))
                    )
                    return true;
                else
                    return false;
            }
        }

        public int CalculateUsefulMinutes(DateTime from, DateTime to)
        {
            DateTime start = from.AddSeconds(-from.Second);//Eliminamos segundos
            DateTime end = to.AddSeconds(-to.Second);//Eliminamos segundos
            double usefulMinutesElapsed = 0;
            int totalMinutes = (int)Math.Floor(end.Subtract(start).TotalMinutes);

            for (double i = 0; i < totalMinutes; i++)
            {
                double extraTime = i + 1;
                var date_ = start.AddMinutes(extraTime);
                if (!IsMinuteUseful(date_, extraTime))
                {
                    continue;
                }
                usefulMinutesElapsed++;
            }

            return (int)usefulMinutesElapsed;
        }
    }
}