using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le matricule de l'employé : ");
            string matricule = Console.ReadLine();
            Console.Write("Entrer le prenom de l'employé : ");
            string prenom = Console.ReadLine();
            Console.Write("Entrer le nom de l'employé : ");
            string nom = Console.ReadLine();
            Console.Write("Entrer la date de naissance de l'employé (AAAA-MM-JJ) : ");
            string naissance = Console.ReadLine();
            Console.Write("Entrer la date d'embauche de l'employé (AAAA-MM-JJ) : ");
            string embauche = Console.ReadLine();
            Console.Write("Entrer le salaire de l'employé : ");
            double salaire = Convert.ToDouble(Console.ReadLine());

            Employe ouvrier = new Employe(matricule, nom, prenom, naissance, embauche, salaire);

            Console.WriteLine(ouvrier.ToString());

            Console.ReadKey();
        }
    }
}
