using System;

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

    class Program
    {
        static void Main(string[] args)
        {
            var type = ActionType.Read;

            switch (type)
            {
                case ActionType.Create:
                    CreateMethod(type);
                    break;
                case ActionType.Read:
                    ReadMethod(type);
                    break;
                case ActionType.Update:
                    UpdateMethod(type);
                    break;
                case ActionType.Delete:
                    DeleteMethod(type);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
