using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectINClass
{
    public class SwapNumber
    {
        public void SWAPPING()
        {
            Console.WriteLine("Enter the value of x and y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("after swap " + x + "" + y);

        }
    }
}
