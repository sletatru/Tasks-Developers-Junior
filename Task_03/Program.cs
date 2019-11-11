using System;

namespace TaskThree
{
    public abstract class CRUDAction
    {
        public virtual void ActionType()
        {
            Console.WriteLine("crud action");
        }
    }
    class Create : CRUDAction
    {
        public override void ActionType()
        {
            Console.WriteLine("create");
        }
    }
    class Read : CRUDAction
    {
        public override void ActionType()
        {
            Console.WriteLine("read");
        }
    }
    class Update : CRUDAction
    {
        public override void ActionType()
        {
            Console.WriteLine("update");
        }
    }
    class Delete : CRUDAction
    {
        public override void ActionType()
        {
            Console.WriteLine("delete");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Read ReadType = new Read();
            ReadType.ActionType(); //вызов метода ActionType из class Read
        }
    }
}