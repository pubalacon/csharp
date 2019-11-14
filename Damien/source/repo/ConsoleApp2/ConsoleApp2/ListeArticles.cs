using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ListeArticles
    {
        public int nbArticles { get; set; }
        private Article[] Articles;

        public ListeArticles(int i)
        {
            Articles = new Article[i];
            nbArticles = 0; 
        }

        public Article this[int i]
        {
            get { return Articles[i]; }

            set { Articles[i] = value; nbArticles++; }

        }
    }
}
