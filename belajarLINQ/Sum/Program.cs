using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Sum
{
    class Program
    {
        static void Main()
        {
            //  Metode Sum () menghitung jumlah item numerik dalam koleksi.

            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            //var sumElement = intList.Sum();

            //Console.WriteLine("Total = {0}", sumElement);

            //var sumElementGenap = intList.Sum(x => {
            //    if (x % 2 == 0)
            //        return x;
            //    return 0;
            //});

            //Console.WriteLine("Total sum element Genap = {0}", sumElementGenap);

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
             };

            // Contoh sum di complex type
            var totalSumAge = studentList.Sum(x => x.Age);

            Console.WriteLine("Total sum of age = {0}", totalSumAge);

            var totalAdultAge = studentList.Sum(x =>
            {
                if (x.Age >= 18)
                    return 1;
                else
                    return 0;
            });

            Console.WriteLine("Total sum of adult student = {0}", totalAdultAge);
        }
    }
}
