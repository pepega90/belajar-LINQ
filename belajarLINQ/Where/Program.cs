using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Where
{
    class Program
    {
        static void Main()
        {
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            //// Where, digunakan untuk memfilter collection berdasarkan ekspresi kriteria yang diberikan dan mengembalikan koleksi baru

            //var filterTeenName = from murid in studentList
            //                where murid.Age > 12 && murid.Age < 20
            //                select murid.StudentName;

            //foreach (var item in filterTeenName)
            //{
            //    Console.WriteLine("Nama = {0}", item);
            //}

            //// Kita bisa gunakan delegate, untuk memfilter
            //Func<Student, bool> isTeenager = delegate(Student s)
            //{
            //    return s.Age > 12 && s.Age < 20;
            //};


            var filterAge = from murid in studentList
                            where isMuda(murid)
                            select murid;

            foreach (var item in filterAge)
            {
                Console.WriteLine("name = {0}, age = {1}", item.StudentName, item.Age);
            }

            // Overload kedua dari where, adalah index setiap element

            //var result = studentList.Where((e, i) => {
            //    if (i % 2 == 0)
            //        return true;
            //    return false;
            //});


            // Kita bisa menggunakan lebih dari satu where klause di single LINQ query
            //var result = from s in studentList
            //             where s.Age > 12
            //             where s.Age < 20
            //             select s;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.StudentName);
            //}

        }

        //Bisa juga kita membuat method, yang memilki signature yang sama dengan delegate
        public static bool isMuda(Student s)
        {
            return s.Age > 12 && s.Age < 20;
        }
    }
}
