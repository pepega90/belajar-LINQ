using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace belajarLINQ.Count
{
    class Program
    {
        static void Main()
        {
            /* Operator Count mengembalikan jumlah elemen dalam koleksi atau
             * jumlah elemen yang telah memenuhi kondisi yang diberikan.
             */

            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50 };

            //// Contoh untuk mendapatkan jumlah seluruh element
            //var totalElement = intList.Count();

            //Console.WriteLine("Total element = {0}", totalElement);

            //// Contoh dimana kita menggunakan overload kedua dari count method
            //// disini kita ingin mendapatkan seluruh element genap
            //var elementGenap = intList.Count(i => i % 2 == 0);

            //Console.WriteLine("Total element genap = {0}", elementGenap);

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Mathew", Age = 15 }
             };

            // Contoh operator Count() pada complex type
            var jumlahMurid = studentList.Count();

            Console.WriteLine("Jumlah seluruh murid = {0}", jumlahMurid);

            var muridDiatas18Tahun = studentList.Count(x => x.Age > 18);

            Console.WriteLine("Jumlah murid di atas 18 tahun = {0}", muridDiatas18Tahun);

            /* Count() tidak support untuk query syntax, tapi kita bisa membungkus kueri ke dalam tanda kurung dan menggunakan fungsi agregasi
             */

            var totalMurid = (from s in studentList
                         select s.Age).Count();

            Console.WriteLine(totalMurid);
        }
    }
}
