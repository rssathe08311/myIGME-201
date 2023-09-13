using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Parsing_and_Formatting
{
    //Reva Sathe
    //9-13-23
    //IGME 201
    //this program will be a simple guessing game where the program will chose a random integer from 0-100 and the user will try to guess it
    internal class Program
    { 
        //the entire guessing game is contianed in the main method
        static void Main(string[] args)
        {
            //creates a random object
            Random rand = new Random();

            //generates a random number from 0-100 and stores and displays it
            int randNum = rand.Next(0, 101);

            Console.WriteLine(randNum);

            //initializes and decales variables to be used in the game
            Boolean corVal = false;
            int userGuess = 0;
            int tries = 0;

            Console.WriteLine("Guess a number from 0-100!");

            //while loop to allow up to 8 turns
            while((tries < 8) && !(corVal))
            {
                //promts and accepts user guess
                Console.WriteLine("Turn " + (tries + 1) + ": Enter your guess: ");
                string userInp = Console.ReadLine();

                Boolean valid = false;

                //while loop to make sure tha user guesses are valid guesses
                while (!valid)
                {
                    //makes sure that the input able to be parsed to an int
                    try
                    {
                        userGuess = int.Parse(userInp);
                        
                    }
                    catch
                    {
                        Console.WriteLine("Enter an integer between 0 and 100");
                        Console.WriteLine("Turn " + (tries + 1) + ": Enter your guess: ");
                        tries -= 1;
                        userInp = Console.ReadLine();
                        
                    }

                    //makes sure that the guessed int is in the range of valid guesses
                    if ((userGuess < 0) || (userGuess > 100))
                    {
                        
                        Console.WriteLine("Invalid Guess - try agian");
                        Console.WriteLine("Turn " + (tries + 1) + ": Enter your guess: ");
                        userInp = Console.ReadLine();
                    }
                    else
                    {
                        valid = true;
                    }
                }

                //different responses based upon valid user input
                if (userGuess > randNum)
                {
                    Console.WriteLine("Too high");
                }
                else if(userGuess < randNum)
                {
                    Console.WriteLine("Too low");
                }
                else if(userGuess == randNum)
                {
                    Console.WriteLine("Correct! You won in " + (tries + 1) + " turns.");
                    corVal = true;
                    tries = 8;
                }
                else
                {
                    Console.WriteLine("You ran out of turns. The number was " + randNum);
                  

                }

                //incriments the number of tries
                ++tries;
            }
        }
    }
}
