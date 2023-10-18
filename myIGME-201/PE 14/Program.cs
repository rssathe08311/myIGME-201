using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PE_14
{
    public interface DrinkHolder
    {
        void MakeDrink();

    }
    public class GlassCup : DrinkHolder
    {
        private bool ice = false;
        private bool full = false;
        public void MakeDrink()
        {
            this.full = true;
            this.ice = true;
            Console.WriteLine("A cold drink has been served in a glass cup");
        }
    }
    public class Mug : DrinkHolder
    {
        private bool warmed = false;
        private bool full = false;
        public void MakeDrink()
        {
            this.full = true;
            this.warmed = true;
            Console.WriteLine("A warm drink has been served in a mug");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object initializations
            Mug mug = new Mug();
            GlassCup cup = new GlassCup();

            MyMethod(mug);
            MyMethod(cup);
        }

        public static void MyMethod(object myObject)
        {
            DrinkHolder drink = (DrinkHolder)myObject;

            drink.MakeDrink();
        }
    }
}
