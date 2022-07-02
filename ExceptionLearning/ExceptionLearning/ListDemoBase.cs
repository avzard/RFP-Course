using System;
using System.Collections.Generic;

namespace Collections
{
    public class ListDemoBase
    {
        private void dolistDemo()
        {
            Console.WriteLine("\nIn dolistDemo");
            // Creating List
            List<string> list = new List<string>();
            // Adding object to the list
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            // Iterating list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}