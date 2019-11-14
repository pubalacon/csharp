using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public 
        static void Main(string[] args)
        {
            string inNom = "", inPrenom = "";
            int inAge = 0, inNote = 0;
            string inTest = "";

            Console.WriteLine("Saisie de la note d'un élève");
            Console.WriteLine("----------------------------");

            try
            {
                Console.Write("Nom: ");
                //inNom = Console.ReadLine();
                inTest = Console.ReadLine();
                if (String.IsNullOrEmpty(inTest))
                {
                    throw new EmptyStringException(inTest);
                }
                inNom = inTest;

                Console.Write("Prénom: ");
                //inPrenom = Console.ReadLine();
                inTest = Console.ReadLine();
                if (String.IsNullOrEmpty(inTest))
                {
                    throw new EmptyStringException(inTest);
                }
                inPrenom = inTest;

                Console.Write("Age: ");
                //inAge = Convert.ToInt32(Console.ReadLine());
                inTest = Console.ReadLine();
                if (!int.TryParse(inTest, out inAge))
                {
                    throw new InvalidAgeException(inAge);
                }
                inAge = Convert.ToInt32(inTest);

                if (inAge < 18 || inAge > 26)
                {
                    throw new InvalidAgeException(inAge);
                }

                Console.Write("Note: ");
                //inNote = Convert.ToInt32(Console.ReadLine());
                inTest = Console.ReadLine();
                if (!int.TryParse(inTest, out inNote))
                {
                    throw new InvalidAgeException(inNote);
                }
                inNote = Convert.ToInt32(inTest);

                if (inNote < 0 || inNote > 20)
                {
                    throw new InvalidNoteException(inNote);
                }

                Eleve unEleve = new Eleve(inNom, inPrenom, inAge, inNote);

                Console.WriteLine("Contrôle de la saisie");
                Console.WriteLine("---------------------");

                Console.WriteLine(unEleve.afficher());
            }
            catch (Exception e) when (e is InvalidAgeException || e is InvalidNoteException || e is EmptyStringException)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            // delai visu
            Console.ReadKey();

        }
    }
}
