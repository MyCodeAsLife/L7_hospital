using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesInAnHour = 60;
            int minutesForAppointment = 10;
            int peopleInLine;
            int hoursOfWaiting;
            int minutesOfWaiting;
            int totalMinutes;

            Console.Write("Введите количество старушек: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            totalMinutes = peopleInLine * minutesForAppointment;
            hoursOfWaiting = totalMinutes / minutesInAnHour;
            minutesOfWaiting = totalMinutes % minutesInAnHour;

            Console.Write($"Вы должны отстоять в очереди {hoursOfWaiting} час(а/ов) и {minutesOfWaiting} минут(у/ы).\n");
        }
    }
}
