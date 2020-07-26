using belajarLINQ.Contains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Intersect
{
    class Program
    {
        static void Main()
        {
            /* Metode ekstensi Intersect() memerlukan dua koleksi. 
             * Ini mengembalikan koleksi baru yang mencakup elemen umum yang ada di kedua koleksi. 
             */
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Intersect(strList2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

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

            var resultedCol = studentList1.Intersect(studentList2, new StudenComparer());

            foreach (Student std in resultedCol)
                Console.WriteLine(std.StudentName);
        }
    }
}
