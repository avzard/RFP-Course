﻿using System;

namespace BinarySearchTree_BST_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Binary_Search_Tree***");
            MyBinaryNode<int> binarySearchTree = new MyBinaryNode<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            binarySearchTree.Size();
            bool findElement = binarySearchTree.ifExists(63, binarySearchTree);
            Console.ReadKey();
        }
    }
}