using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace belajarLINQ.ElementAt_ElementAtOrDefault
{
    class Program
    {
        static void Main()
        {
            // Operator Element mengembalikan element tertentu dari suatu collection

            // Contoh ElementAt(), mengembalikan elemen dari indeks yang ditentukan dari koleksi yang diberikan. 
            // Jika indeks yang ditentukan berada di luar kisaran koleksi maka akan di lemparkan "Index out of range exception".
            // Harap dicatat bahwa indeks adalah indeks berbasis nol.

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st element di intList = {0}", intList.ElementAt(0));
            Console.WriteLine("1st element di strList = {0}", strList.ElementAt(0));

            Console.WriteLine("2nd element di intList = {0}", intList.ElementAt(1));
            Console.WriteLine("2nd element di strList = {0}", strList.ElementAt(1));

            // Menggunakan ElementAtOrDefault(), ElementAtOrDefault() akan mengembalikan nilai default dari type data tersebut
            // jika Index yang diberikan out of range
            Console.WriteLine("3rd element di instList = {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd element di strList = {0}", strList.ElementAtOrDefault(2));

            Console.WriteLine("10th element di intList = {0}", intList.ElementAtOrDefault(9)); // <= Mengembalikan 0, karena default dari int adalah 0
            Console.WriteLine("10th Element in strList = {0} - default string value (null)",
                 strList.ElementAtOrDefault(9));// <= Mengembalikan kosong (null), karena default dari string adalah null
        }


    }
}
