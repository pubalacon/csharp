using System;

namespace Override_VS_New
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal lion = new Animal();   // pas d'instanciation de  classes abstraites;
            Animal lion = new Lion("male");
            lion.HungerForTheDay();
            Console.WriteLine(lion.Energy);
            lion.Feed();                     // l'appel de Feed ne surprend pas le compilateur meme si elle n'as pas de corps ds la classe animal
                                             // ici le compilateur voit que c'est abstract dans animal et va chercher dans lion
            Console.WriteLine(lion.Energy);
            //lion.Rugir();                    // erreur meme si Lion est une instance de Lion, on l'a declare comme animal et c'est la que 
                                             // le compilateur 




        }
    }
}
