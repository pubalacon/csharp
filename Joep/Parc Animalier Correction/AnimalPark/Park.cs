using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalPark
{
    class Park
    {
        public List<Animal> Animals { get; set; }
        public List<Animal> Babies { get; set; }
        public Park()
        {
            Animals = new List<Animal> { };
            Babies = new List<Animal> { };
        }


        public Animal   FindMate(Animal a)
        {
            List<Animal> sexy = Animals.Where((x) => x.IsAlive && x.GetType() == a.GetType() && a.Sexe != x.Sexe).ToList();
            if (sexy.Count() > 0)
                return sexy.ElementAt(new Random().Next(sexy.Count()));
            else
                return null;
        }
        public Animal   Reproduction(Animal a, Animal b)
        {
            if (Utils.IsPrey(a))
                return (a.Reproduce(b));
            else
            {
                if (a.Energy <= 20 || b.Energy <= 20)
                 
                    return ((Predator)a).DoubleReproduce((Predator)b);
                else
                    return (a.Reproduce(b));
            }
        }
        public void     Mate(Animal a)
        {
            Animal b = FindMate(a);
            if (b != null)
            {
                Animal bebe = Reproduction(a, b);
                if (bebe != null)
                {
                    Babies.Add(bebe);
                }
            }
        }


        public Prey     FindPrey()
        {
            List<Animal> tasty = Animals.Where((x) => x.IsAlive && Utils.IsPrey(x)).ToList();
            if (tasty.Count() > 0)
                return (Prey)tasty.ElementAt(new Random().Next(0, tasty.Count()));
            else
                return null;
        }
        public bool     IsHuntSucces(Predator Hunter, Prey Victime)
        {
            return Utils.ChanceSucces(Victime.EscapeChance * (1 - Hunter.HuntSuccesChance));
        }
        public void     Hunt(Predator Hunter, Prey Victime)
        {
            if (IsHuntSucces(Hunter, Victime))
            {
                Victime.IsAlive = false;
                Hunter.Feed();
            }
            else
            {
                Hunter.Energy -= 20;
                Victime.Energy -= 20;
            }
        }
        public void     GoHunt(Predator Hunter)
        {
            if (Hunter.Energy > 20)
            {
                Prey Victime = FindPrey();
                if (Victime != null)
                    Hunt(Hunter, Victime);
            }
        }


        public void     AddBabies()
        {
            foreach (Animal bb in Babies)
            {
                AddAnimal(bb);
            }
            Babies.Clear();
        }
        public void     RemoveTheDead()
        {
            Animals = Animals.Where((x) => x.IsAlive).ToList();
        }
        public void     PredatorDay(Predator ani)
        {
            GoHunt(ani);
            Mate(ani);
            ani.Energy -= 20;
            if (ani.Energy <= 0)
                ani.IsAlive = false;
        }
        public void     PreyDay(Prey ani)
        {
            ani.Feed();
            Mate(ani);
            ani.Energy -= 20;
            if (ani.Energy <= 0)
                ani.IsAlive = false;
        }
        public void     GoThroughADay()
        {
            foreach (Animal ani in Animals)
            {
                if (Utils.IsPredator(ani))
                    PredatorDay((Predator)ani);
                else
                    PreyDay((Prey)ani);
            }
            RemoveTheDead();
        }


        public void     AddAnimal(Animal a)
        {
            Animals.Add(a);
        }
        public void     PrintStatus()
        {
            foreach (Animal ani in Animals)
            {
                ani.DisplayInfo();
            }
        }
        public int      CountAnimals()
        {
            return Animals.Count();
        }
    }
}
