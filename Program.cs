using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 0.0;
            Console.Write("Enter a score: ");
            score = Convert.ToDouble(Console.ReadLine());
            if (score >= 80.0)
                Console.WriteLine("You earned an A!");
            else if (score >= 80.0)
                Console.WriteLine("You earned a B");
            else if (score >= 70.0)
                Console.WriteLine("You earned a C");
            else if (score >= 60.0)
                Console.WriteLine("You earned a D");
            else
                Console.WriteLine("Why did you get an F?");            
        }
    }
}