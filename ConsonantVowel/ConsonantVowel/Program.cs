using System;

namespace ConsonantVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " Is a Vowel");
            }
            else 
            {
                Console.WriteLine(ch + " Is Consonant.");
            }

            Console.ReadLine();
        }
    }
}
