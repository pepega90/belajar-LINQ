using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace belajarLINQ.Average
{
    class Program
    {
        static void Main()
        {
            /* Method Average(), menghitung rata-rata item numerik dalam koleksi
             * mengembalikan nilai decimal nullable atau non-nullable, double atau float.
             */

            // Contoh average di primitive type
            //IList<int> intList = new List<int>() { 10, 20, 30 };

            //var rataRata = intList.Average();

            //Console.WriteLine("Rata-rata = {0}", rataRata);

            // Contoh average di complex type
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
             };

            var rataRataUmur = studentList.Average(x => x.Age);

            Console.WriteLine("Rata-rata umur murid = {0}", rataRataUmur);
        }
    }
}
