using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//USING IF ELSE LOOPS 
namespace BasicProgram
{
    internal class EmployeeWagee
    {

        public int EmpPresent = 2;
        public int Wge_Per_Hour = 20;
        public int Full_Day_Hour = 8;
        public int Partime_hour = 4;
        public int Full_Time = 1;
        public int Daily_wage = 0;

        // public int DaiyWage { get; private set; }

        // checking functionality===method 

        public void CheckEmpPresentAbsent()
        {
            Random EmpCheck = new Random();
            int Value = EmpCheck.Next(0, 2);
            if (Value == EmpPresent)
            {
                Random TimeCheck = new Random();
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == Full_Time)
                {
                    Daily_wage = Wge_Per_Hour * Full_Day_Hour;
                    Console.WriteLine("Employee is Present  " + Daily_wage);
                }
                else
                {
                    Daily_wage = Wge_Per_Hour * Partime_hour;
                    Console.WriteLine("Employee is Present for PartTime" + Daily_wage);
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
