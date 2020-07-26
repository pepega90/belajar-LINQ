using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Take_TakeWhile
{
    class Program
    {
        static void Main()
        {
            // Take () mengembalikan jumlah elemen yang ditentukan mulai dari elemen pertama.
            //IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            //var newList = strList.Take(2);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            // TakeWhile () mengembalikan elemen dari koleksi yang diberikan hingga kondisi yang ditentukan benar. 
            // Jika elemen pertama itu sendiri tidak memenuhi syarat maka mengembalikan koleksi kosong.
            IList<string> strList = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six"  };

            var result = strList.TakeWhile(s => s.Length > 4);

            // Overload Kedua dari method TakeWhile()
            var overloadResult = strList.TakeWhile((s, i) => s.Length > i);
            foreach (var item in overloadResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
