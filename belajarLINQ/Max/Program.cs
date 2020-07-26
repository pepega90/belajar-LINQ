using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Max
{
    class Program
    {
        static void Main()
        {
            // Metode Max () mengembalikan elemen numerik terbesar dari koleksi.
            //IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

            //var example1 = intList.Max();
            //Console.WriteLine("Angka terbesar = {0}", example1);

            //// Contoh menggunakan overload
            //var example2 = intList.Max(x => {
            //    if (x % 2 == 0)
            //        return x;
            //    return 0;
            //});

            //Console.WriteLine("Angka genap terbesar = {0}", example2);

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
             };

            // Contoh max() di complex type
            var muridTertua = studentList.Max(x => x.Age);

            Console.WriteLine("Murid tertua = {0}", muridTertua);

            // Dan untuk nilai mencari nilai terkecil di suatu collection, kita bisa menggunakan
            // Min() method. cara kerjanya sama seperti Max() hanya saja mencari nilai terkecil
        }
    }
}
