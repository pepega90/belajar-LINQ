using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Skip_SkipWhile
{
    class Program
    {
        static void Main()
        {
            // Skip(), melewatkan jumlah elemen yang ditentukan mulai dari elemen pertama dan mengembalikan elemen-elemen lainnya.
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six" };

            var newList = strList.Skip(2);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            /* SkipWhile(), lewati elemen dalam koleksi hingga kondisi yang ditentukan benar.
             * Ini mengembalikan koleksi baru yang mencakup semua elemen yang tersisa setelah kondisi yang ditentukan menjadi salah untuk elemen apa pun.
             */

            var newList2 = strList.SkipWhile(x => x.Length < 4);

            // Contoh overload kedua dari SkipWhile()
            var newList3 = strList.SkipWhile((s, i) => s.Length > i);
            foreach (var item in newList3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
