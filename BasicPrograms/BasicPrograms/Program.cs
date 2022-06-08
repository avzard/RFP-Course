namespace BasicPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.\n");
            Console.WriteLine("1 for Flip Coin ");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for Powee of Two");
            Console.WriteLine("4 for Harmonic Number");
            Console.WriteLine("5 for Factors");
            Console.WriteLine("6 for Quotent Remainder");
            Console.WriteLine("7 For Even Odd");
            Console.WriteLine("8 For Swap two Number");
            Console.WriteLine("9 Largest Of 3 Numbers");
            Console.WriteLine("10 Vowel or Consonant");
            int Problem = Convert.ToInt32(Console.ReadLine());
               switch(Problem)
            {
                case 1:
                    Flipcoin flipCoin = new Flipcoin();
                    flipCoin.Flipcoin_Percentage();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Leap_Year();
                    break;
                case 3:
                    Power2 power = new Power2();
                    power.Power_OF_TWO();
                    break;
                case 4:
                    Harmonic harmonic = new Harmonic();
                    harmonic.Harmonicz();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.Factorz();
                    break;
                case 6:
                    QuotentRemainder QandR = new QuotentRemainder();
                    QandR.QuotentRemainderr();
                    break;
                case 7:
                    EvenOdd EvOd = new EvenOdd();
                    EvOd.EVENODD();
                    break;
                case 8:
                    SwaptwoNO Swap = new SwaptwoNO();
                    Swap.SWAP();
                    break;
                case 9:
                    Largestof3 Large3 = new Largestof3();
                    Large3.LARGE3();
                    break;
                case 10:
                    VowelorConsonant VOCO = new VowelorConsonant();
                    VOCO.VOWELCONSONANT();
                    break;




            }

               
        }
    }
}