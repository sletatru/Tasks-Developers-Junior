using System;
using System.Threading;

namespace myTread
{
    class Program
    {
        static int x = 0;
        static object locker = new object(); // создаем объект-заглушку
        static void Main(string[] args)
        {   /*
            //как запускать в отдельных потоках методы без параметров
            //Thread someThread = new Thread(new ThreadStart(Count)); // создаем новый поток

            //запускать в отдельных потоках методы с параметрами.
            Counter numbers = new Counter();
            numbers.x = 4;
            numbers.y = 5;
            Thread someThread = new Thread(new ParameterizedThreadStart(Count));
            someThread.Start(numbers); // запускаем поток
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(numbers.x + numbers.y);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
            */
            for (int i = 0; i < 5; i++)
            {
                Thread someThread = new Thread(Count);
                someThread.Name = "Поток " + i.ToString();
                someThread.Start();
            }
            Console.ReadLine();

        }
        /*
        public static void Count(object x) //метод, который в качестве единственного параметра принимает объект типа object.
        {
                for (int i = 1; i < 9; i++)
                {
                    Counter n = (Counter)x; //привести переданное значение к типу int
                    Console.WriteLine("Второй поток:");
                    Console.WriteLine(n.x);
                    Console.WriteLine(n.y);
                    Thread.Sleep(1000);
                }
        }
        public class Counter
        {
            public int x;
            public int y;
        }
        */
        public static void Count()
        {
            lock(locker) //выполняются потоки поочередно
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
