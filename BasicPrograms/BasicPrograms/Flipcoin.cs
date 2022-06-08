namespace BasicPrograms
{
    internal class Flipcoin
    {
        public void Flipcoin_Percentage()
        {
            int Heads= 0;
            int Tails= 0;

            Console.WriteLine("Enter the Number of times you want to flip the coin:");
            int Number_of_Flips = Convert.ToInt32(Console.ReadLine());
            while (Number_of_Flips <=0)
            {
                Console.WriteLine("Invalid input,Plese Enter a number Greater than 0");
                Console.WriteLine("Please enter again: ");
                Number_of_Flips= Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<Number_of_Flips;i++)
            {
                Random flip = new Random();
                int Hot = flip.Next(0, 2);
                if (Hot<0.5)
                {
                    Heads++;
                }
                else
                {
                    Tails++;
                }

            }
            float Heads_Percent = (float)Heads * 100 / Number_of_Flips;
            float Tails_Percent = (float)(Tails * 100 / Number_of_Flips);

            Console.WriteLine(Heads_Percent + "% of the times the result was Heads");
            Console.WriteLine(Tails_Percent + "% of the times the result was Tails");

        }
    }
}