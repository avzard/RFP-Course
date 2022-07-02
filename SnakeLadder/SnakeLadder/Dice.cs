using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Dice
    {
        public int DiceRolling()
        {
            Console.WriteLine("Rolling The Dice.....");
            Random Dice =  new Random();
            int RunningNum = Dice.Next(1, 7);
            
            return RunningNum;
        }
        public int MovingAhed()
        {
            return DiceRolling();
            int N1 = Emp.DiceRolling();
            for (int i = 0; i < N1; i++)
            {
                Console.WriteLine("a");
            }
        }


    }
}
