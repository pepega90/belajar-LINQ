using belajarLINQ.Contains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Except
{
    class Program
    {
        static void Main()
        {
            /* Metode Except () membutuhkan dua koleksi. 
             * Ini mengembalikan koleksi baru dengan elemen dari koleksi pertama yang tidak ada di koleksi kedua (pengumpulan parameter).
             */

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Except(strList2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Contoh Except() pada complex type
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

            var studentResult = studentList1.Except(studentList2, new StudenComparer());

            foreach (var item in studentResult)
            {
                Console.WriteLine(item.StudentName);
            }
        }
    }
}
