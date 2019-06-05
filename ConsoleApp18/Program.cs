using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class MainProgram
    {
        

        public static int ValidateUserInput(string trangleSide)
        {
            int number = 1;
            bool condition = false;

            while (condition == false)
            {
                Console.Write($"Please enter the {trangleSide} of your trangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again.\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Number must be greater then zero");
                }
                else if (number > 0)
                {
                    condition = true;
                    Console.WriteLine($"The {trangleSide} of your trangle is now {number}\n");

                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            bool validTriangle = false;
            
            

            while (validTriangle == false)
            {
               
                Console.WriteLine("1.Enter Dimensions of triangle");

                Console.WriteLine("2.Exit");
                string triSelection = Console.ReadLine();



                if (triSelection != "1" && triSelection != "2")
                {
                    Console.WriteLine("Invalid input,please try again");
                    Console.ReadLine();

                }

                    if ((int.Parse(triSelection)) == 1)
                    {

                        int firstside = 0;
                        int secondside = 0;
                        int thirdside = 0;

                        firstside = ValidateUserInput("firstside");
                        secondside = ValidateUserInput("secondside");
                        thirdside = ValidateUserInput("thirdside");

                        Console.WriteLine(TriangleSolver.Analyze(firstside, secondside, thirdside));


                    }
                    else if (int.Parse(triSelection) == 2)
                    {
                        validTriangle = true;


                    }
                

            }




        }

    }

}




