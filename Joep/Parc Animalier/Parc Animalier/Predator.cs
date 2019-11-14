using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    abstract class Predator : Animal
    {
        public string Species { get; set; }
        public string Sex { get; set; }
        public int Energy { get; set; }
        public bool IsAlive { get; set; }
        public double BaseReproChance { get; set; }

        public double HuntSuccesChance;

        public Predator(string species, string sex, double reproChance) : base(species, sex, reproChance)
        {}
        public override void eat()
        {
            manageEnergy(100 - this.Energy);
        }

        public bool hunt(List<Animal> preys)
        {
            int i = getRandom(0, preys.Count);
            Animal prey = preys[i];

            return (this.HuntSuccesChance > ((Prey)prey).EscapeChance);
        }

        
    }
}
