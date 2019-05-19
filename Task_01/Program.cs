using System;
using System.Linq;

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
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main()
        {
            string data = RandomString(5);
            byte summary = 0;

            foreach (byte digit in data.GetDigits())
            {
                summary += digit;
            }

            Console.WriteLine($"{data} => {summary}");
            Console.ReadKey();
        }



    }
    public static class StringExp
    {
        public static byte[] GetDigits(this string s)
        {

            int countbyte = 0;
            char[] archar = s.ToCharArray();
            byte[] arbyte = new byte[archar.Length];
            string[] arstring = new string[archar.Length];
            for (int i = 0; i < archar.Length; i++)
            {
                arstring[i] = archar[i].ToString();
            }
            for (int a = 0; a < arstring.Length; a++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (arstring[a] == i.ToString())
                    {
                        arbyte[countbyte] = byte.Parse(arstring[a]);
                        countbyte++;
                    }
                }

            }
            byte[] arbytetwo = new byte[countbyte];//Второй массив, длинной в количесво забитых значений, в отличие от предыдущего 
            for (int i = 0; i < countbyte; i++)
                arbytetwo[i] = arbyte[i];
            return arbytetwo;
        }
    }

}