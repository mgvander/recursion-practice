using System;

namespace cis237_inclass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factorial or 2 for Tower of Hanoi");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Make Factorial Class
                Factorial factorial = new Factorial();

                Console.WriteLine("Solve 5!");
                Console.Write("The answer is: ");
                Console.WriteLine(factorial.Solve(5));

                // What happens when we do 33!
                //Console.WriteLine("Solve 33!");
                //Console.Write("The answer is: ");
                //Console.WriteLine(factorial.SolveFactorial(33));

                // 33 is large enough to cause an overflow while calculating
                
            }
            else
            {
                // Do Tower of Hanoi
                TowerOFHanoi hanoi = new TowerOFHanoi();
                hanoi.Solve();

            }

        }

    }

}
