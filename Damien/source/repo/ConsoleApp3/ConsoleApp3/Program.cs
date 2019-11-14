using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat theCat = new Cat("felix", 1, 3);
            Dog theDog = new Dog("médor", 5, 20, 60);

            List<Animal> animaux = new List<Animal>();

            animaux.Add(theCat);
            animaux.Add(theDog);

            Console.WriteLine("*--- Liste des animaux");
            foreach(Animal bebete in animaux)
            {
                Console.WriteLine($"animal: nom {bebete.Name}");
            }

            Console.WriteLine("*--- methodes virtual / override");
            theCat.Move();
            theDog.Move();
            theCat.Say();
            theDog.Say();

            Console.WriteLine("Methode héritée");
            theDog.Sleep();
            theCat.Sleep();

            Console.ReadKey();
        }
    }
}
