using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Test
{
    public abstract class Phone
    {
        //fields
        private string phoneNumber;
        public string address;

        //property
        public string PhoneNumber
        {
            get 
            { 
                return phoneNumber; 
            }
            set 
            {
                phoneNumber = value; 
            }
        }

        public abstract void Connect();
        public abstract void Disconnect();
    }

    public interface PhoneInterface
    {
        //methods
        void Answer();
        void MakeCall();
        void HangUp();

    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {
            Console.WriteLine("Hello?");
        }
        public void MakeCall()
        {
            Console.WriteLine("Enter in the phone number of the person you would like to call");
            string CallerID = Console.ReadLine();
            Console.WriteLine("Click Click Click...Calling " + CallerID);
        }
        public void HangUp()
        {
            Console.WriteLine("Call Ended");
        }

        public override void Connect()
        {
            Console.WriteLine("Your call has been connected");
        }
        public override void Disconnect()
        {
            Console.WriteLine("Your call has been disconnected");
        }
    }

    public class Tardis : RotaryPhone
    {
        //fields
        private bool sonicScrewdriver;
        private byte whichDoctorWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDoctorWho
        {
            get 
            { 
                return this.whichDoctorWho;
            }
        }
        public string FemaleSideKick
        {
            get
            {
                return this.femaleSideKick;
            }
        }

        public void TimeTravel()
        {
            Console.WriteLine("*woosh* traveling though time");
        }
        public static bool operator ==(Tardis t1, Tardis t2)
        {
            if(t1.whichDoctorWho == t2.whichDoctorWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Tardis t1, Tardis t2)
        {
            if (t1.whichDoctorWho == t2.whichDoctorWho)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator >(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho > t2.whichDoctorWho)||(t1.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho < t2.whichDoctorWho) || (t2.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho <= t2.whichDoctorWho) || (t2.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho >= t2.whichDoctorWho) || (t1.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {
            Console.WriteLine("Hello?");
        }
        public void MakeCall()
        {
            Console.WriteLine("Enter in the phone number of the person you would like to call");
            string CallerID = Console.ReadLine();
            Console.WriteLine("Beep Beep Beep...Calling " + CallerID);
        }
        public void HangUp()
        {
            Console.WriteLine("Call Ended");
        }

        public override void Connect()
        {
            Console.WriteLine("Your call has been connected");
        }
        public override void Disconnect()
        {
            Console.WriteLine("Your call has been disconnected");
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        //fields
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        //methods
        public void OpenDoor()
        {
            Console.WriteLine("Opening the door");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Closing the door");
        }
    }

    internal class Program
    {
        static void UsePhone(object obj)
        {
            PhoneInterface phone;//creates a phone object
            PhoneBooth phoneBooth;//creates phoneBooth object
            Tardis tardis; //creates tardis object
            //checks if obj is a phoneInterface
            if (obj is PhoneInterface)
            {
                phone = (PhoneInterface)obj;//casts object to phoneInterface
                //calls methods
                phone.MakeCall();
                phone.HangUp();
            }
            //checks if obj is a phoneBooth
            if (obj. is PhoneBooth)
            {
                phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }
            //checks if obj is a Tardis
            if (obj is Tardis)
            {
                tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis(); 
            PhoneBooth phoneBooth = new PhoneBooth();
        }

    }
}
