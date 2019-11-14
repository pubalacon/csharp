using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    abstract class Animal
    {
        public string UID;
        public string Species { get; set; }
        public string Sex { get; set; }
        public int Energy { get; set; }
        public bool IsAlive { get; set; }

        public double BaseReproChance { get; set; }

        public Animal(string species, string sex, double reproChance)
        {
            myRandom random = new myRandom();
            UID = random.getRandom();

            Species = species;
            Sex = sex;
            Energy = 100;
            IsAlive = true;
            BaseReproChance = reproChance;
        }
        public abstract void eat();
        public bool haveBaby(Animal pere, Animal mere)
        {
            return true;
        }

        public bool checkEnergy()
        {
            return this.Energy >= 0 ? true : false;
        }

        public void oneMoreDay()
        {
            manageEnergy(-20);
        }

        public virtual void manageEnergy(int gain)
        {
            this.Energy += gain;
            
            if (!checkEnergy()) this.IsAlive = false;
        }

        public int getRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public override string ToString()
        {
            return "UID: "+UID+", type: " + this.GetType().Name + ", sex: " + Sex + ", repro: " + BaseReproChance.ToString();
        }

    }
}
