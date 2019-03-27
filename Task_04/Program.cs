using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_04
{

    /// Задача - дорабатываем будильник
    /// необходимо написать метод, который позволит считать, сколько времени осталось до того, как зазвонит будильник


    class Program
    {
        
        static void Main(string[] args)
        {
            var wakeUp = DateTime.Now.AddSeconds(10);
            foreach (DateTime value in AlarmClockTimer(wakeUp))
            {

                Console.WriteLine((wakeUp - value).ToString(@"dd\.hh\:mm\:ss"));
                Thread.Sleep(1000);
            }
        }
    }
}
