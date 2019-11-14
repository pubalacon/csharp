using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Color { Red, Green, Blue }
public enum JourSemaine { Dimanche, Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi }

public enum Role
{
    Administrator = 1,
    Publisher = 2,
    ChiefEditor = 3,
    Editor = 4,
    Unknown = 5
}
public enum Gender
{
    Male = 1,
    Female = 2,
    Unknown = 3
}

namespace ConsoleApp1
{
    public class Employee
    {
        public string Name { get; set; }
        public Role Role { get; set; }
    }
    public class Student
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
    class Program
    {
        static int Additionne(int x, int y)
        {
            return x + y;
        }

        static int Soustrait(int x, int y)
        {
            return x - y;
        }

        static int Multiplie(int x, int y)
        {
            return x * y;
        }

        static int Divise(int x, int y)
        {
            return x / y;
        }

        static float Divisefloat(int x, int y)
        {
            return (float)x / y;
        }

        static int Modulo(int x, int y)
        {
            return x % y;
        }


        static void EstNull()
        {
            // NULL OU NON NULL ?
            int? x = null; // pour initialiser a nul un type nullable, on ajoute ?
            if (x.HasValue)
            {
                Console.WriteLine(($"x a la valeur {x}"));
            }
            else
            {
                Console.WriteLine(($"x n'a pas de valeur"));
            }
            Console.WriteLine(x.GetType());
        }

        static void MonAge()
        {
            Console.WriteLine("Entrez votre age: ");
            int age=System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sérieux ? Vous ne faites vraiment pas {age}");
        }

        static void Dessin()
        {
            Console.Write("Entrez un caractere SVP: ");
            string car = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("{0}{0}{0}", car);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} {0}", car);
            }
            Console.WriteLine("{0}{0}{0}", car);
            
            Console.WriteLine();

