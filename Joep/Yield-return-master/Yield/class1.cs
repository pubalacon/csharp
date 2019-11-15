using System;
using System.Collections.Generic;
using System.Text;

namespace Yield
{
    class class1
    {

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
