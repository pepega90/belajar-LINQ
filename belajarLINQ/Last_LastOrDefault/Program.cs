using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace belajarLINQ.Last_LastOrDefault
{
    class Program
    {
        static void Main()
        {
            /* Last() dan LastOrDefautl(), mengembalikan elemen terakhir dari koleksi, atau elemen terakhir yang memenuhi kondisi yang ditentukan menggunakan ekspresi lambda atau delegasi Func
             */

            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            //Console.WriteLine("Last Element in intList: {0}", intList.Last());

            //Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

            //Console.WriteLine("Last Element in strList: {0}", strList.Last());

            //Console.WriteLine("emptyList.Last() throws an InvalidOperationException");
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine(emptyList.Last());

            // Contoh untuk LastOrDefault()

            Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

            Console.WriteLine("Last Even Element in intList: {0}",
                                             intList.LastOrDefault(i => i % 2 == 0));

            Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());

            Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault());
        }
    }
}
