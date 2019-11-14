using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parc_Animalier
{
    class myRandom
    {
        public string getRandom()
        {
            var r3 = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var r4 = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] b1 = new byte[1];
            byte[] b2 = new byte[1];

            string r = "";

            for (var i = 0; i < 4; i++)
            {
                r3.GetBytes(b1);
                r4.GetBytes(b2);
                r += b1[0] + "" + b2[0];
            }
            return r;
        }
    }
}
