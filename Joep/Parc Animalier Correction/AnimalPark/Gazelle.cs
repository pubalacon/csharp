using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPark
{
    class Gazelle : Prey
    {
        public static double ReproChance { get; set; }

        public static Gazelle RandomGazelle()
        {
            return new Gazelle(Utils.RandomSex(), new Random().NextDouble());
        }
        public Gazelle(bool sexe, double EscapeChance) : base("Gazelle", sexe, EscapeChance)
        {
            this.ReproductionChance = ReproChance;
        }
        public override Animal Reproduce(Animal b)
        {
            if (Utils.ChanceSucces(this.ReproductionChance))
            {
                Gazelle cast = (Gazelle)b;
                return (new Gazelle(Utils.RandomSex(), cast.EscapeChance / 2 + this.EscapeChance / 2));
            }
            else
            {
                return null;
            }
        }

    }
}
