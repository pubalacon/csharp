using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Notions
{
    class Indexer
    {
        private int[] Array { get; set; }
        public Indexer(int capacity)
        {
            Array = new int[capacity];
        }
        public int this[int i]          // c'est cette declaration qui fait un Indexer
        {
            get { return (Array[i]); }
            set { Array[i] = value; }
        }

        public static void Indexer_main()
        {
            Indexer ind = new Indexer(5);
            ind[4] = 7;
            Console.WriteLine(ind[4]);
        }
    }
}
