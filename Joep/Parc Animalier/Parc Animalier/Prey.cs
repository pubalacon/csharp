using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    abstract class Prey : Animal
    {
        public string Species { get; set; }
        public string Sex { get; set; }
        public int Energy { get; set; }
        public bool IsAlive { get; set; }

        public double EscapeChance;

        public int EatMinEnergy = 10;
        public int EatMaxEnergy = 40;

        public bool isHunted;

        public Prey(string species, string sex, double reproChance) : base(species, sex, reproChance)
        {}
        public override void eat()
        {
            manageEnergy(getRandom(EatMinEnergy, EatMaxEnergy));
        }

        public void checkIsHunted(Animal predator)
        {

        }
    }
}
