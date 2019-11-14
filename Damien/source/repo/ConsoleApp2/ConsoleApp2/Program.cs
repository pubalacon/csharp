using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilisation d'une liste
            Console.WriteLine("Utilisation d'une liste");
            List<Article> listeArticles= new List<Article>();

            listeArticles.Add(new Article("P001", 12.50, "Ceci est le produit P001", Category.Maison));
            listeArticles.Add(new Article("P002", 8.80, "Ceci est le produit P002", Category.Hygiene));
            listeArticles.Add(new Article("P003", 25.80, "Ceci est le produit P003", Category.Animalerie));

            foreach (Article produit in listeArticles)
            {
                //Console.WriteLine("{0}, {1}, {2}", produit.Name, produit.Price, produit.Description);
                
                produit.afficherArticle();
            }
            Console.ReadKey();

            // Utilisation d'un indexeur
            Console.WriteLine("Utilisation d'un indexeur");
            ListeArticles indexeur = new ListeArticles(listeArticles.Count);

            // copie de la liste ci-dessus dans l'indexeur
            int idx = 0;
            foreach (Article produit in listeArticles)
            {
                indexeur[idx] = produit;
                idx++;
            }

            // deroulé de l'indexeur
            for (int i = 0; i < indexeur.nbArticles; i++)
            {
                Console.WriteLine($"A l'index {i} de l'indexeur on a l'article {indexeur[i].Name}");
            }

            Console.ReadKey();
        }
    }


}
