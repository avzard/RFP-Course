using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaLearningProblem
{
    internal class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string sSN, string name, string address, int age)
        {
            SSN = sSN;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
