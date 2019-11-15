using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPark
{
    class Utils
    {
        public static bool IsPredator(Animal ani)
        {
            return ani.GetType().IsSubclassOf(typeof(Predator));
        }
        public static bool IsPrey(Animal ani)
        {
            return ani.GetType().IsSubclassOf(typeof(Prey));
        }
        public static bool RandomSex()
        {
            int luck = new Random().Next(0, 2);
            return (luck == 1);
        }
        public static bool ChanceSucces(double ChanceOfSucces)
        {
            double luck = new Random().NextDouble();
            return (luck <= ChanceOfSucces);
        }
    }
}
