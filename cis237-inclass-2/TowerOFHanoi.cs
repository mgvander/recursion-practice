using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_2
{
    internal class TowerOFHanoi
    {
        public void Solve()
        {
            Console.WriteLine("Enter a number of discs to use (less than 5 is good)");
            Console.Write("=> ");

            string input = Console.ReadLine();
            int discNumber = Int32.Parse(input);

            MoveDisc(discNumber, 'A', 'B', 'C');

        }

        private void MoveDisc(int num, char start, char ignore, char destination)
        {
            // This is the base case. Nothing to move beyond one disc.
            if (num == 1)
            {
                Console.WriteLine("Move disc from tower {0} to tower {1}.", start, destination);
            
            }
            else
            {
                // Make a recursive call to move n-1 discs from the starting peg to the ignored peg            
                MoveDisc(num - 1, start, destination, ignore);

                // Make a recursive call to move the largest disc from the start to the destination.
                // This will cause the base case to be enacted.
                // Remember that this works because each disc, at some number of discs, can be considered the largest at that number of discs.
                MoveDisc(1, start, ignore, destination);

                // Make a recursive call to move n-1 disc from the ignored peg to the destinaton.
                MoveDisc(num - 1, ignore, start, destination);

            }

        }

    }

}
