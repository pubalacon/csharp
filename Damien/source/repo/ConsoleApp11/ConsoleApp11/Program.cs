/*
Au sein d’une déclaration de struct, les champs ne peuvent pas être initialisés à moins d’être déclarés comme étant de type const ou static.
Un struct ne peut pas déclarer de constructeur sans paramètre ni de finaliseur.
Les structs sont copiés lors de l'assignation. Lorsqu'un struct est assigné à une nouvelle variable, toutes les données sont copiées et les modifications apportées à la nouvelle copie ne changent pas les données de la copie d'origine. Il est important de vous en souvenir quand vous utilisez des collections de types valeur telles que Dictionary<string, myStruct>.
Les structs sont des types valeur, contrairement aux classes, qui sont des types référence.
Contrairement aux classes, il est possible d’instancier les structs sans avoir recours à un opérateur new.
Les structs peuvent déclarer des constructeurs qui ont des paramètres.
Un struct ne peut pas hériter d'un autre struct ou d'une classe; il ne peut pas non plus servir de base à une classe.Tous les structs héritent directement de ValueType, qui hérite de Object.
Un struct peut implémenter des interfaces.
Un struct ne peut pas être null, et une variable de struct ne peut pas être assignée null, sauf si la variable est déclarée en tant que type valeur Nullable.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum eValeurs { Valeur1, Valeur2, Valeur3, Valeur4 };

namespace ConsoleApp11
{

    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            // parcourir tableau
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach (int i in numbers)
            {
                count++;
                System.Console.WriteLine($"Element #{count}: {i} ");
            }
            Console.WriteLine($"Number of elements: {numbers.Length}");

            Console.ReadKey();

            // parcourir list
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 1, 13 };
            fibNumbers.Add(22);
            fibNumbers.Add(5);
            fibNumbers.RemoveAt(3);
            count = 0;
            foreach (int element in fibNumbers)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Element de valeur 1: {fibNumbers.IndexOf(1)}");
            Console.WriteLine($"Element de valeur 1 à partir de la position 3: {fibNumbers.IndexOf(1,3)}");
            Console.WriteLine($"Number of elements: {count}");
            
            Console.ReadKey();

            // parcourir enum
            count = 0;
            foreach (eValeurs element in Enum.GetValues( typeof(eValeurs)))
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");

            Console.ReadKey();
        }

    }
}




