using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.OfType
{
    class Program
    {
        static void Main()
        {
            // Operator OfType memfilter koleksi memfilter koleksi berdasarkan tipe yang diberikan
            IList mixList = new ArrayList();
            mixList.Add(0);
            mixList.Add("Aji");
            mixList.Add("Two");
            mixList.Add(2);
            mixList.Add(new Student() { StudentName = "aji", Age = 12, StudentID = 2 });


            // Memfilter berdasarkan tipe data string
            var stringType = from str in mixList.OfType<string>()
                             select str;

            // Memfilter berdasarkan tipe data int
            var intType = from num in mixList.OfType<int>()
                          select num;

            // Memfilter berdasarkan tipe data Student
            var studentType = from s in mixList.OfType<Student>()
                              select s;

            // Memfilter berdasarkan tipe data string dengan method extension
            var result = mixList.OfType<string>();

            foreach (var item in intType)
            {
                Console.WriteLine(item);
            }
        }
    }
}
