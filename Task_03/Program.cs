using System;
using System.Reflection;

namespace TaskThree
{
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
            Dictionary<ActionType, method> methods = new Dictionary<ActionType, method>();
            methods.Add(ActionType.Create, CreateMethod());
            methods.Add(ActionType.Read, ReadMethod());
            methods.Add(ActionType.Update, UpdateMethod());
            methods.Add(ActionType.Delete, DeleteMethod());


            var type = ActionType.Read;
            if (methods= methods.find(type) != end) {
                methods.calls(type);
            } else {
                throw new ArgumentOutOfRangeException();

            }


            /*
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
            */
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