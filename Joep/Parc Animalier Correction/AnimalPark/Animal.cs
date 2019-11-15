using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPark
{
    abstract class Animal
    {
        public int      Energy { get; set; }
        public string   Espece { get; set; }
        public bool     Sexe { get; set; }
        public double   ReproductionChance { get; set; }
        public bool     IsAlive { get; set; }

        public Animal(string espece, bool sexe)
        {
            Energy = 100;
            Espece = espece;
            Sexe = sexe;
            IsAlive = true;
        }

        public void             DisplayInfo()
        {
            string sexe = "male";
            if (Sexe)
                sexe = "femelle";

            Console.WriteLine("Je suis un " + Espece + " " + sexe + " avec " + Energy + " energie");
        }
        public abstract void    Feed();
        public abstract Animal  Reproduce(Animal mate);
        public void             LoseEnergy()
        {
            Energy = Energy - 20;
        }
    }
}
