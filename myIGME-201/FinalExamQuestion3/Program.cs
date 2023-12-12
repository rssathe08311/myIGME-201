using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamQuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            A_Matrix matrix = new A_Matrix();
            Console.WriteLine(matrix.ToString());
        }
    }

    public class A_Matrix
    {
        private List<string> vertcies;
        private Dictionary<(string, string), int> edges;

        public A_Matrix()
        {
            //list of verticies shown 
            vertcies = new List<string> { "red", "blue", "gray", "cyan", "yellow", "orange", "purple", "green"};

            //the representation of the diagram shown on the exam
            edges = new Dictionary<(string, string), int>
            {
                {("red", "blue"), 1},
                {("red", "gray"), 5},
                {("blue", "cyan"), 1},
                {("cyan", "blue"), 1},
                {("blue", "yellow"), 8},
                {("gray", "cyan"), 0},
                {("cyan", "gray"), 0},
                {("gray", "orange"), 0},
                {("yellow", "green"), 6},
                {("orange", "purple"), 1},
                {("purple", "yellow"), 0},
            };
        }

        public override string ToString()
        {
            // Create a string builder to efficiently concatenate strings rather than str +=
            var stringBuilder = new System.Text.StringBuilder();

            // Iterate through the key-value pairs in the dictionary
            foreach (var entry in edges)
            {
                stringBuilder.Append($"({entry.Key.Item1}, {entry.Key.Item2}): {entry.Value}, ");
            }

            if (stringBuilder.Length > 0)
            {
                stringBuilder.Length -= 2;
            }

            // Convert the StringBuilder to a string and return it
            return stringBuilder.ToString();
        }

    }
}
