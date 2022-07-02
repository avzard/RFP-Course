using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaLearningProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            listPersonInCity.Add(new Person("20508091", "Abhishek", "Krishna Kunj", 23));
            listPersonInCity.Add(new Person("20508092", "Rahul", "Rasal Park", 66));
            listPersonInCity.Add(new Person("20508093", "Jayesh", "Panvelkar", 30));
            listPersonInCity.Add(new Person("20508094", "Omkar", "Green City", 80));
            listPersonInCity.Add(new Person("20508095", "SAM", "Green City", 55));
            listPersonInCity.Add(new Person("20508096", "Raju", "Pink City", 60));



            Console.WriteLine("Retrieving Top 2 aged Person from the list who are older than 60 years \n");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
            Console.WriteLine("\nChecking whether any person is teen-ager or not ...");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
            Console.WriteLine("\nGetting Average of all the person's age ...");
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is:" + avgAge);
            Console.WriteLine("\nChecking whetheraperson having name'SAM'exists or not ...");
            if (listPersonInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine("Yes,Aperson having name'SAM'exists in our list");
            }
                
            Console.WriteLine("\nSkipping every person whose age is less than 60 years ...");
            foreach (Person person in listPersonInCity.FindAll(e => e.Age < 60))
            {
                Console.WriteLine("Name" + person.Name + "\t\tAge:" +person.Age);
            }
            Console.WriteLine("\nRemove Specific From list.");
            listPersonInCity.RemoveAll(e => (e.Name == "SAM"));
            if (listPersonInCity.TrueForAll(e => e.Name != "SAM"))
            {
                Console.WriteLine("No person is in list having name as SAM");
            }
        }
    } 
}
