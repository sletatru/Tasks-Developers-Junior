using System;
using System.Collections.Generic;

namespace TaskThree
{

    /// Задача - перепишите данный код так, чтобы он работал через коллекции C#, вместо конструкции switch


    public enum ActionType
    {
        Create,

        Read,

        Update,

        Delete

    }

    delegate void Test(ActionType type);

    class Program
    {
        static void Main()
        {
            var type = ActionType.Read;

            Test t1 = CreateMethod;
            Test t2 = ReadMethod;
            Test t3 = UpdateMethod;
            Test t4 = DeleteMethod;

            List<Test> L1 = new List<Test>
            {
                t1,
                t2,
                t3,
                t4
            };

            L1[(int)type](type);

            Console.ReadKey();
        }

        private static void CreateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void ReadMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void UpdateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void DeleteMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }
    }
}