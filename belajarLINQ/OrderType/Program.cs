using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.OrderType
{
    class Program
    {
        static void Main()
        {
            // OrderBy menyortir nilai-nilai koleksi dalam urutan naik atau turun (defaultnya adalah secara naik atau ascending)

            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } ,
    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
};

            // Contoh urutan ascending (menaik)
            var ascendingSort = from s in studentList
                                orderby s.StudentName
                                select s;

            // Contoh urutan descending (menurun)
            var descendingSort = from s in studentList
                                 orderby s.StudentName descending
                                 select s;


            // Menggunakan extension method untuk urutan  naik (ascending)
            var studentInAsc = studentList.OrderBy(s => s.StudentName);

            // Menggunakan extension method untuk urutan turun (descending)
            var studentInDesc = studentList.OrderByDescending(s => s.StudentName);


            // Multiple sorting
            var orderByResult = from s in studentList
                                orderby s.StudentName, s.Age
                                select new { s.StudentName, s.Age };

            foreach (var item in orderByResult)
            {
                Console.WriteLine("student name = {0}, age = {1}", item.StudentName, item.Age);
            }
        }
    }
}
