using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.QuerySyntax
{
    class Program
    {
        static void Main()
        {
            // Query syntax pada linq
            // from <range variabel> in <IEnumerable<T> or <IQueryable<T> Collection>
            // <standard query operator> <lambda expression>
            // select or group by operator <result formation>


            IList<string> stringList = new List<string>()
            {
                "C# Tutorial",
                "Javascript Tutorial",
                "C++",
                "Kotlin"
            };


            // Contoh query syntax pada linq
            var result = from tutor in stringList
                         where tutor.Contains(" Tutorial")
                         select tutor;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };


            var muridMuda = from murid in studentList
                            where murid.Age > 12 && murid.Age < 20
                            select murid;

            foreach (var item in muridMuda)
            {
                Console.WriteLine("Nama = {0}, umur = {1}", item.StudentName, item.Age);
            }

            /* Kesimpulan
             * 1. Seperti namanya, Sintaks Kueri sama seperti sintaks SQL (Bahasa Struktur Query).
             * 2. Sintaks Kueri dimulai dengan from klausa dan dapat diakhiri dengan klausa Select atau GroupBy.
             * 3. Gunakan berbagai operator lain seperti memfilter, join, grouping, menyortir operator untuk menyusun hasil yang diinginkan.
             * 4. Implicity variabel "var" bisa digunakan untuk menyimpan hasil dari LINQ Query
             */

        }
    }
}
