using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Maison : Batiment
    {
        public int NbPieces { get; set; }
        public int? Surface { get; set; }
        public int? Terrain { get; set; }

        public Maison()
        {

        }

        public Maison(string adresse, int nbpieces)
            : base(adresse)
        {
            NbPieces = nbpieces;
        }

        public Maison(string adresse, int nbpieces, int surface, int terrain)
            : base(adresse)
        {
            NbPieces = nbpieces;
            Surface = surface;
            Terrain = terrain;
        }

        public override string ToString()
        {
            //return base.ToString();

            int m2 = 0;

            string ToString = "L'adresse de la maison est \"" + Adresse + "\"\n";
            ToString+="Elle a " + NbPieces + " pièce" + (NbPieces > 1 ? "s\n" : "");
            ToString += Surface.HasValue ? "Sa surface est de " + Surface + "m²\n" : "";
            ToString += Terrain.HasValue ? "Elle a un joli terrain de " + Terrain + "m² piscinable\n" : "";
            return ToString;

        }
    }
}
