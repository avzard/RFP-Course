namespace GenricsLearningProblem
{
    public class program<T>
    {
        private T[] ArrayList;
        public program(T[] ArrayList)
        {
            this.ArrayList = ArrayList;
        }

        public void toPrint()
        {
            foreach (var element in ArrayList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------");
        }
    }
    class ArrayList
    {

        
        //public void PrintArray()
        //{
        //    foreach(var element in intArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, };
            double[] doublearray = { 1.2, 1.3, 1.5, 1.6 };
            char[] chararray = { 'a', 'b', 'c', 'd', 'e' };
            new program<int>(intArray).toPrint();
            new program<double>(doublearray).toPrint();
            new program<char>(chararray).toPrint(); 

        }
    }
    


}