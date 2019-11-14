using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Article
    {
        // attributs + getter/setter
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Category categorie { get; set; }

        // constructeur
        public Article(string nom, double prix, string desc)
        {
            this.Name = nom;
            this.Price = prix;
            this.Description = desc;
        }
        public Article(string nom, double prix, string desc, Category cat)
        {
            this.Name = nom;
            this.Price = prix;
            this.Description = desc;
            this.categorie = cat;
        }

        public void afficherArticle()
        {
            Console.WriteLine("{0} | {1} | {2} | {3}", this.Name, this.Price, this.Description, this.categorie);
        }
    }
}
