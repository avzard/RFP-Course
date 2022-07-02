using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedLists
    {
        public Node Head;
        public Node Tail;

        public LinkedLists()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is Empty ");
            else
                Console.WriteLine("Linked List");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                if (temp.next != null)
                {
                    Console.WriteLine("-->");
                }
                temp = temp.next;
            }

        }
        public void Append(Node node)
        {
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Tail;
                Tail = node;
            }
        }
        public void DeleteAtFirst()
        {
            if(this.Head == null)
            {
                Console.WriteLine("Nothing to Delete List is Empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("Removed From Linked List: " + temp.data);
        }
    }
}