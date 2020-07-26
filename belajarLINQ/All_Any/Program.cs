using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.All_Any
{
    class Program
    {
        static void Main()
        {
            /* All operator mengevaluasi setiap elemen dalam koleksi yang diberikan pada kondisi tertentu dan mengembalikan True jika semua elemen memenuhi suatu kondisi.
             */

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            // checks whether all the students are teenagers    
            //bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

            //Console.WriteLine(areAllStudentsTeenAger);

            /* Any, memeriksa apakah ada elemen yang memenuhi kondisi tertentu atau tidak
             */

            bool isYoung = studentList.Any(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(isYoung);
        }
    }
}
