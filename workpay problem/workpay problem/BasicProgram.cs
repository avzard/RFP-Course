using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workpay_problem
{
    internal class BasicProgram
    {
        public const float EmpWagePerHour = 20;
        public const int Fulltime_Working_PerDay = 8;
        public const int Parttime_Working_PerDay = 4;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;
        public int Num_WorkingDaysPerMONTH = 20;

        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;
        }

        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            while(DayNumber <= Num_WorkingDaysPerMONTH)
            {
                switch(IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkingHrs = Parttime_Working_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs = Fulltime_Working_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * EmpWagePerHour;
                TotalWage += EmpDailyWage;
                DayNumber++;
                
            }
            Console.WriteLine("Employee monthly wage:" + TotalWage);
        }

    }


}














    

