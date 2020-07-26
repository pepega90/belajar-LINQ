using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Select
{
    class Program
    {
        static void Main()
        {
            /* Operator Select selalu mengembalikan koleksi IEnumerable yang berisi elemen berdasarkan fungsi transformasi. 
             * Ini mirip dengan klausa Select SQL yang menghasilkan set hasil datar.
             */

            IList<Student> studentList = new List<Student>() {
                 new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            //var example = from s in studentList
            //              select s;


            /* Operator Select dapat digunakan untuk merumuskan hasil sesuai kebutuhan kita. 
             * Ini dapat digunakan untuk mengembalikan koleksi kelas khusus atau jenis anonim yang mencakup properti sesuai kebutuhan kita.
             */
            // Contoh dibawah, dimana kita membuat anonimousy properti untuk menyimpan nama dan umur
            var example2 = from s in studentList
                           select new { Nama = s.StudentName, Umur = s.Age };


            // Contoh method syntax
            var example3 = studentList.Select(s => new { Nama = s.StudentName, Umur = s.Age });

            foreach (var item in example3)
            {
                Console.WriteLine(item.Nama + " dan umur = " + item.Umur);
            }

        }
    }
}
