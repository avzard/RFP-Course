using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWORKUC
{
    internal class EmployeeWage
    {
        public const float EmpwagePerHr = 20;
        public const float Fulltime_WorkingHrs_PerDay = 8;
        public const float Fulltime_WorkingHours_PerDay = 10;
        public const float IS_FULL_TIME = 1;
        public const float IS_PART_TIME = 2;
        public const float IS_ABSENT = 0;
        public const float Num_WorkingDays_PerMonth = 20;
        public float EmpMonthlyWage = 0;
        float EmpDailyyWage = 0;

        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;
        }
        public void CalculateWage()
        {
            
        }
    }
}
