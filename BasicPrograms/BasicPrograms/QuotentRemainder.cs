namespace BasicPrograms
{
    internal class QuotentRemainder
    {
        public void QuotentRemainderr()
        {
            Console.WriteLine("Enter Number one");
            int dividend=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number two");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }

       
    }
}