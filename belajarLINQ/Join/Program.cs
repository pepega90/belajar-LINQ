using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace belajarLINQ.Join
{
    class Program
    {
        static void Main()
        {
            /* Operator Join  beroperasi pada dua koleksi, koleksi dalam & koleksi luar. 
             * Ini mengembalikan koleksi baru yang berisi elemen dari kedua koleksi yang memenuhi ekspresi yang ditentukan.
             * Ini sama dengan Inner Join pada SQL.
             */

            // Contoh berikut menggabungkan dua koleksi string dan mengembalikan koleksi baru yang mencakup string yang cocok di kedua koleksi.
            IList<string> stringList1 = new List<string>()
            {
               "One",
                "Two",
                "Three",
                "Four"
            };


            IList<string> strList2 = new List<string>() {
                "One",
                "Two",
                "Five",
                "Six"
            };

            // Cara kerjanya mirip seperti inner join, dimana kita mengembalikan hasil collection baru
            // yang sama di kedua collection
            //var example = stringList1.Join(strList2,
            //                str1 => str1,
            //                str2 => str2,
            //                (str1, str2) => str1);


            //foreach (var item in innjerJoin)
            //{
            //    Console.WriteLine(item);
            //}

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            // Contoh dimana kita melakukan join berdasarkan Id yang sama di kedua collection
            // Contoh method syntax
            //var example2 = studentList.Join(standardList,
            //                murid => murid.StandardID,
            //                stan => stan.StandardID,
            //                (murid, stan) => new
            //                {
            //                    StudentName = murid.StudentName,
            //                    StandardName = stan.StandardName
            //                });


            /*
             *  Operator Join dalam sintaks kueri bekerja sedikit berbeda dari sintaksis metode. 
             *  Ini membutuhkan urutan luar, urutan dalam, pemilih kunci dan pemilih hasil. 
             *  kata kunci 'on' digunakan untuk pemilih kunci di mana sisi kiri operator 'equals' adalah outerKeySelector dan sisi kanan 'equals' adalah innerKeySelector.
             */

            /* Query syntax Operator Join
             * from ... in outerSequence

                join ... in innerSequence  

                on outerKey equals innerKey

                select ...
             */
            // Contoh query syntax operator Join
            var example3 = from murid in studentList // outer collection
                           join stan in standardList // inner collection
                           on murid.StandardID equals stan.StandardID // key selector
                           select new
                           {
                               // Result selector
                               StudentName = murid.StudentName,
                               StandardName = stan.StandardName
                           };

            foreach (var item in example3)
            {
                Console.WriteLine("Name = {0} -- Standard = {1}", item.StudentName, item.StandardName);
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
