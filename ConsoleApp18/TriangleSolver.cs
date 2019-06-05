using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public static class TriangleSolver
    {
        public static int firstside;
        public static int secondside;
        public static int thirdside;
        public static string output = "";



        public static string Analyze(int firstside, int secondside, int thirdside)
        {
           

       
            if (firstside + secondside > thirdside && firstside + thirdside > secondside && thirdside + secondside > firstside)
            {
              

                {
                    if (firstside == secondside && thirdside == secondside && thirdside == firstside)
                    {

                        output = "equilateral";
                    }
                    else if
                        (firstside == secondside || secondside == thirdside || thirdside == firstside)
                    {
                        output = "isoceles";
                    }
                    else 
                    {
                        output = "scalene";
                    }
                }
            }
            else
            {
                Console.Write("Not a triangle\n ");
            }
            return output;
        }
    }
}
