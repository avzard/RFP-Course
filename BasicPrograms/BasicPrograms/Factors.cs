namespace BasicPrograms
{
    internal class Factors
    {
        public void Factorz()
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors for {0} are,",Number);
            for(int i = 2;i * i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}