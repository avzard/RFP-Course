﻿namespace DataStructure
{
    public class program
    {
        public static void Main(String[] args)
        {
            LinkedLists Link = new LinkedLists();
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);

            Link.AddNode(node1);
            Link.AddNode(node2);
            Link.AddNode(node3);
            Link.Display();
            Link.DeleteAtFirst();

        }
        

    }
}