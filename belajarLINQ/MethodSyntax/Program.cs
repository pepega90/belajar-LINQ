using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.MethodSyntax
{
    class Program
    {
        static void Main()
        {
            /* Method syntax, atau yang biasa disebut fluent API, menggunakan metode ekstensi yang termasuk dalam kelas statis Enumerable atau Queryable, 
             * mirip dengan cara Anda memanggil metode ekstensi kelas apa pun.
             */

            // Contoh method syntax 
            IList<string> stringList = new List<string>()
            {
                 "C# Tutorials",
                    "VB.NET Tutorials",
                    "Learn C++",
                    "MVC Tutorials" ,
                    "Java"
            };


            var result = stringList.Where(e => e.Contains("Tutorials"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
