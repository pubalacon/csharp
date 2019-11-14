/*
Le but est de créer une petite application qui affiche un message différent en fonction du nom de l’utilisateur et du moment de la journée :
Bonjour XXX pour la tranche horaire 9h <-> 18h, les lundi, mardi, mercredi, jeudi et vendredi
Bonsoir XXX pour la tranche horaire 18h <-> 9h, les lundi, mardi, mercredi, jeudi
Bon week-end XXX pour la tranche horaire vendredi 18h <-> lundi 9h
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {

        static void testeConnexion()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            int heureConnexion = DateTime.Now.Hour;
            int jourConnexion = (int)DateTime.Now.DayOfWeek;

            //string name = "olivier";
            //jourConnexion = 1; heureConnexion = 18;

            if ((jourConnexion < 1 || jourConnexion > 5) || (jourConnexion == 1 && heureConnexion < 9) || (jourConnexion == 5 && heureConnexion >= 18))
            {
                Console.WriteLine($"Have a nice week-end {name}");

            }
            else if ((jourConnexion >= 1 && jourConnexion < 5 && (heureConnexion >= 18 || heureConnexion < 9)) || (jourConnexion == 5 && heureConnexion < 5))
            {
                Console.WriteLine($"Good afternoon {name}");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }
        }

        // Pour testDebug()
        static int CalculSommeIntersection()
        {
            List<int> multiplesDe3 = new List<int>();
            List<int> multiplesDe5 = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    multiplesDe3.Add(i);
                if (i % 5 == 0)
                    multiplesDe5.Add(i);
            }

            int somme = 0;
            foreach (int m3 in multiplesDe3)
            {
                foreach (int m5 in multiplesDe5)
                {
                    if (m3 == m5)
                        somme += m3;
                }
            }
            return somme;
        }
        static void testDebug()
        {
            Console.WriteLine(CalculSommeIntersection());
        }

        static void minusPlusGame()
        {
            int minValue = 0, maxValue = 100;
            int valeurATrouver = new Random().Next(minValue, maxValue);
            int saisie = -1, count = 0, maxTry = 10;
            string input = "";
            bool trouve = false;

            Console.WriteLine("Vous dever trouver le nombre magique choisi par votre adversaire");
            Console.WriteLine($"il est compris entre {minValue} et {maxValue}");
            Console.WriteLine("Si on vous indique \"Chaud\", le nombre à trouver est plus grand");
            Console.WriteLine("Si on vous indique \"Froid\", le nombre à trouver est plus petit");
            Console.WriteLine($"Vous avez {maxTry} essai !");

            do
            {
                count++;
                Console.Write($"{(count == 1 ? "1er" : count + "ième")} essai: ");

                //saisie = Convert.ToInt32(Console.ReadLine());
                input = Console.ReadLine().ToLower();

                if (int.TryParse(input, out saisie))
                {
                    if (saisie < minValue || saisie > maxValue)
                    {
                        Console.WriteLine($"Attention, le nombre à trouver est compris entre {minValue} et {maxValue}");
                    }
                    else if (saisie == valeurATrouver)
                    {
                        trouve = true;
                        break;
                    }
                    else if (saisie > valeurATrouver)
                    {
                        Console.WriteLine("Chaud");
                    }
                    else
                    {
                        Console.WriteLine("Froid");
                    }
                }
                else if (input == "q")
                {
                    saisie = 999;
                    break;
                }
                else
                {
                    Console.WriteLine($"Saisie incorrecte, vous devez choisir un nombre compris entre {minValue} et {maxValue}");
                }


            } while (count < maxTry && saisie != valeurATrouver && saisie != 999);

            Console.WriteLine($"Le nombre à trouver était {valeurATrouver}");

            if (trouve)
            {
                Console.WriteLine($"Bravo, vous avez trouvé au {(count == 1 ? "1er" : count + "ième")} essai");
            }
            else if (saisie == 999)
            {
                Console.WriteLine($"Dommage, vous avez abandonné au {(count == 1 ? "1er" : count + "ième")} essai");
            }
            else
            {
                Console.WriteLine("Bien tenté, peut-être aurez vous plus de chance la prochaine fois !");

            }
        }

        static void testKeyboard()
        {
            Console.Write("Veuillez saisir un caractère au clavier (q)uit ");

            string modifier = "";
            ConsoleKeyInfo cki;

            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            do
            {
                cki = Console.ReadKey(true);
                Console.WriteLine();

                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) modifier = "ALT+";
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) modifier = "SHIFT+";
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) modifier = "CTL+";

                if (cki.Key == ConsoleKey.Q || cki.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Quitting...");
                }
                else
                {
                    Console.WriteLine($"Votre saisie: {modifier}{cki.Key.ToString()}");
                }
                modifier = "";
            }
            while (cki.Key != ConsoleKey.Q && cki.Key != ConsoleKey.Escape);
        }

        static void testArgs(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"parametre {i}: {args[i]}");
            }

        }

        static void testBuffer()
        {
            int i = 0;
            int j = 0;
            int largeur = 21;
            int hauteur = 4;
            Console.WriteLine(@"      .--------.");
            Console.WriteLine(@" ____/_____|___ \___");
            Console.WriteLine(@"O    _   - |   _   ,*");
            Console.WriteLine(@" '--(_)-------(_)--'");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (i > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
                            i--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (i < Console.WindowWidth - largeur)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
                            i++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (j > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i, j - 1);
                            j--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.MoveBufferArea(i, j, largeur, hauteur, i, j + 1);
                        j++;
                        break;
                }
                if (info.Key == ConsoleKey.Q)
                    break;
            }

        }

        static void testBuffer2()
        {
            string sprite = "";
            sprite += "     *     \n";
            sprite += "   * * *   \n";
            sprite += " *  ***  * \n";
            sprite += "   * * *   \n";
            sprite += "     *     \n";

            int largeur = 11;
            int hauteur = 5;
            int x = 0, y = 0;

            int wWidth = Console.WindowWidth;
            int wHeight = Console.WindowHeight;

            int i = wWidth / 2 - largeur / 2;
            int j = wHeight / 2 - hauteur / 2;

            string couloir = "";

            int idx2 = 0;

            do
            {
                for (int idx1 = 0; idx1 < wWidth; idx1++)
                {
                    if (idx1 < i-1) couloir += " ";
                    else if (idx1 == i-1) couloir += "|";
                    else if (idx1 >= i && idx1 < i + largeur) couloir += " ";
                    else if (idx1 == i + largeur) couloir += "|";
                    else if (idx1 > i + largeur) couloir += " ";

                }
                //couloir += "\n";

                Console.Write(couloir);
                couloir = "";
                idx2++;

            } while (idx2 < wHeight);

            Console.SetCursorPosition(0, 0);

            Console.Write(sprite);
            


            
            // center sprite
            Console.MoveBufferArea(x, y, largeur, hauteur, i, j);

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (i > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
                            i--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (i < wWidth - largeur)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
                            i++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (j > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i, j - 1);
                            j--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (j < wHeight - hauteur)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i, j + 1);
                            j++;
                        }
                        break;
                }
                if (info.Key == ConsoleKey.Q)
                    break;
            }


        }
        static void Main(string[] args)
        {
            //testeConnexion();
            //testDebug();
            //minusPlusGame();
            //testKeyboard();
            // testArgs(args) //parametres ligne commande (args)
            // testBuffer();
            testBuffer2();
            //Console.Clear();

            Console.ReadKey();
        }
    }
}
