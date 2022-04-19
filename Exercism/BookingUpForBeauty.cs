using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    static class BookingUpForBeauty
    {
        
        public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);


        public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;
        

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            var startOfAfternoon = new TimeSpan(12, 0, 0);
            var endOfAfternoon = new TimeSpan(18, 0, 0);

            if (appointmentDate.TimeOfDay >= startOfAfternoon && appointmentDate.TimeOfDay < endOfAfternoon) return true;
            else return false;
        }

        public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString("G")}";


        public static DateTime AnniversaryDate() => new DateTime(2022, 9, 15, 0, 0, 0);
        
    }
}
