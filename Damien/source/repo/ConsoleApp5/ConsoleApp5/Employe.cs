using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Employe : Personne
    {
        public string Matricule { get; set; }
        public DateTime DateEmbauche { get; set; }
        public double Salaire { get; set; }

        public Employe(string matricule, string nom, string prenom, string datenaissance, string dateembauche, double salaire)
            : base(nom, prenom, datenaissance)
        {
            Matricule = matricule;
            DateEmbauche = Convert.ToDateTime(dateembauche);
            Salaire = salaire;
        }

        public DateTime DateJour()
        {
            return DateTime.Today;
        }

        public int Age()
        {
            TimeSpan diff = DateJour() - DateNaissance;
            return (int) diff.TotalDays / 365;
        }

        public int Anciennete()
        {
            TimeSpan diff = DateJour() - DateEmbauche;
            return (int) diff.TotalDays / 365;
        }

        public override string ToString()
        {
            string sep = "\n";
            string str = "Matricule: " + Matricule + sep + base.ToString() + sep + "Age : "+ Age() + sep + "Ancienneté : " + Anciennete() + sep + "Salaire : " + Salaire;
            return str;
        }

    }
}
