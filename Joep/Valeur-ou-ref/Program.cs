using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        public static void ChangeValue(int x, class1 instance)
        {
            instance.value = x;
        }
        public static void NewObject(class1 instance)
        {
            instance = new class1(745);
            
        }
        static void Main(string[] args)
        {

            // REF, sert pour les fonctiont qui vont servir a MODIFIER des variables plutot qu'a RETOURNER une valeur

            int i = 0;
            class1.increase(i);
            Console.WriteLine(i);   // la valeur de i n'as pas changee, elle est passee par valeur a la fonction,
                                    // c'est a dire la fonction travaille sur une COPIE de i.

            class1.increaseRef(ref i);      //ici avec ref on passe une reference de i a la fonction et elle travaille 
            Console.WriteLine(i);           // sur le meme i que celui du main.


            //  ici la value est bien changee car c'est un ojet
            
            /*
            var cls = new class1(5);
            Console.WriteLine(cls.value);
            ChangeValue(0, cls);
            Console.WriteLine(cls.value);
            NewObject(cls);                  // CA MARCHE PAS ! Pourquoi ? un objet est une "reference a tout ce qu'il contient"
            Console.WriteLine(cls.value);   //  mais il n'est lui meme pas passe en ref. 
                                           //   on ne peut pas changer sa valeur mais seulement la valeur de ce qu'il contient

            */

            //  les objets eux sont toujours passes en references, les listes aussi 
            //  (plus ou moins tous les types qui ne sone pas "juste une valeur" sont passes par reference)
            //  on peut verfier en essayant d'assigner la valeur null a la variable, si cest possible alors il est passe en ref
            //  google pointeurs si tu veux comprendre. (null est une valeur que l'on ne peut donner qu'a un pointeur, d'ou le test precedent)
            /*
            int a;
            a = null;                           //erreur
            List<int> lst = new List<int>();
            lst = null;                         //pas d'erreur
            */



            //  voir la fonction, l'operateur YIELD est utilise pour cree l'enumerable
            /*
            var list = class1.makeIEnum(5, 10);
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
            */

            // ++b => b est incremente AVANT l'evaluation
            // ++b => b est incremente APRES l'evaluation
            /*
            int b = 4;
            while (b++ < 5)         // b++ => on evalue (4 < 5) qui est true puis b est incremente, ++b on incremente b et on evalue (5 < 5) qui est false
            {
                Console.WriteLine(b);
            }
            */


            // l'operateur OUT est similaire a l'operateur REF. la valeur passee a min et max ds la fonction persistera ici.
            // l'on s'en sert pour denoter une Sortie (out) de la methode. par exemple deux "sorties" sont ici possibles;
            // ici min et max ne sont pas initialises. pas de probleme avec out, avec ref ca ne marcherait pas.
            /*
            int a = 1;
            int b = 2;
            int c = 3;
            int min;
            int max;
            class1.MinMax(a, b, c, out min, out max);
            Console.WriteLine(min);
            Console.WriteLine(max);
            */

            // CONST = Constante
            // const int a = 4;
            // a = 8; // ERREUR car a est constante

            //  voici un operateur ternaire, 
            //  variable = (expression) ? ValueIfTrue : ValueIfFalse
            //  une des deux values est assignee a la variable en fonction de si l'expression est true ou false
            /*
             int x = 2;
             string str = (x % 2 == 0) ? "pair" : "impair";
             Console.WriteLine(str);
            */
        }
    }
}
