
using SnakeLadder;

namespace SnakeLadder
{
    class program
    {
        public static void Main(string[] args)
        {
            Dice Emp = new Dice();
            Emp.DiceRolling();
            int dICE = Emp.DiceRolling();
            Console.WriteLine("Its " + dICE);
            if (dICE == 6)
            {
                Console.WriteLine("You Rolled a 6 You get to move Forward");
                Console.WriteLine("Rolling again...... ");
                int N1 = Emp.DiceRolling();
                N1 += N1;
                Console.WriteLine(N1);
                switch ()
                {
                    case N1 = 4:
                         Console.WriteLine("Its a ladder" );
                        N1 = 14;
                        break;
                    case N1 = 9:
                         Console.WriteLine("Its a ladder");
                        N1 = 31;
                        break;
                    case N1 = 17:
                         Console.WriteLine("Its a ladder");
                        N1 = 7;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Keep Rolling Until 6 Apppears");

            }
        }
    }
}