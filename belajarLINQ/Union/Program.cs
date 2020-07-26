using belajarLINQ.Contains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Union
{
    class Program
    {
        static void Main()
        {
            // Metode ekstensi Union() memerlukan dua koleksi dan mengembalikan koleksi baru yang mencakup elemen berbeda dari kedua koleksi
            IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
            IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };

            var result = strList1.Union(strList2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Union pada complex type
            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var resultedCol = studentList1.Union(studentList2, new StudenComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentName);
        }
    }
}
