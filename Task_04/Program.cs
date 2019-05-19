using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_04
{

    /// Задача - дорабатываем будильник
    /// необходимо написать метод, который позволит считать, сколько времени осталось до того, как зазвонит будильник


    class Program
    {

        static void Main()
        {
            var wakeUp = DateTime.Now.AddSeconds(10);
            foreach (DateTime value in AlarmClockTimer(wakeUp))
            {

                Console.WriteLine((wakeUp - value).ToString(@"dd\.hh\:mm\:ss"));
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
        private static List<DateTime> AlarmClockTimer(DateTime wakeUp)
        {
            List<DateTime> listime = new List<DateTime>();
            DateTime dateTime = DateTime.Now;
            TimeSpan count = wakeUp.AddSeconds(1) - DateTime.Now;

            for (double i = 0; i < count.TotalSeconds; i++)
            {

                TimeSpan ttt = count - (dateTime.AddSeconds(i) - dateTime);
                listime.Add(wakeUp - ttt);
            }
            return listime;
        }
    }
}