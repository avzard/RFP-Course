namespace BasicPrograms
{
    internal class Power2
    {
        public void Power_OF_TWO()
        {
            Console.WriteLine("Please enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            while(Number <0 || Number >=31)
            {
                Console.WriteLine("Please enter a valid Number: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =1;i == Number;i++)
            {
                Console.WriteLine(Math.Pow(2,i));

            }
        }
    }
}