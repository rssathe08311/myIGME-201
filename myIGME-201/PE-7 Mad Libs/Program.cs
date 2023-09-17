using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_7_Mad_Libs
{
    //PE-7 Mad Libs
    //Reva Sathe
    //IGME 201
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultString = "";
            int prompts = 0; 
            
            //initializes a file reader
            StreamReader txtInput;

            //reads the text file and stores it into txtInput
            txtInput = new StreamReader("\\\\Mac\\Home\\Desktop\\github\\myIGME-201\\PE-7 Mad Libs\\templates\\MadLibsTemplate.txt");

            string sent = null;
            //counts the number of mad lib lines/prompts in the text file
            while((sent = txtInput.ReadLine()) != null)
            {
                ++prompts;
            }
            //closes the text file
            txtInput.Close();

            string[] madLib = new string[prompts];

            //reopens the file to read it
            txtInput = new StreamReader("\\\\Mac\\Home\\Desktop\\github\\myIGME-201\\PE-7 Mad Libs\\templates\\MadLibsTemplate.txt");
            //resets the value of sent 
            sent = null;
            int i = 0;
            //puts the lines of the text file into a string array
            while((sent = txtInput.ReadLine()) != null)
            {
                madLib[i] = sent;

                madLib[i] = madLib[i].Replace("\\n", "\n");

                ++i;

            }
            txtInput.Close();


            Console.WriteLine("Do you want to play Mad Libs?");
            string ans = Console.ReadLine();
            ans = ans.ToLower();
            Boolean play = false;
            while(!play)
            {
                if (ans == "yes")
                {
                    int userChoice = 0;
                    //promt user for which madLib they want to do
                    Console.WriteLine("Enter which Mad Lib you would like to play. Enter an integer from 1 to " + (prompts));
                    string tempNum = Console.ReadLine();
                    //make sure that its a valid answer and then set it to userChoice

                    Boolean valid = false;
                    while (!valid)
                    {
                        try
                        {
                            userChoice = int.Parse(tempNum);
                        }
                        catch
                        {
                            Console.WriteLine("Enter an integer from 1 to " + (prompts));
                            tempNum = Console.ReadLine();
                        }

                        if ((userChoice <= 0) || (userChoice > (prompts + 1)))
                        {
                            Console.WriteLine("Enter an integer from 1 to " + (prompts));
                            tempNum = Console.ReadLine();
                        }
                        else
                        {
                            valid = true;
                        }
                    }

                    string[] words = madLib[userChoice - 1].Split(' ');

                    foreach (string word in words)
                    {
                        if (word[0] == '{')
                        {
                            string tempWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                            Console.Write("Input a {0}:", tempWord);

                            resultString += Console.ReadLine() + " ";
                        }
                        else
                        {
                            resultString += word + " ";
                        }

                    }

                    Console.WriteLine(resultString);
                    play = true;
                }
                else if (ans == "no")
                {
                    Console.WriteLine("Goodbye!");
                    play = true;
                }

                else
                {
                    Console.WriteLine("Try again");
                    Console.WriteLine("Do you want to play Mad Libs?");
                    ans = Console.ReadLine();
                    ans = ans.ToLower();
                }
            }


            
        }
    }
}
