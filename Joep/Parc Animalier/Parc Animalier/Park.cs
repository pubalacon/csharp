using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    class Park
    {
        public List<Animal> Animals = new List<Animal>();

        public int ThisDay = 0;

        public Park(List<Animal> animals)
        {
            Animals = animals;
        }

        public Animal getMate(Animal animal)
        {
            Animal mate;
            Type type = animal.GetType().BaseType;
            List<Animal> compatibles = Animals.Where((x) => x.GetType().BaseType == type && x.UID!=animal.UID && x.Sex!=animal.Sex).ToList();

            Random random = new Random();
            int i = random.Next(compatibles.Count);

            mate = compatibles[i];

            return mate;
        }

        public List<Animal> filterType(Type type)
        {
            return Animals.Where((x) => x.GetType().BaseType == type).ToList();
        }

        public void oneMoreDay(List<Animal> animals)
        {
            List<Animal> preys = filterType(typeof(Prey));
            List<Animal> predators = filterType(typeof(Predator));

            foreach (Animal animal in Animals)
            {
                animal.oneMoreDay();
                animal.eat();
                //animal.haveBaby(getMate(animal));
            }

        }

        public void checkAll(List<Animal> animals)
        {
            int i = 0;
            foreach (Animal animal in animals)
            {
                if(!animal.checkEnergy())
                {
                    animals.RemoveAt(i);
                    i++;
                }
            }
        }
    }
}
