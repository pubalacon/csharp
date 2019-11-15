using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPark
{
    abstract class Prey : Animal
    {
        public double EscapeChance { get; set; }

        public Prey(string espece, bool sexe, double escapeChance) : base(espece, sexe)
        {
            EscapeChance = escapeChance;
        }
        public override void Feed()
        {
            Energy += new Random().Next(10, 41);
        }
    }
}
