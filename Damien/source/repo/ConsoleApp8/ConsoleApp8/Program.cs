/*
 * reprise du projet Calculette avec utilisation des delegate
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        public static double Additionne(int A, int B)
        {
            return A + B;
        }
        public static double Soustrait(int A, int B)
        {
            return A - B;
        }
        public static double Multiplie(int A, int B)
        {
            return A * B;
        }
        public static double DiviseInt(int A, int B)
        {
            return A / B;
        }
        public static double DiviseFloat(int A, int B)
        {
            return (float)A / B;
        }
        public static double Modulo(int A, int B)
        {
            return A % B;
        }
        static string RepeatCar(string car, int max)
        {
            string ret = "";
            for (int i = 0; i < max; i++)
            {
                ret += car;
            }
            return ret;
        }

        static void AfficheMenu(string [,] menu, int x, int y)
        {
            int longueur = 34;

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Vos nombres: A={x} et B={y}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < menu.GetLength(0); i++)
            {
                Console.WriteLine($"| {i + 1}: {menu[i, 1]}{RepeatCar(" ", (longueur - 6 - menu[i, 1].Length))}|");
            }

            Console.WriteLine("| Autre: Quitter                 |");
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("| Votre choix:                   |");
            Console.WriteLine("----------------------------------");

        }

        public delegate double Calcul(int x, int y);

        static void Main(string[] args)
        {
            /* CALCULATRICE */
            int choix = 0;
            int x = 9, y = 2;
            string input = "";

            string[,] menu = { 
                { "+", "Addition" }, 
                { "-", "Soustraction" }, 
                { "*", "Multiplication" }, 
                { "/", "Division entiere" }, 
                { "/", "Division avec decimale" }, 
                { "%", "Modulo" }, 
                { "", "Modifier les nombres A et B" } 
            };

            AfficheMenu(menu, x, y);

            Calcul calcule = Additionne;

            while (choix >= 0 && choix < 8)
            {
                AfficheMenu(menu, x, y);

                try
                {
                    //choix = Convert.ToInt32(Console.ReadLine());
                    input = Console.ReadLine();
                    if (String.IsNullOrEmpty(input))
                    {
                        throw new EmptyStringException(input);
                    }
                    choix = Convert.ToInt32(input);

                    switch (choix)
                    {
                        case 1:
                            calcule = Additionne;
                            Console.Write($"A+B = ");
                            break;
                        case 2:
                            calcule = Soustrait;
                            Console.Write($"A-B = ");
                            break;
                        case 3:
                            calcule = Multiplie;
                            Console.Write($"A*B = ");
                            break;
                        case 4:
                            calcule = DiviseInt;
                            if (y == 0)
                            {
                                throw new DivisionException(y);
                            }
                            Console.WriteLine($"A/B = ");
                            break;
                        case 5:
                            calcule = DiviseFloat;
                            if (y == 0)
                            {
                                throw new DivisionException(y);
                            }
                            Console.WriteLine($"A/B = ");
                            break;
                        case 6:
                            calcule = Modulo;
                            Console.WriteLine($"A%B = ");
                            break;
                        case 7:
                            Console.Write("Entrer le premier nombre: ");
                            x = System.Convert.ToInt32(Console.ReadLine());
                            Console.Write("Entrer le deuxieme nombre: ");
                            y = System.Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            break;
                    }

                    if (choix > 0 && choix < 8) Console.WriteLine(calcule(x, y));
                }
                catch (Exception e) when (e is DivisionException)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
