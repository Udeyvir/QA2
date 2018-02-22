using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        public static string Analyse(decimal side1, decimal side2, decimal side3)
        {
            if ((side1 == side2) && (side2 == side3))
            {
                Console.WriteLine("They form an equilateral triangle");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                /* If any two sides are equal */
                Console.WriteLine("They form an Isosceles triangle.");
            }
            else
            {               /* If none sides are equal */
                Console.WriteLine("They form an Scalene triangle.");
            }
            return ("You can't reach here!!! Savage");
        }
    }
}