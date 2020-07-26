using belajarLINQ.Contains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Distinct
{
    class Program
    {
        static void Main()
        {
            // Distinct(), mengembalikan koleksi baru elemen unik dari koleksi yang diberikan.
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

            IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

            //var disticnt1 = strList.Distinct();
            //foreach (var item in disticnt1)
            //{
            //    Console.WriteLine(item);
            //}

            //var distinct2 = intList.Distinct();
            //foreach (var item in distinct2)
            //{
            //    Console.WriteLine(item);
            //}

            // Distinct(), untuk complex type. kita harus melakukan inherit ke interface IEqualityComparer dan impelement methodnya
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            var distinctStudents = studentList.Distinct(new StudenComparer());

            foreach (var item in distinctStudents)
            {
                Console.WriteLine(item.StudentName);
            }
        }
    }
}
