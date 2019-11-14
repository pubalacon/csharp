using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    class Program
    {
        static List<Animal> AnimalsInPark = new List<Animal>();

        static void Main(string[] args)
        {

            Animal lion1 = new Lion("male", 0.3);
            //Console.WriteLine(lion.GetType().Name);
            Animal lion2 = new Lion("femelle", 0.3);

            AnimalsInPark.Add(lion1);
            AnimalsInPark.Add(lion2);

            //Console.WriteLine(lion2.ToString());


            Park myPark = new Park(AnimalsInPark);

            foreach (Animal animal in myPark.filterType(typeof(Predator)))
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine(myPark.getMate(lion1, AnimalsInPark));


            Console.ReadKey();
        }
    }
}
