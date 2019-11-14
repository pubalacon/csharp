using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsCSharp
{
    class Program
    {
        static string HelloWorld()
        {
            return "Hello World !";
        }

        static int GetProduit(int a, int b)
        {
            return a*b;
        }

        static bool checkPHP(String s)
        {
            return s.Contains("PHP");
        }

        static int findString(String needle, string Haystack)
        {
            return Haystack.IndexOf(needle, 0);
        }

        static int howManyWords(String s)
        {
            int count = 0;
            s = s.Replace("  ", " ").Trim();

            if (!string.IsNullOrEmpty(s))
            {
                int offset = s.IndexOf(" ", 0);
                
                while (offset != -1)
                {
                    count++;
                    offset = s.IndexOf(" ", offset+1);
                }
            }
            if (count > 0) count++; // si on a au moins un espace, alors on a au moins 2 mots

            return count;
        }

        static string[] stringToArray(String s)
        {
            int count = 0;
            String[] a = { };

            s = s.Replace("  ", " ").Trim();

            if (!string.IsNullOrEmpty(s))
            {
                String[] delimitor = { " " };
                a = s.Split(delimitor, howManyWords(s), StringSplitOptions.RemoveEmptyEntries);
            }

            return a;
        }

        static int operateFromConsole()
        {
            int a = 0, b = 0, result=0;
            string input = "";
            string[] operators = { "*", "+", "-", "%", "|" };

            Console.Write("1er nombre: ");
            input = Console.ReadLine();
            a = Convert.ToInt32(input);

            Console.Write("2eme nombre: ");
            input = Console.ReadLine();
            b = Convert.ToInt32(input);


            if (b == 0)
            {
                operators = operators.Take(operators.Length - 2).ToArray();
            }

            Console.Write($"operateur parmi {String.Join(",", operators)}: ");

            input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && operators.Contains(input))
            {
                switch (input)
                {
                    case "*":
                        result = a * b;
                        break;
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "%":
                        result = a % b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Hello World
            //Console.WriteLine(HelloWorld());

            // Produit de 2 nombres
            //int a = 10, b = 20;
            //Console.WriteLine(GetProduit(a,b));

            // check si chaine contient PHP
            //String s = "Ceci n'est pas du PHP";
            //String s = "Ceci n'est pas du C#";
            //Console.WriteLine(checkPHP(s) ? "OK" : "KO");

            //String needle = "bon", haystack = "abonbon";
            //String needle = "bon", haystack = "salut";
            //Console.WriteLine(findString(needle, haystack));
            //Console.WriteLine(findString(needle, haystack));

            //String s = "Ceci est une phrase avec des mots séparés par des espaces";
            //String s = "";
            //String s = "  blanc  noir  gris ";
            //Console.WriteLine(howManyWords(s));

            /*
            String s = "hey ma men";
            String[] a = stringToArray(s);
            foreach(String w in a)
            {
                Console.WriteLine(w);
            }
            */

            Console.WriteLine(operateFromConsole());

            Console.ReadKey();
        }
    }
}
