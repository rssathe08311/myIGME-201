using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Autor: Reva Sathe
    //Date: 10/16/23
    internal class Program
    {
        //Pets class
        public class Pets
        {
            //field
            public List<Pet> petList = new List<Pet>();

            //property
            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            //methods
            public int Count
            {
                get
                {
                    return petList.Count;
                }
            }
            public void Add(Pet pet)
            {
                this.petList.Add(pet);
            }
            public void Remove(Pet pet)
            {
                this.petList.Remove(pet);
            }
            public void RemoveAt(int petEl)
            {
                this.petList.RemoveAt(petEl);
            }
        }

        //Pet abstract Class
        public abstract class Pet
        {
            //feilds 
            private string name;
            public int age;

            //methods
            public string Name//might be used to change the name of the pet but not sure
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            //abstract methods
            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();

            //constructor
            //empty constructor
            public Pet()
            {
                
            }

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        //Cat interface
        public interface ICat
        {
            //methods
            void Eat();
            void Play();
            void Scratch();
            void Purr();
            void GotoVet();

        }

        //Dog Interface
        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }

        //Cat Class
        public class Cat : Pet, ICat
        {
            //methods
            public override void Eat()
            {
                Console.WriteLine(base.Name + " Mew Mew");
            }
            public override void Play()
            {
                Console.WriteLine(base.Name + " Mrow Mrow");
            }
            public void Purr()
            {
                Console.WriteLine(base.Name + " Purrrrrr Purrrrr");
            }
            public void Scratch()
            {
                Console.WriteLine(base.Name + " Kheeee Kheeee");
            }
            public override void GotoVet()
            {
                Console.WriteLine(base.Name + " Nooooooooooo");
            }

            //Constructor
            public Cat()
            {

            }
        }

        //Dog Class
        public class Dog: Pet, IDog
        {
            //fields
            public string license;

            //methods
            public override void Eat()
            {
                Console.WriteLine(base.Name + " Nom Nom Nom");
            }
            public override void Play()
            {
                Console.WriteLine(base.Name + " Boof Boof!");
            }
            public void Bark()
            {
                Console.WriteLine(base.Name + " Woof Woof");
            }
            public void NeedWalk()
            {
                Console.WriteLine(base.Name + " *sigh*");
            }
            public override void GotoVet()
            {
                Console.WriteLine(base.Name + " Awoooo");
            }

            //Constructors
            public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
            {
                this.license = szLicense;

            }
        }

        static void Main(string[] args)
        {
            //refrence variables 
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            //list of pets
            Pets pets = new Pets();

            //random number generator
            Random rand = new Random();

            //for loop
            for(int i = 0; i < 50; i++)
            {
                //generates random number from 1 to 10
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)//creates a dog using user input
                    {
                        Console.WriteLine("You bought a dog!");

                        //gets values from user
                        Console.WriteLine("What is your dog's name?");
                        string tempName = Console.ReadLine();
                        Console.WriteLine("How old is your dog?");
                        int tempAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is your dog's 3 digit license?");
                        string tempLi = Console.ReadLine();

                        dog = new Dog(tempLi, tempName, tempAge);

                        pets.Add(dog);

                        Console.WriteLine("Dog's Name => " + tempName);
                        Console.WriteLine("Age => " + tempAge);
                        Console.WriteLine("License => " + tempLi);

                    }
                    else//creates a cat using user input
                    {
                        Console.WriteLine("You bought a cat!");

                        //gets values from user
                        Console.WriteLine("What is your cat's name?");
                        string tempName = Console.ReadLine();
                        Console.WriteLine("How old is your cat?");
                        int tempAge = int.Parse(Console.ReadLine());

                        cat = new Cat();
                        cat.Name = tempName;
                        cat.age = tempAge;

                        pets.Add(cat);

                        Console.WriteLine("Cat's Name => " + tempName);
                        Console.WriteLine("Age => " + tempAge);
                    }
                }
                else
                {
                    //randomly chooses an element from the pets list to use
                    int randPet = rand.Next(0, pets.Count);
                    thisPet = pets[randPet];
                    
                    if(thisPet == null)//if the value is null the loop will go back to the top
                    {
                        continue;
                    }
                    //if the type is a dog a dog object will be instantiated in the interface variable
                    else if(thisPet.GetType() == typeof(Dog))
                    {
                        iDog = (Dog)thisPet;

                        //switch statement that randomly applies methods of the relavant class
                        int randMethod = rand.Next(0, 5);
                        switch (randMethod)
                        {
                            case 0:
                                iDog.Eat();
                                break;
                            case 1:
                                iDog.Play();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                            case 4:
                                iDog.GotoVet();
                                break;
                        }
                    }
                    //if the type is a cat a cat object will be instantiated in the interface variable
                    else if (thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (Cat)thisPet;

                        //switch statement that randomly applies methods of the relavant class
                        int randMethod = rand.Next(0, 5);
                        switch (randMethod)
                        {
                            case 0:
                                iCat.Eat();
                                break;
                            case 1:
                                iCat.Play();
                                break;
                            case 2:
                                iCat.Purr();
                                break;
                            case 3:
                                iCat.Scratch();
                                break;
                            case 4:
                                iCat.GotoVet();
                                break;
                        }
                    }
                    
                }
            }
        }
    }
}
