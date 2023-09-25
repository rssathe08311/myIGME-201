using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MathQuiz
{
    static class Program
    {
        //timer initialization
        static Timer timeOutTimer;
        static bool bTimeOut = false;

        static void Main()
        {
            // store user name
            string myName = "";

            // string and int of # of questions
            string sQuestions = "";
            int nQuestions = 0;

            // string and base value related to difficulty
            string sDifficulty = "";
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            int nAnswer = 0;

            // string and int for the response
            string sResponse = "";
            Int32 nResponse = 0;

            // play again?
            string sAgain = "";

            bool bValid = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // seed the random number generator
            Random rand = new Random();

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while (true)
            {
                Console.Write("What is your name-> ");
                myName = Console.ReadLine();

                int len = myName.Length;
                //if( !len )
                if (myName.Length > 0)
                {
                    break;
                }
            }

        // label to return to if they want to play again
        start:

            // initialize correct responses for each time around
            nCorrect = 0;

            Console.WriteLine();

            // ask how many questions until they enter a valid number
            do
            {
                Console.Write("How many questions-> ");
                sQuestions = Console.ReadLine();
                bValid = int.TryParse(sQuestions, out nQuestions);
            } while (!bValid);

            Console.WriteLine();

            // ask difficulty level until they enter a valid response
            do
            {
                Console.Write("Difficulty level (easy, medium, hard)-> ");
                sDifficulty = Console.ReadLine();
                sDifficulty = sDifficulty.ToLower();

                //sDifficulty.ToLower();  does NOT change the contents of sDifficulty!
            } 
            while ((sDifficulty != "easy") && (sDifficulty != "medium") && (sDifficulty != "hard"));

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty)
            {
                case "easy":
                    nMaxRange = MAX_BASE; 
                    if(myName.ToLower() == "david")
                    {
                        nMaxRange = MAX_BASE * 3;
                    }
                    break;
                case "medium":
                    nMaxRange = MAX_BASE * 2;
                    break;
                case "hard":
                    nMaxRange = MAX_BASE * 3;
                    break;

            }

            // ask each question
            for (int i = 0; i < nQuestions; i++)
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);

                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers
                while((val1 == 0) && (val2 == 0))
                {
                    val1 = rand.Next(0, nMaxRange) + nMaxRange;
                    val2 = rand.Next(0, nMaxRange);
                }

                int userInp = 0;

                string sNOp = "";

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // else multiplication
                if(nOp == 0)
                {
                    nAnswer = val1 + val2;
                    sNOp = "+";
                }
                else if(nOp == 1)
                {
                    nAnswer = val1 - val2;
                    sNOp = "-";
                }
                else
                {
                    nAnswer = val1 * val2;
                    sNOp = "*";
                }

                Boolean validInp = true;
                // display the question and prompt for the answer until they enter a valid number
                Console.WriteLine(val1 + sNOp + val2);

                timeOutTimer = new Timer(500);

                timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

                timeOutTimer.Start();

                string userAns = Console.ReadLine();
                do
                {
                    try
                    {
                        userInp = int.Parse(userAns);
                        validInp = false;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid input.");
                        Console.WriteLine(val1 + sNOp + val2);
                        userAns = Console.ReadLine();
                        validInp = true;
                    }

                } while (validInp);

                // if response == answer, output flashy reward and increment # correct
                // else output stark answer
                if(userInp == nAnswer && !bTimeOut)
                {
                    Console.WriteLine("You got it right!");
                    nCorrect++;
                }
                else
                {
                    Console.WriteLine("You did not get it right.");
                    Console.WriteLine("Correct Answer: " + nAnswer);

                    bTimeOut = true;
                }
                

                // restore the screen colors
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            Console.WriteLine();

            // output how many they got correct and their score

            Console.WriteLine("Number Correct: " + nCorrect + "/" + nQuestions);

            do
            {
                // prompt if they want to play again
                Console.Write("Do you want to play again? ");

                sAgain = Console.ReadLine();

                // if they type y or yes then play again
                if((sAgain == "y") || (sAgain == "yes"))
                {
                    goto start; 
                }
                // else if they type n or no then leave this loop
                else
                {
                    break;
                }
            } while (true);
        }

        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");
            bTimeOut = true;
            timeOutTimer.Stop();
        }
    }
}
