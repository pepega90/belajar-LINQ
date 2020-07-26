using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace belajarLINQ.ThenBy
{
    class Program
    {
        static void Main()
        {
            // Metode ekstensi ThenBy dan ThenByDescending digunakan untuk mengurutkan pada beberapa bidang.
            /*
             *  Metode OrderBy () mengurutkan koleksi dalam urutan naik berdasarkan bidang yang ditentukan
             *  Gunakan metode ThenBy () setelah OrderBy untuk mengurutkan koleksi di bidang lain dalam urutan menaik
             *  Linq pertama-tama akan mengurutkan koleksi berdasarkan bidang primer yang ditentukan oleh metode OrderBy dan kemudian mengurutkan koleksi yang dihasilkan dalam urutan naik lagi berdasarkan bidang sekunder yang ditentukan oleh metode ThenBy.
             *  ThenBy atau ThenByDescending digunakan untuk penyortiran level kedua dalam sintaks metode.
             *  ThenBy atau ThenByDescending TIDAK berlaku dalam sintaks Query.
             */

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };

            // ThenBy, mengurutkan secara naik (ascending) by default
            var thenByResult = studentList.OrderBy(e => e.StudentName).ThenBy(e => e.Age);

            // ThenByDescending, mengurutkan secara menurut (descending)
            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            foreach (var item in thenByDescResult)
            {
                Console.WriteLine("Name = {0}, and age = {1}", item.StudentName, item.Age);
            }

        }
    }
}
