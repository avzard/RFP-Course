using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder2
{
    internal class Dice
    {
        public int DiceRolling()
        {
            Console.WriteLine("Rolling The Dice.....");
            Random Dice = new Random();
            int RunningNum = Dice.Next(1, 7);
            return RunningNum;
            
            /*if (RunningNum == 6)
            {
                Console.WriteLine("Dice Rolled "+ RunningNum);
                Console.WriteLine("Rolling again to move Forward");   
            }
            else
            {
                Console.WriteLine("Keep Rolling Untill 6 is Rolled");
                //DiceRolling();
            }*/
            
        }
    }
}
