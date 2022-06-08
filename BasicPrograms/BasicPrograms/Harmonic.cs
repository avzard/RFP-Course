namespace BasicPrograms
{
    internal class Harmonic
    {
        public void Harmonicz()
        {
            float Resut_Harmonic = 0;
            Console.WriteLine("Enter the value of N for Nth Harmonic");
            int N = Convert.ToInt32(Console.ReadLine());    
            while(N == 0)
            {
                Console.WriteLine("Enter the valid input");
                N = Convert.ToInt32(Console.ReadLine());
            }
            for(float i = 1; i <= N; i++)
            {
                Resut_Harmonic += 1;
            }
            Console.WriteLine(Resut_Harmonic);
            
        }
    }
}