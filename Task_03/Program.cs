using System;
using System.Reflection;
using System.Collections.Generic;

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
            var myMethods = new Dictionary<ActionType, string>();
            myMethods[ActionType.Create] = "CreateMethod";
            myMethods[ActionType.Read] = "ReadMethod";
            myMethods[ActionType.Update] = "UpdateMethod";
            myMethods[ActionType.Delete] = "DeleteMethod";

            var type = ActionType.Read;
            if (myMethods.ContainsKey(type))
            {
                // Invoke methods
                var programType = Type.GetType("TaskThree.Program");
                if (programType == null) { throw new ArgumentNullException(); }
                var methodName = myMethods[type];
                var invokeMethod = programType.GetMethod(myMethods[type], BindingFlags.NonPublic | BindingFlags.Static);
                if (invokeMethod == null) { throw new ArgumentNullException(); }
                invokeMethod.Invoke(null, new object[] { type });
            } else { throw new ArgumentOutOfRangeException(); }
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