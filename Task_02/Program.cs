using System;

namespace TaskTwo
{


    /// Есть базовый класс с реалиазцией двух интерфейсов, имеющих одинаковый метод
    /// строка var @base = new Base(); - создаёт объект типа Base
    /// вызов @base.WriteExecutor()    - выводит на экран строку I base Executor!
    ///
    /// Дополните код так, чтобы не создавая новый объект на экран было выведено
    ///
    /// I base Executor!
    /// I one Executor!
    /// I two Executor!

    public interface IOneExecutor
    {
        void WriteExecutor();
    }

    interface ITwoExecutor
    {
        void WriteExecutor();
    }

    class Base : IOneExecutor, ITwoExecutor
    {
        public void WriteExecutor()
        {
            Console.WriteLine("I base Executor!");
        }
        void IOneExecutor.WriteExecutor()
        {
            Console.WriteLine("I one Executor!");
        }
        void ITwoExecutor.WriteExecutor()
        {
            Console.WriteLine("I two Executor!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var @base = new Base();
            @base.WriteExecutor();
            IOneExecutor @baseOne = new Base();
            @baseOne.WriteExecutor();
            ITwoExecutor @baseTwo = new Base();
            @baseTwo.WriteExecutor();
        }
    }
}
