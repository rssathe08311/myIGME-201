using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructToClass
{
    public class Friend : ICloneable
    {
        //fields
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        //constructor
        public Friend(string name,  string greeting, DateTime birthdate, string address)
        {
            this.name = name;
            this.greeting = greeting;  
            this.birthdate = birthdate;
            this.address = address;
        }

        public object Clone()
        {
            return (Friend)MemberwiseClone();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // create my friend Charlie Sheen
            Friend friend = new Friend("Charlie Sheen", "Dear Charlie", DateTime.Parse("1967-12-25"), "123 Any Street, NY NY 12202");
            Friend enemy = (Friend)friend.Clone();

           

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");

        }
    }
}
