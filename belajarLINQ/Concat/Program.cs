using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Concat
{
    class Program
    {
        static void Main()
        {
            /* Concat() menambahkan dua urutan dari tipe yang sama dan mengembalikan urutan baru (koleksi).
             */

            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection3 = collection1.Concat(collection2);

            foreach (var item in collection3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
