using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_04
{

    /// Задача - дорабатываем будильник
    /// необходимо написать метод, который позволит считать, сколько времени осталось до того, как зазвонит будильник


    class Program
    {
        static List<DateTime> AlarmClockTimer(DateTime wakeUp)
        {
            List<DateTime> dates = new List<DateTime>();
            int timeShift = Convert.ToInt32((wakeUp - DateTime.Now).TotalSeconds);
            for(int i = timeShift; i > 0; i--)
            {
                DateTime date = wakeUp.AddSeconds(-i);
                dates.Add(date);
            }
            return dates;
        }

        static void Main(string[] args)
        {
            int AnySec = 10;
            var wakeUp = DateTime.Now.AddSeconds(AnySec);
            foreach (DateTime value in AlarmClockTimer(wakeUp))
            {

                Console.WriteLine((wakeUp - value).ToString(@"dd\.hh\:mm\:ss"));
                Thread.Sleep(1000);
            }
        }
    }
}
