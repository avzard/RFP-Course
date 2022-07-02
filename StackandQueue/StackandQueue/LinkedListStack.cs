using System;
using System.Collections.Generic;
using System.Text;

namespace StacksandQueues
{
    class LinkedListStack
    {
        public Node top;

        public LinkedListStack()
        {
            top = null;
        }
        public void push(int value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;

        }
        internal void peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty...");
            }
            Console.WriteLine("\nTop Most Element in Stack : " + top.data);
        }

        internal void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty... ");
            }
            Console.WriteLine("Deleted Element : " + top.data);
            top = top.next;
        }
        internal void isEmpty()
        {
            while (top != null)
            {
                peek();
                pop();
            }
            Console.WriteLine("Stack is Empty...");
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
        }
    }
}