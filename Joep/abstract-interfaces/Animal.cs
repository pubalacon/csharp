using System;
using System.Collections.Generic;
using System.Text;

namespace Override_VS_New
{
    // classe abstraite:
    //  ne peut etre instanciee (ie: Animal chat = new Animal(); n'est pas permis)
    //  doit contenir au moins une methode Abstraite. Les methodes abstraites DOIVENT etre definies ds les classes derivees.

    // Elles servent a eviter la redondance de Code, en effet les fonctions communes a tous les Animals sont definies ici;
    // Elles servent a definir un patron (toutes les classes derivees auront une fonction Feed() ce qui permet d'eviter les erreurs)
    // Elle permet de definir (ailleurs) une fonction UnJourPasse(Animal bete) => {bete.Feed(); bete.Hunger()}
    public abstract class Animal
    {
        public string Espece { get; set; }  // on met public ou protected si l'on veut que les classes derivees y aient acces
        public string Sexe { get; set; }    // sinon on definit des methodes publiques/protected qui y accedent
        public int Energy { get; set; }
        public bool Alive { get; set; }

        public Animal(string espece, string sexe)
        {
            this.Espece = espece;
            this.Energy = 100;
            this.Alive = true;
            this.Sexe = sexe;
        }

        public abstract void Feed();        // abstract => on ne definit pas la fonction
                                            // si une classe herite de Animal elle DOIT definir la methode Feed()

        public void DisplayInfo()           // on n'est pas limite aux methodes abstraites.
        {
            Console.WriteLine("The animal is a " + Sexe + " " + Espece + " with " + Energy + " energy left.");
        }

        public void HungerForTheDay()
        {
            Energy -= 20;
        }

        public void IsItDead()
        {
            if (this.Energy == 0)
                this.Alive = false;
        }
    }
}
