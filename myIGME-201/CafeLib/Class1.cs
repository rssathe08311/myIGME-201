﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood
        {
            get;
        }
    }
    
    public class Waiter : IMood
    {
        //fields
        public string name;

        //methods
        public string Mood
        {
            get;
        }
        public void ServeCustomer(HotDrink cup)
        {
            Console.WriteLine("Here's your drink");
        }
    }

    public class Customer : IMood
    {
        //fields
        public string name;
        public string creditCardNumber;

        //methods
        public string Mood
        {
            get;
        }

    }
    public abstract class HotDrink
    {
        //fields 
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        //methods
        public virtual void AddSugar(byte amount)
        {
            this.sugar += amount;
        }
        public abstract void Steam();

        //constructors
        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {

        }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        //fields
        public string beanType;

        //methods
        public override void Steam()
        {
            Console.WriteLine("Steaming the coffee!");
        }

        public void TakeOrder()
        {
            Console.WriteLine("What would you like?");
            string order = Console.ReadLine();
            Console.WriteLine("One " + order + " coming up!");
        }

        public CupOfCoffee(string brand): base(brand)
        {
            this.beanType = brand;
        }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        //fields
        public string leafType;

        //methods
        public override void Steam()
        {
            Console.WriteLine("Steaming the coffee!");
        }
        public void TakeOrder()
        {
            Console.WriteLine("What would you like?");
            string order = Console.ReadLine();
            Console.WriteLine("One " + order + " coming up!");
        }

        //constructors
        public CupOfTea(bool customerIsWealthy)
        {
            if (customerIsWealthy)
            {
                this.leafType = "fancy";
            }
        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
        
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        //fields
        public static int numCups = 0;
        public bool marshmallows;
        private string source;

        //methods
        public string Source
        {
            set
            {
                this.source = value;
            }
        }
        public override void Steam()
        {
            Console.WriteLine("Steaming the coffee!");
        }
        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }
        public void TakeOrder()
        {
            Console.WriteLine("What would you like?");
            string order = Console.ReadLine();
            Console.WriteLine("One " + order + " coming up!");
        }

        //constructors 
        public CupOfCocoa() : this(false)
        {
            numCups++;
        }

        public CupOfCocoa(bool marshmallows): base("Expensive Organic Brand")
        {
            this.marshmallows = marshmallows;
        }
    }

}
