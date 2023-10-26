using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieApp
{
    public abstract class Movies
    {
        //field
        private string director;

        //property
        public string Director
        {
            get
            {
                return this.director;
            }
            set
            {
                this.director = value;
            }
        }

        //methods
        public abstract void RateMovie(double rating);

        public virtual void WatchMovie()
        {
            Console.WriteLine("Click play and enjoy");
        }
    }

    public interface IHorror
    {
        //method
        void Scare();
    }
    public interface IThriller
    {
        //method
        void Suspense();
    }

    public class Hereditary : Movies, IHorror
    {
        public override void RateMovie(double rating)
        {
            Console.WriteLine("You rated Hereditary a " + rating);
        }
        public override void WatchMovie()
        {
            Console.WriteLine("Beware if you do not like horror movies, this one is sure to give you a good scare.");
        }
        public void Scare()
        {
            Console.WriteLine("Be wary of those around you.");
        }

    }
    public class Se7en : Movies, IThriller
    {
        public override void RateMovie(double rating)
        {
            Console.WriteLine("You rated Se7en a " + rating);
        }
        public override void WatchMovie()
        {
            Console.WriteLine("As you watch can you figure out who did it?");
        }
        public void Suspense()
        {
            Console.WriteLine("Twists and turns at every corner.");
        }

    }
    internal class Program
    {
        //method to call objects
        static void MyMethod(object obj)
        {
            //instances
            Movies movie;
            IHorror horror;
            IThriller thriller;
            if(obj is Movies)
            {
              movie = (Movies)obj;
              movie.RateMovie(10);
              movie.WatchMovie();
            }
            if(obj is IHorror)
            {
                horror = (IHorror)obj;
                horror.Scare();
            }
            if(obj is IThriller)
            {
                thriller = (IThriller)obj;
                thriller.Suspense();
            }
            
        }
        static void Main(string[] args)
        {
            //initializing specific movies objects
            Hereditary hereditary = new Hereditary();
            Se7en se7En = new Se7en();

            //calling MyMethod on the objects
            MyMethod(hereditary);
            Console.WriteLine();
            MyMethod(se7En);

        }
    }
}
