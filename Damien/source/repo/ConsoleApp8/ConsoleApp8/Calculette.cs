using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Calculette
    {
        public static int A { get; set; }
        public static int B { get; set; }

        public Calculette(int x, int y)
        {
            A = x;
            B = y;
        }
        public static double Additionne()
        {
            return A + B;
        }
        public static double Soustrait()
        {
            return A - B;
        }
        public static double Multiplie()
        {
            return A * B;
        }
        public static double DiviseInt()
        {
            return A / B;
        }
        public static double DiviseFloat()
        {
            return (float)A / B;
        }
        public static double Modulo()
        {
            return A % B;
        }

    }
}
