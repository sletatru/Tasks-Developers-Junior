using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TaskOne
{

    /// задача №1
    /// необходимо просуммировать все найденные числа
    /// исправить потенциальную ошибку
    ///
    /// задачу необходимо реализовать, дописав код, чтобы data.GetDigits() стал работоспособным

    class Program
    {

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static List<byte> GetDigits(string data)
        {
            List<byte> digits = new List<byte>();
            foreach (char item in data)
            {
                if (char.IsDigit(item))
                {
                    digits.Add(Convert.ToByte( item.ToString() ));
                    // digits.Add((byte)(item - 48));
                }
            }
            return digits;
        }

        static void Main(string[] args)
        {
            string data = RandomString(5);
            byte summary = 0;
            foreach (byte digit in GetDigits(data))
            {
                summary += digit;
            }

            Console.WriteLine($"{data} => {summary}");

          
        }
    }
}
