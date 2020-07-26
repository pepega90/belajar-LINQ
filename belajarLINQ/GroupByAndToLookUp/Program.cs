using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.GroupBy
{
    class Program
    {
        static void Main()
        {
            /*
             *  Operator pengelompokan melakukan hal yang sama dengan klausa SQL dari GroupBy. 
             *  Operator pengelompokan membuat grup elemen berdasarkan pada kunci yang diberikan
             *  Grup ini terkandung dalam jenis koleksi khusus yang mengimplementasikan antarmuka IGrouping <TKey, TSource> di mana TKey adalah nilai kunci, 
             *  di mana grup telah dibentuk dan TSource adalah kumpulan elemen yang cocok dengan nilai kunci pengelompokan
             */

            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
                };

            // Contoh query syntax group by
            //var groupByResult = from s in studentList
            //                    // Kita grouping berdasarkan umur
            //                    group s by s.Age;

            //foreach (var item in groupByResult)
            //{
            //    Console.WriteLine("Umur = {0}", item.Key);

            //    foreach (var name in item)
            //    {
            //        Console.WriteLine(name.StudentName);
            //    }
            //}

            //Contoh method syntax
            //var groupByAgeMethodSyntax = studentList.GroupBy(e => e.Age);

            //foreach (var item in groupByAgeMethodSyntax)
            //{
            //    Console.WriteLine("Murid dengan umur = {0}", item.Key);
            //    foreach (var name in item)
            //    {
            //        Console.WriteLine(name.StudentName);
            //    }
            //}

            // Contoh ToLookUp (ToLookUp hanya bisa digunakan di method syntax)
            // Sama seperti GroupBy, perbedanya adalah cara eksekusinya
            // Jika GroupBy ditangguhkan, sedangkah ToLookUp secara langsung
            var toLookUpResult = studentList.ToLookup(e => e.Age);

            //studentList.Add(new Student() { StudentName = "pepega", Age = 21, StudentID = 6 });

            foreach (var item in toLookUpResult)
            {
                Console.WriteLine(item.Key);
                foreach (var name in item)
                {
                    Console.WriteLine(name.StudentName);
                }
            }
        }
    }
}
