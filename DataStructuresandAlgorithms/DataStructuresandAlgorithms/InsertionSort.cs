﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        public void insertion()
        {
            Console.WriteLine("enter the string array length");
            int n = Utility.IntegerInput();
            string[] str = new string[n];
            //string[] temp;
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("enter the arrayelements into str[" + i + "]:");
                str[i] = Utility.usersinput();
            }
            Utility.arraysorting(str, n);
            Console.WriteLine("InsertionSort");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);

            }
        }
    }
}