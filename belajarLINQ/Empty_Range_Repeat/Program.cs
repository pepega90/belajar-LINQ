using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Empty_Range_Repeat
{
    class Program
    {
        static void Main()
        {
            /* Metode Empty, Range & Repeat bukan metode ekstensi untuk IEnumerable atau IQueryable tetapi mereka hanya metode static yang didefinisikan dalam kelas static Enumerable.
             */

            // Empty(), mengembalikan koleksi kosong dari tipe tertentu seperti yang ditunjukkan di bawah ini.

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            //Console.WriteLine("Type = {0}", emptyCollection1.GetType().Name);
            //Console.WriteLine("Count = {0}", emptyCollection1.Count());

            //Console.WriteLine("Type = {0}", emptyCollection2.GetType().Name);
            //Console.WriteLine("Count = {0}", emptyCollection2.Count());

            // Range(),  mengembalikan koleksi tipe <T> IEnumerable dengan jumlah elemen dan nilai sekuensial yang dimulai dari elemen pertama.
            var intCollection = Enumerable.Range(1, 10);
            Console.WriteLine("Jumlah element = {0}", intCollection.Count());

            //for (int i = 0; i < intCollection.Count(); i++)
            //{
            //    Console.WriteLine("Nilai di index {0} = {1}", i , intCollection.ElementAt(i));
            //}

            // Repeat(), menghasilkan kumpulan tipe <T> IEnumerable dengan jumlah elemen yang ditentukan dan masing-masing elemen mengandung nilai yang sama.
            var intRepeatCollection = Enumerable.Repeat("C# is Awesome", 5);
            Console.WriteLine("Jumlah element = {0}", intRepeatCollection.Count());

            for (int i = 0; i < intRepeatCollection.Count(); i++)
            {
                Console.WriteLine("Elemen di index {0} = {1}", i, intRepeatCollection.ElementAt(i));
            }
        }
    }
}
