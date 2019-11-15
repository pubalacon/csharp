using System;

namespace AnimalPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Park Parc = new Park();

            Lion.ReproChance = 0.6;
            Gazelle.ReproChance = 0.6;

            Lion Leonidette = new Lion(true, 0.7);
            Lion Leonidas = new Lion(false, 0.7);
            

            Parc.AddAnimal(Leonidas);
            Parc.AddAnimal(Leonidette);

            int i = 10;
            while (i > 0)
            {
                Parc.AddAnimal(Lion.RandomLion());
                Parc.AddAnimal(Gazelle.RandomGazelle());

                i--;
            }


            i = 10;
            while (i > 0)
            {
                Console.WriteLine("ITS A NEW DAAAY");
                Console.WriteLine(Parc.CountAnimals());
                Parc.PrintStatus();
                Parc.GoThroughADay();
                i--;
            }
        }
    }
}
