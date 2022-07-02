﻿using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Problems");
            Console.WriteLine("Enter Option");
            Console.WriteLine("1.Permutations_String");
            Console.WriteLine("2.BinarySearchFile");
            Console.WriteLine("3.InsertionSort");
            Console.WriteLine("4.BubbleSort");
            Console.WriteLine("5.MergeSort");
            Console.WriteLine("6.Anagram");
            Console.WriteLine("7.PrimeNumbers");
            Console.WriteLine("8.Regex");

            int Option = int.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Please Enter Perm_string: ");
                    String str = Console.ReadLine();
                    int n = str.Length;
                    permutations_String.permute(str, 0, n - 1);
                    break;
                case 2:
                    BinarySearchFile.Binarysearch();
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.insertion();
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.bubblesort();
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.mergesort();
                    break;
                case 6:
                    Anagrams anagram = new Anagrams();
                    anagram.anagrams();
                    break;
                case 7:
                    PrimeNumbersRange.primenumbers();
                    break;
                default:
                    Console.WriteLine("Please Enter valid option");
                    break;

            }
        }
    }
}