            Console.Write("Entrez un caractere SVP: ");
            string car2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{car2}{car2}{car2}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{car2} {car2}");
            }
            Console.WriteLine($"{car2}{car2}{car2}");
        }

        static void SommeMultipleTrois()
        {
            int sum=0;
            for (int i=0; i<21;i++) 
            {
                if (i%3==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"somme: {sum}");
        }

        static void PostPreInc()
        {
            int i = 2;
            int j = i++;

            Console.WriteLine($"Apres l'instruction int i=2;int j=i++; i={i} et j={j}");
            Console.ReadKey();

            i = 2;
            j = ++i;

            Console.WriteLine($"Apres l'instruction int i=2;int j=++i; i={i} et j={j}");
        }

        static void EgaliteNum()
        {
            // EGALITE ?

            int x = 0, y = 0;
            Console.WriteLine("Entrer le premier nombre:");
            x = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer le deuxieme nombre:");
            y = System.Convert.ToInt32(Console.ReadLine());

            if (x==y)
            {
                Console.WriteLine($"{x} et {y} sont égaux\n");
            }
            else
            {
                Console.WriteLine($"{x} et {y} ne sont pas égaux\n");
            }
        }

        static void OddEven()
        {
            // PAIR OU IMPAIR

            int result, oddeven;
            for (int i=0; i<4; i++)
            {
                oddeven = 0;
                Console.WriteLine($"Votre nombre >0 : ");
                oddeven = System.Convert.ToInt32(Console.ReadLine());
                if (oddeven==oddeven)
                { 
                    if (oddeven % 2 == 0)
                    {
                        Console.WriteLine($"{oddeven} est pair");
                    }
                    else
                    {
                        Console.WriteLine($"{oddeven} est impair");
                    }   
                }
                else
                {
                    Console.WriteLine("Votre nombre doit etre >0");
                }
            }
        }

        static void IsPositiv()
        {
            // ENTIER POSITIF OU NEGATIF ?

            int saisie;
            for (int i = 0; i < 4; i++)
            {
                saisie = 0;
                Console.WriteLine($"Votre nombre : ");
                saisie = System.Convert.ToInt32(Console.ReadLine());
                if (saisie == 0)
                {
                    Console.WriteLine($"{saisie} est nul");
                }
                else if (saisie > 0)
                {
                    Console.WriteLine($"{saisie} est positif");
                }
                else
                {
                    Console.WriteLine($"{saisie} est negatif");
                }
            }
            Console.WriteLine("Fin");
        }

        static void IsBissextile()
        {
            // ANNEE BISSEXTILE ?

            int saisie;
            for (int i = 0; i < 4; i++)
            {
                saisie = 0;
                Console.WriteLine($"Année : ");
                saisie = System.Convert.ToInt32(Console.ReadLine());
                if ( saisie % 400==0 || (saisie % 4==0 && saisie % 100 > 0))
                {
                    Console.WriteLine($"{saisie} est bissextile");
                }
                else
                {
                    Console.WriteLine($"{saisie} n'est pas bissextile");
                }
            }
            Console.WriteLine("Fin");
        }
        static void MaxNombre()
        {
            int n1, n2, n3, max;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"1er nombre : ");
                n1 = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"2eme nombre : ");
                n2 = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"3eme nombre : ");
                n3 = System.Convert.ToInt32(Console.ReadLine());
                if (n1 >= n2 && n1 >= n3)
                {
                    max = n1;
                }
                else
                {
                    if (n2 >= n3)
                    {
                        max = n2;
                    }
                    else
                    {
                        max = n3;
                    }
                }
                Console.WriteLine($"{max} est le plus grand nombre");
            }
            Console.WriteLine("Fin");

        }

        static void PeutVoter()
        {
            // UTILISATEUR PEUT IL VOTER

            int saisie;
            for (int i = 0; i < 4; i++)
            {
                saisie = 0;
                Console.WriteLine($"Votre age : ");
                saisie = System.Convert.ToInt32(Console.ReadLine());
                if (saisie >= 18)
                {
                    Console.WriteLine($"A {saisie} ans, vous pouvez voter");
                }
                else
                {
                    Console.WriteLine($"A {saisie} ans, vous ne pouvez pas voter");
                }
            }
            Console.WriteLine("Fin");
        }

        static string RepeatCar(string car, int max)
        {
            string ret = "";
            for (int i=0; i< max; i++)
            {
                ret+=car;
            }
            return ret;
        }
        static void Calculette()
        {
            /* CALCULATRICE */
            int x = 2, y = 4;
            int choix = 0;

            while(choix>=0 && choix<8)
            {
                int longueur = 34;
                string[] titres = {"Addition", "Soustraction", "Multiplication","Division entiere","Division avec decimale","Modulo","Modifier les nombres A et B"};

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Vos nombres: A={x} et B={y}");
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                /*
                Console.WriteLine($"| 1: Addition                    |");
                Console.WriteLine($"| 2: Soustraction                |");
                Console.WriteLine($"| 3: Multiplication              |");
                Console.WriteLine($"| 4: Division entiere            |");
                Console.WriteLine($"| 5: Division avec decimale      |");
                Console.WriteLine($"| 6: Modulo                      |");
                Console.WriteLine($"| 7: Modifier les nombres A et B |");
                */

                for (int i = 0; i < titres.Length; i++)
                {
                    Console.WriteLine($"| {i+1}: {titres[i]}{RepeatCar(" ", (longueur - 6 - titres[i].Length))}|");
                }

                Console.WriteLine($"| Autre: Quitter                 |");
                Console.WriteLine("|--------------------------------|");
                Console.WriteLine("| Votre choix:                   |");
                Console.WriteLine("----------------------------------");

                choix = System.Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        //Console.WriteLine($"{x + y}"); // affiche 7
                        Console.WriteLine($"A+B = {Additionne(x,y)}"); // affiche 7
                        break;
                    case 2:
                        Console.WriteLine($"A-B = {Soustrait(x,y)}"); // affiche 3
                        break;
                    case 3:
                        Console.WriteLine($"A*B = {Multiplie(x,y)}"); // affiche 10
                        break;
                    case 4:
                        if (y > 0)
                        {
                            Console.WriteLine($"A/B = {Divise(x,y)}"); // affiche 2
                        }
                        else
                        {
                            Console.WriteLine("Pour la division, y doit etre superieur a 0");
                        }
                        break;
                    case 5:
                        if (y > 0)
                        {
                            Console.WriteLine($"A/B = {Divisefloat(x,y)}"); // affiche 2,5
                        }
                        else
                        {
                            Console.WriteLine("Pour la division, y doit etre superieur a 0");
                        }
                        break;
                    case 6:
                        Console.WriteLine($"A%B = {Modulo(x,y)}"); // affiche 1
                        break;
                    case 7:
                        Console.WriteLine("Entrer le premier nombre: ");
                        x = System.Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre: ");
                        y = System.Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        break; //
                }

            }
        }

        static void RepartieSaisie()
        {
            int n =0;
            while (n != 999)
            { 
                Console.Write($"Votre nombre (999 pour Quitter): ");
 
                n = System.Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine("Résultat de votre saisie: 1");
                }
                else if (n == 0)
                {
                    Console.WriteLine("Résultat de votre saisie: 0");
                }
                else
                {
                    Console.WriteLine("Résultat de votre saisie: -1");
                }
            }

        }

        static void MaTaille()
        {
            int n = 0;
            while (n != -1)
            {
                Console.Write($"Votre nombre (-1 pour Quitter): ");

                n = System.Convert.ToInt32(Console.ReadLine());
                Console.Write($"{n} cm: ");
                if (n > 180)
                {
                    Console.WriteLine("Que vous êtes grand mon ami(e)!");
                }
                else if (n > 150)
                {
                    Console.WriteLine("Pas mal mais peu mieux faire");
                }
                else
                {
                    Console.WriteLine("Reprends encore un peu de soupe, ça aide !!!");
                }
            }

        }

        static void Couleur()
        {
            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:

                    Console.WriteLine("The color is unknown.");
                    break;
            }

        }

        static void NumJourSemaine()
        {

            string[] Jours = { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" }; // pour mode=3
            int n = 0;
            int mode = 2;

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)); 
            Console.BackgroundColor = colors[12]; Console.ForegroundColor = colors[15];

            Console.WriteLine($"Le mode est {mode} (0: normal, 1: enum, 2: tableau)");
            Console.ResetColor();
            while (n != 7)
            {
                Console.Write($"Votre numéro de jour entre 0 et 6 (Autre pour Quitter): ");

                n = System.Convert.ToInt32(Console.ReadLine());

                switch (mode)
                {
                    case 0:
                        switch (n)
                        {
                            case 0:
                                Console.WriteLine($"le jour {n} est le Dimanche");
                                break;
                            case 1:
                                Console.WriteLine($"le jour {n} est le Lundi");
                                break;
                            case 2:
                                Console.WriteLine($"le jour {n} est le Mardi");
                                break;
                            case 3:
                                Console.WriteLine($"le jour {n} est le Mercredi");
                                break;
                            case 4:
                                Console.WriteLine($"le jour {n} est le Jeudi");
                                break;
                            case 5:
                                Console.WriteLine($"le jour {n} est le Vendredi");
                                break;
                            case 6:
                                Console.WriteLine($"le jour {n} est le Samedi");
                                break;
                            default:
                                break;

                        }
                        break;

                    case 1:
                        switch ((JourSemaine)n)
                        {
                            case JourSemaine.Dimanche:
                                Console.WriteLine($"le jour {n} est le dimanche");
                                break;
                            case JourSemaine.Lundi:
                                Console.WriteLine($"le jour {n} est le lundi");
                                break;
                            case JourSemaine.Mardi:
                                Console.WriteLine($"le jour {n} est le mardi");
                                break;
                            case JourSemaine.Mercredi:
                                Console.WriteLine($"le jour {n} est le mercredi");
                                break;
                            case JourSemaine.Jeudi:
                                Console.WriteLine($"le jour {n} est le jeudi");
                                break;
                            case JourSemaine.Vendredi:
                                Console.WriteLine($"le jour {n} est le vendredi");
                                break;
                            case JourSemaine.Samedi:
                                Console.WriteLine($"le jour {n} est le samedi");
                                break;
                            default:
                                break;

                        }
                        break;

                    case 2:
                        Console.WriteLine($"le jour {n} est le {Jours[n]}");
                        break;

                    default:
                        break;
                }

            }

        }

        static void NumMoisAnnee()
        {
            int n = 0;
            string[] Mois = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};

            while (n < 12)
            {
                Console.Write($"Votre numéro de mois entre 0 et 11 (Autre pour Quitter): ");

                n = System.Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 1:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 2:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 3:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 4:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 5:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 6:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 7:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 8:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 9:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 10:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    case 11:
                        Console.WriteLine($"le mois {n} est {Mois[n]}");
                        break;
                    default:
                        break;

                }
             }
        }
        static void Aire()
        {
            int choix = 1;
            string objet = "cercle";
            double aire = 0;

            while (choix > 0 && choix < 6)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Choissez votre figure:");
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"| 1: Cercle                      |");
                Console.WriteLine($"| 2: Carré                       |");
                Console.WriteLine($"| 3: Rectangle                   |");
                Console.WriteLine($"| 4: Triangle                    |");
                Console.WriteLine($"| 5: Losange                     |");
                Console.WriteLine($"| Autre: Quitter                 |");
                Console.WriteLine("|--------------------------------|");
                Console.WriteLine("| Votre choix:                   |");
                Console.WriteLine("----------------------------------");

                choix = System.Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.Write("Rayon du cercle: ");
                        double R = System.Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"L'aire du cercle est {Math.PI * Math.Pow(R, 2)}");
                        break;

                    case 2:
                        Console.Write("Côté du carré: ");
                        double C = System.Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"L'aire du carré est {Math.Pow(C, 2)}");
                        break;

                    case 3:
                        Console.Write("1er Côté du rectangle: ");
                        double C1 = System.Convert.ToDouble(Console.ReadLine());
                        Console.Write("2eme Côté du rectangle: ");
                        double C2 = System.Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"L'aire du rectangle est {C1 * C2}");
                        break;

                    case 4:
                        Console.Write("Base du triangle: ");
                        double B = System.Convert.ToDouble(Console.ReadLine());
                        Console.Write("Hauteur du triangle: ");
                        double H = System.Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"L'aire du triangle est {(B * H) / 2}");
                        break;

                    case 5:
                        Console.Write("1ere Diagonale du losange: ");
                        double D1 = System.Convert.ToDouble(Console.ReadLine());
                        Console.Write("2eme Diagonale du losange: ");
                        double D2 = System.Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"L'aire du losange est {(D1 * D2) / 2}");
                        break;

                    default:
                        break;
                }

            }
        }

        static void NombresNaturels(int nb)
        {
            string sep;
            for(int i=1; i<nb; i++)
            {
                sep = i > 1 ? ", "  : "";
                Console.Write($"{sep}{i}");
            }
            Console.WriteLine();
        }

        static void SumNombresNaturels(int nb)
        {
            string sep;
            int sum = 0;
            for (int i = 1; i < nb; i++)
            {
                sep = i > 1 ? ", " : "";
                Console.Write($"{sep}{i}");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"La somme est: {sum}");
        }

        static void MoyNombresNaturels(double nb)
        {
            string sep;
            double sum = 0;
            for (double i = 1; i < nb; i++)
            {
                sep = i > 1 ? ", " : "";
                Console.Write($"{sep}{i}");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"La somme est: {sum}");
            Console.WriteLine($"La moyenne est: {sum/(nb - 1)}");
        }

        static void DessineTriangle(int nb)
        {
            for (int i=0; i<nb; i++)
            {
                Console.WriteLine($"{RepeatCar("*", i)}");
            }
        }

        static void DessineTriangle2(int nb)
        {
            string str = "";
            for (int i = 0; i < nb; i++)
            {
                str += System.Convert.ToString(i + 1);
                Console.WriteLine($"{str}");
            }
        }

        static void DessineDemiDiamant(int nb)
        {
            string str="";
            for (int i = 0; i < nb; i++)
            {
                str += "*";
                Console.WriteLine($"{str}");
            }
            str = "";
            for (int i = nb - 1; i >= 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    str += "*";
                    
                }
                Console.WriteLine($"{str}");
                str = "";
            }
        }

        static void DessineDiamant(int nb)
        {
            Console.Write("Nombre de rangs du diamant: ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int i, j, k;
            // Haut
            for (i = 1; i <= val; i++)
            {
                // 1ere moitié
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                // 2eme moitié
                for (k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Bas
            for (i = val - 1; i >= 1; i--)
            {
                // 1ere moitié
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                // 2eme moitié
                for (k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static string IterateTableau1Dim(int[] tab)
        {
            string str = "";
            for (int i = 0; i < tab.Length; i++)
            {
                str += tab[i];
            }
            return str;
        }

        static string ArrayOfStringToString(string[] tab)
        {
            string str = "";
            for (int i = 0; i < tab.Length; i++)
            {
                str += tab[i];
            }
            return str;
        }

        static void Array1Dim()
        {
            // unidimensionnel
            int[] tableau1Dim = { 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Console.WriteLine("Tableau:");
            /*
            for (int i = 0; i < tableau1Dim.Length; i++)
            {
                Console.Write(tableau1Dim[i]);
            }
            */
            Console.Write(IterateTableau1Dim(tableau1Dim));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tableau trié:");
            Array.Sort(tableau1Dim);
            /*
            for (int i = 0; i < tableau1Dim.Length; i++)
            {
                Console.Write(tableau1Dim[i]);
            }
            */
            Console.Write(IterateTableau1Dim(tableau1Dim));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Index du 1er \"8\" dans les valeurs");
            Console.WriteLine($"{Array.IndexOf(tableau1Dim, 8)}");
            Console.WriteLine();

            Console.WriteLine("Suppression valeurs des 4 derniers éléments");
            Array.Clear(tableau1Dim, 5, 4);
            /*
            for (int i = 0; i < tableau1Dim.Length; i++)
            {
                Console.Write(tableau1Dim[i]);
            }
            */
            Console.Write(IterateTableau1Dim(tableau1Dim));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Index du 1er \"8\" dans les valeurs");
            Console.WriteLine($"{Array.IndexOf(tableau1Dim, 8)}");
            Console.WriteLine();

            Console.WriteLine("Redim du tableau à 3 elements (les 1ers)");
            Array.Resize(ref tableau1Dim, 3);
            /*
            for (int i = 0; i < tableau1Dim.Length; i++)
            {
                Console.Write(tableau1Dim[i]);
            }
            */
            Console.Write(IterateTableau1Dim(tableau1Dim));

            Console.WriteLine();
        }

        static void Array2Dim()
        {
            // multidimensionnel
            int[,] tableau2Dim = new int[2,2];
            int k=8;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tableau2Dim[i, j] = k;
                    k--;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"{tableau2Dim[i, j]}");
                }
            }


        }

        static string listeToString(List<string> liste)
        {
            string str="";
            liste.ForEach(element => str += element);
            return str;
        }

        private static bool hasPeriod(string word)
        {
            return word.Contains(",");
        }
        static void Liste()
        {
            string sep = " ";
            List<string> maListe = new List<string> {"hello",sep,"everybody"};

            maListe.Add(", it's");
            maListe.Add(sep);
            maListe.Add("time");
            maListe.Add(", time2");
            maListe.Add(", time3");

            // Count
            Console.WriteLine("for + Count:");
            for (int i = 0; i < maListe.Count; i++)
            {
                Console.Write(maListe[i]);
            }
            Console.WriteLine();

            /**/
            Console.WriteLine("foreach"); 
            foreach(string mot in maListe)
            {
                Console.Write(mot);
            }
            Console.WriteLine();

            Console.WriteLine(".ForEach");
            maListe.ForEach(element => Console.Write(element));
            Console.WriteLine();

            Console.WriteLine("Remove");
            maListe.Remove(", time2");
            Console.WriteLine(listeToString(maListe));

            Console.WriteLine("RemoveAt");
            maListe.RemoveAt(maListe.Count-1);
            Console.WriteLine(listeToString(maListe));
            /**/

            Console.WriteLine("IndexOf");
            Console.WriteLine(maListe.IndexOf("time"));

            Console.WriteLine("Contains");
            Console.WriteLine(maListe.Contains("time"));

            Console.WriteLine("Exists(\",\")");
            Console.WriteLine(maListe.Exists(hasPeriod));

            Console.WriteLine("RemoveAll(\",\")");
            maListe.RemoveAll(hasPeriod); // hasPeriod est un Predicat (callback) qui filtre les elements de la liste
            Console.WriteLine(listeToString(maListe));

            string[] tab = maListe.ToArray();
            Console.Write(ArrayOfStringToString(tab));
            Console.WriteLine();

            Console.WriteLine("Sort");
            maListe.Sort();
            Console.WriteLine(listeToString(maListe));

        }
        static void DisplayBitArray(BitArray bitArray)
        {
            for (int i = 0; i < bitArray.Count; i++)
            {
                bool bit = bitArray.Get(i);
                Console.Write(bit ? 1 : 0);
            }
            Console.WriteLine();
        }
        static void MonBitArray()
        {
            BitArray b = new BitArray(8);
            b.Set(0, true);
            b.Set(1, false);
            b.Set(2, false);
            b.Set(3, false);
            b.Set(5, true);
            b.Set(6, true);
            b.Set(7, true);

            DisplayBitArray(b);
        }

        static void MonArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("Bonjour");
            arrayList.Add('c');
            arrayList.Add(8);
            arrayList.Remove('c');
            arrayList.RemoveAt(1);

            foreach (var o in arrayList)
            {
                Console.WriteLine(o);
            }
        }

        static void ExQueue()
        {
            Queue q = new Queue();

            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue("bonjour");
            q.Enqueue(5); 
            q.Dequeue(); // Dequeue le premier element cad 2

            foreach (var o in q)
            {
                Console.WriteLine(o);
            }
        }

        static void ExoArray()
        {
            // lire n nombre valeurs tableau et afficher dans ordre inverse
            Console.Write("Nombre de valeurs du tableau 1: ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] tab1 = new int[n];
            int sum = 0;
            int[] tab2 = new int[n];

            Random rnd = new Random();

            for (int i=0; i<tab1.Length; i++)
            {
                // Entrees manuelles
                /*
                Console.Write("Valeur à enregister: "); 
                tab1[i] = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                */

                /* Entrees au hasard */
                tab1[i] = rnd.Next(1,2*n);
            }

            Console.WriteLine("Contenu du tableau 1:");
            foreach (int elt in tab1)
            {
                Console.Write($"{elt} ");
            }
            Console.WriteLine();

            Array.Reverse(tab1);

            Console.WriteLine("Reverse du tableau 1:");
            foreach (int elt in tab1)
            {
                Console.Write($"{elt} ");
            }
            Console.WriteLine();

            // Somme des elements
            Console.Write("Sommes des elements du tableau 1: ");
            foreach(int elt in tab1)
            {
                sum += elt;
            }

            Console.WriteLine(sum);
            Console.WriteLine();

            // Copie dans un autre tableau
            // en 2 lignes: Array.Copy(tab1, 0, tab2, 0, n); Array.Reverse(tab2);
            for (int i=0; i<n; i++)
            {
                tab2[(n - 1) - i] = tab1[i];
            }

            // Affichage du 2eme tableau
            Console.WriteLine("Copie du tableau 1 dans tableau 2 en reverse et affichage:"); 
            foreach (int elt in tab2)
            {
                Console.Write($"{elt} ");
            }
            Console.WriteLine();
        }

        static void Dictionnaire()
        {
            Dictionary<int, string> dico = new Dictionary<int, string>();
            dico.Add(1, "Entree 1");
            dico.Add(2, "Entree 2");
            dico.Add(3, "Entree 3");

            string str1 = "Le dictionnaire est ";
            string str2 = "complêt !";

            // contient valeur
            //string str3 = dico.ContainsValue("Entree 4") ? "" : "in";

            // contient cle
            string str3 = dico.ContainsKey(4) ? "" : "in";

            Console.WriteLine($"{str1}{str3}{str2}");

            // Traverser le dictionnaire par couple cle/valeur
            foreach (KeyValuePair<int, string> elt in dico)
            {
                Console.WriteLine(elt.Key + ": "+elt.Value);
            }

            // Traverser le dictionnaire par valeur
            foreach (string elt in dico.Values)
            {
                Console.WriteLine(elt);
            }

            // Traverser le dictionnaire par cle
            Dictionary<int, string>.KeyCollection clefs = dico.Keys;
            foreach (int elt in clefs)
            {
                Console.WriteLine(elt);
            }
        }
        
        static void Pile()
        {
            Stack<string> pile = new Stack<string>();
            pile.Push("time");
            pile.Push("it's");
            pile.Push("world");
            pile.Push("hello");

            Console.WriteLine($"Nb elements: {pile.Count}");

            // traverser la pile
            foreach (string elt in pile)
            {
                Console.WriteLine(elt);
            }

            // 1er element
            Console.WriteLine(pile.Peek());

            // Depiler un element (le 1er)
            pile.Pop();
            Console.WriteLine(pile.Peek());

            // Tout depiler (vider)
            pile.Clear();
            if (pile.Count > 0)
            {
                Console.WriteLine(pile.Peek());
            }
            else
            {
                Console.WriteLine("La pile est vide!");
            }
        }

        static void MonEnum()
        {
            Console.WriteLine(Color.Red); // affiche Red
            Console.WriteLine((int)Color.Red); // affiche 0
        }

        static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                case Gender.Unknown:
                    return "Unknown";
                default:
                    return "Invalid Input";
            }
        }

        static void ExStudents()
        {
            Student[] students = new Student[4];
            students[0] = new Student() { Name = "Jhon", Gender = Gender.Male };
            students[1] = new Student() { Name = "Rob", Gender = Gender.Male };
            students[2] = new Student() { Name = "Json", Gender = Gender.Female };
            students[3] = new Student() { Name = "Rebecca", Gender = Gender.Unknown };
            foreach (var student in students)
            {
                Console.WriteLine("Student name is {0} and student gender is :{1}", student.Name, getGender(student.Gender));
            }
            Console.ReadKey();
        }

        static string getRole(Role role)
        {
            switch (role)
            {
                case Role.Administrator:
                    return "Administrator";
                case Role.ChiefEditor:
                    return "Chief Editor";
                case Role.Editor:
                    return "Editor";
                case Role.Publisher:
                    return "Publisher";
                case Role.Unknown:
                    return "Unknown";
                default:
                    return "Invalid Input";
            }
        }

        static void ExRoles()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee() { Name = "John", Role = Role.Administrator };
            employees[1] = new Employee() { Name = "Robbie", Role = Role.Editor };
            employees[2] = new Employee() { Name = "Jason", Role = Role.ChiefEditor };
            employees[3] = new Employee() { Name = "Rebecca", Role = Role.Unknown };
            foreach (var employee in employees)
            {
                //Console.WriteLine("Employee name is {0} and employee's role is :{1}", employee.Name, getRole(employee.Role)); 
                Console.WriteLine("Employee name is {0} and employee's role is :{1}", employee.Name, employee.Role);
            }
            Console.ReadKey();
        }

        static void FindNumber()
        {
            Random rnd = new Random();
            int TargetNumber = rnd.Next(1, 10);
            int UserInput = 0;

            int[] BombNumber = { rnd.Next(1, 20), rnd.Next(1, 20) };

            do
            {
                Console.Write("Trouvez le nombre entre 1 et 20 : ");
                UserInput = System.Convert.ToInt32(Console.ReadLine());

                if (BombNumber.Contains(UserInput))
                {
                    Console.WriteLine($"Oups, {UserInput} vous a explosé à la g.....");
                    break;
                }

                if (UserInput<TargetNumber)
                {
                    Console.Write("Froid...");
                }
                else if (UserInput>TargetNumber)
                {
                    Console.Write("Chaud...");
                }
            }
            while (UserInput != TargetNumber);

            if (UserInput == TargetNumber)
            {
                Console.WriteLine($"Bravo, le nombre à trouver était bien {TargetNumber}");
            }
        }

        static void VerifyNumber()
        {
            int UserInput = 0;

            do
            {
                Console.Write("Entrez un nombre : ");
                UserInput = System.Convert.ToInt32(Console.ReadLine());

            }
            while (UserInput<1 || UserInput>9);

            Console.WriteLine($"Bravo, le nombre est bien entre 1 et 9");
        }
        static void Main(string[] args)
        {

            // EstNull();
            // MonAge();
            // Dessin();
            // SommeMultipleTrois();
            // PostPreInc();
            // EgaliteNum();
            // OddEven();
            // IsPositiv();
            // IsBissextile();
            // MaxNombre();
            // PeutVoter();
            // RepartieSaisie();
            // MaTaille();
            // Couleur();
            // NumJourSemaine();
            // NumMoisAnnee();
            // Aire();
            // Calculette();
            // NombresNaturels(11);
            // SumNombresNaturels(11);
            // MoyNombresNaturels(11);
            // DessineTriangle(5);
            // DessineTriangle2(5);
            // DessineDiamant(11);
            // Array1Dim();
            // Array2Dim();
            // MonBitArray();
            // MonArrayList();
            // ExQueue();
            // Liste();
            // ExoArray();
            // Dictionnaire();
            // Pile();
            // MonEnum();
            // ExStudents();
            // ExRoles();
             FindNumber();
            // VerifyNumber();

            Console.ReadKey();
        }

    }
}
