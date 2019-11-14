using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int increment=0; // on peut aussi incrementer directement "static int Matricule" dans la classe Vehicule, ce qui degage les constructeurs de l'accepter en parametre

            Voiture car1 = new Voiture(++increment, "2019", 23000);
            Camion camion1 = new Camion(++increment, "2018", 19000);
            Voiture car2 = new Voiture(++increment, "2018", 19000);
            Camion camion2 = new Camion(++increment, "2017", 14000);
            Console.WriteLine(car1.ToString());
            Console.WriteLine(camion1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(camion2.ToString());

            Console.ReadKey();

        }
    }
}
