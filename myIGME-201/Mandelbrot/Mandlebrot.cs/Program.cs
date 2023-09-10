using System;
using System.Net;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;


            //imaginary numbers
            //takes in user input to create a new max and min for imageCoord to itterate through
            Console.WriteLine("Enter the new parameters for the Imaginary Coordinate loop, the larger value should be entered first.");
            //parses user input to doubles
            double imagMax = Double.Parse(Console.ReadLine());
            double imagMin = Double.Parse(Console.ReadLine());

            //makes sure that user inputs values in the correct order
            while (imagMin >= imagMax)
            {
                Console.WriteLine("The first value must be greater than the second.");
                imagMax = Double.Parse(Console.ReadLine());
                imagMin = Double.Parse(Console.ReadLine());
            }

            //calculates the amount to incriment by
            double imagInc = (imagMax - imagMin) / 48;


            //real numbers
            //takes in user input to create a new max and min for realCoord to itterate through
            Console.WriteLine("Enter the new parameters for the Real Coordinate loop, the larger value should be entered first.");
            //parses user input to doubles
            double realMax = Double.Parse(Console.ReadLine());
            double realMin = Double.Parse(Console.ReadLine());

            //makes sure that user inputs values in the correct order
            while (realMin >= realMax)
            {
                Console.WriteLine("The first value must be greater than the second.");
                realMax = Double.Parse(Console.ReadLine());
                realMin = Double.Parse(Console.ReadLine());
            }

            //calculates the amount to incriment by
            double realInc = (realMin - imagMin) / 80;

            //loop based on user input
            for (imagCoord = imagMax; imagCoord >= imagMin; imagCoord -= imagInc)
            {
                //loop based on user input
                for (realCoord = realMin; realCoord <= realMax; realCoord += realInc)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}

