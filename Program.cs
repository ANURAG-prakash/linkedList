using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Linked_List list = new Linked_List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertedAtParticular(2, 30);
            list.RemoveFirstNode();
            list.RemoveLastNode();
            list.Search(40);
            


        }
    }
}
