using belajarLINQ.Contains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.SequenceEqual
{
    class Program
    {
        static void Main()
        {
            /* Metode SequenceEqual (mengembalikan boolean) memeriksa apakah jumlah elemen, nilai setiap elemen, dan urutan elemen dalam dua koleksi sama atau tidak.
             Jika koleksi berisi elemen tipe data primitif maka ia membandingkan nilai dan jumlah elemen, 
             sedangkan koleksi dengan elemen tipe kompleks, memeriksa referensi objek
             */

            //IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            //IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            //bool isSama = strList1.SequenceEqual(strList2);
            //Console.WriteLine(isSama);

            // Contoh pada complex type
            //Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            //IList<Student> studentList1 = new List<Student>() { std };
            //IList<Student> studentList2 = new List<Student>() { std };

            //bool isEqual = studentList1.SequenceEqual(studentList2); // <= mengembalikan true

            //Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
            //Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };

            //IList<Student> studentList3 = new List<Student>() { std1 };
            //IList<Student> studentList4 = new List<Student>() { std2 };

            //bool isEqual2 = studentList3.SequenceEqual(studentList4); // <= mengembalikan false

            // Contoh Untuk membandingkan value type dari 2 buah collection yang berbeda
            IList<Student> studentList1 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            IList<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            bool isEqual3 = studentList1.SequenceEqual(studentList2, new StudenComparer());

            Console.WriteLine(isEqual3);
        }
    }
}
