using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPark
{
    abstract class Predator : Animal
    {
        public double HuntSuccesChance { get; set; }

        public Predator(string espece, bool sexe, double huntSuccesChance) : base(espece, sexe)
        {
            HuntSuccesChance = huntSuccesChance;
        }
        public override void Feed()
        {
            Energy = 100;
        }
        public abstract Predator DoubleReproduce(Predator b);
    }


}
