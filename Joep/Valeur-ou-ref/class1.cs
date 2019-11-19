using System;
using System.Collections.Generic;
using System.Text;

namespace Yield
{
    class class1
    {
        //switch case
        //in

        public int value { get; set; }

        public static void increase(int a)
        {
            a = a + 1;
        }
        public static void increaseRef(ref int a)
        {
            a = a + 1;
        }


        public class1(int val) => value = val;


        public static int Max(int a, int b, int c)
        {
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }
        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
        public static void MinMax(int a, int b, int c, out int min, out int max)
        {
            //max = max + 1;    //  ceci provoque une erreur car les parametres passes en out ne sont pas forcement initialises, 
            min = Min(a, b, c); //  ils ne doivent servir qu'a stocker une "sortie" de la fonction
            max = Max(a, b, c);

        }

        public static void swap(ref int a, ref int b) //un usage classique des refs
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static IEnumerable<int> makeIEnum(int start, int end)
        {
            while (start < end)
            {
                yield return start;  //le yield return n'arrete pas la fonction comme return
                                    // tous les yield returns successifs sont ajoutes a l'Ienumerable que la fonction retourne
                start++;
            }
        }
    }
}
