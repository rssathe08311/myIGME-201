using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence that contains the word 'no':");
            string sentence = Console.ReadLine();

            sentence = sentence.ToLower();

            string[] words = sentence.Split(' ');

            string ans = "";

            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == "no")
                {
                    words[i] = "yes";
                }

                ans += words[i] + " ";
            }

            Console.WriteLine(ans);
        }
    }
}
