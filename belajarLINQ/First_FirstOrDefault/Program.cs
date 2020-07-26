using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.First_FirstOrDefault
{
    class Program
    {
        static void Main()
        {
            /* Metode First dan FirstOrDefault mengembalikan elemen dari indeks nol dalam koleksi yaitu elemen pertama.
             * Juga, ini mengembalikan elemen yang memenuhi kondisi yang ditentukan.
             */

            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            //Console.WriteLine("Element pertama di intList = {0}", intList.First());
            //// First dan FirstOrDefault memiliki overload kedua, yang berupa predicate
            //Console.WriteLine("Element genap pertama di intList = {0}", intList.First(x => x % 2 == 0));

            //Console.WriteLine("Element pertama di strList = {0}", strList.First());

            // Jika kita menggunakan First() dan listnya kosong maka akan melempar exception
            // InvalidOperationException
            //Console.WriteLine("Contoh untuk list kosong pada First() method");
            //Console.WriteLine(emptyList.First());

            // Contoh penggunaan FirstOrDefault()
            Console.WriteLine("Element pertama di intList = {0}", intList.FirstOrDefault());
            // First dan FirstOrDefault memiliki overload kedua, yang berupa predicate
            Console.WriteLine("Element genap pertama di intList = {0}", intList.FirstOrDefault(x => x % 2 == 0));

            Console.WriteLine("Element pertama di strList = {0}", strList.FirstOrDefault());

            // sedangkan untuk FirstOrDefault() dan listnya kosong tidak akan melempar InvalidOperationException
            // melainkan mengembalikan default value
            //Console.WriteLine("Contoh untuk list kosong pada FirstOrDefault() method");
            //Console.WriteLine(emptyList.FirstOrDefault());
        }
    }
}
