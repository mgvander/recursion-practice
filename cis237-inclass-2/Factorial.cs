using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_2
{
    internal class Factorial
    {
        // Recursion is solving a problem by finding solution to a smaller version of the same problem.
        // We know that 5! can be represented as 5 * 4!
        // We also know that 4! can be represented as 4 * 3!

        // Recursive method to solve Factorial
        public int SolveFactorial(int number)
        {
            // We need a base case
            // If we don't stop recursing, bad things will happen.
            // Such as a StackOverflow.
            if (number == 1)
            {
                return number;
            }

            // If we are not at the base case, recurse to find solution.
            return number * SolveFactorial(number - 1);

            //int recursiveResult = SolveFactorial(number - 1);
            //int result = number * recursiveResult;
            //return result;
        }
    }
}
