using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }

    public interface IHeavyLoadCarrier
    {

    }

    public abstract class Car : Vehicle 
    {
        public override void LoadPassenger()
        {

        }
    }

    public abstract class Train : Vehicle 
    { 
        
    }

    public class Compact : Car, IPassengerCarrier
    {
        public override void LoadPassenger() 
        {

        }
    }

    public class SUV : Car, IPassengerCarrier
    {
        public override void LoadPassenger()
        {

        }
    }

    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {
        public override void LoadPassenger()
        {

        }
    }

    public class PassengerTrain : Train, IPassengerCarrier
    {
        public override void LoadPassenger()
        {

        }
    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {
        public override void LoadPassenger()
        {

        }
    }

    public class _424DoubleBoget : Train, IHeavyLoadCarrier
    {
        public override void LoadPassenger()
        {

        }
    }

}
