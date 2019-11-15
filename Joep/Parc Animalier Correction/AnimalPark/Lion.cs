using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPark
{
    class Lion : Predator
    {
        public static double ReproChance { get; set; }
        public static Lion RandomLion()
        {
            return new Lion(Utils.RandomSex(), new Random().NextDouble());
        }
        public Lion(bool sexe, double huntSuccessChance) : base("Lion", sexe, huntSuccessChance)
        {
            this.ReproductionChance = ReproChance;
        }
        public override Animal Reproduce(Animal b)
        {
            if (Utils.ChanceSucces(this.ReproductionChance))
            {
                Lion cast = (Lion)b;
                return (new Lion(Utils.RandomSex(), cast.HuntSuccesChance / 2 + this.HuntSuccesChance / 2));
            }
            else
            {
                return null;
            }
        }
        public override Predator DoubleReproduce(Predator b)
        {
            if (Utils.ChanceSucces(this.ReproductionChance * 2))
            {
                Lion cast = (Lion)b;
                return (new Lion(Utils.RandomSex(), cast.HuntSuccesChance / 2 + this.HuntSuccesChance / 2));
            }
            else
            {
                return null;
            }
        }

    }
}
