using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Linked_List
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted Into LinkedList", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node insertedAtParticular(int position ,int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid ");
            if (position ==1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if(position ==1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if(position != 1)
                {
                    Console.WriteLine("It Is out of range");
                }
                return head;
            }

        }
    }
}
