using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace belajarLINQ.GroupJoin
{
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

    class Program
    {
        static void Main()
        {
            /* Operator GroupJoin melakukan tugas yang sama dengan operator Join,
             * kecuali bahwa GroupJoin mengembalikan hasil dalam grup berdasarkan kunci grup yang ditentukan
             */

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron" }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            // Contoh method syntax
            //var example1 = standardList.GroupJoin(studentList,
            //                stan => stan.StandardID,
            //                murid => murid.StandardID,
            //                (stan, murid) => new
            //                {
            //                    Murid = murid,
            //                    StandardName = stan.StandardName
            //                });

            //foreach (var item in example1)
            //{
            //    Console.WriteLine(item.StandardName);
            //    foreach (var muridName in item.Murid)
            //    {
            //        Console.WriteLine(muridName.StudentName);
            //    }
            //}

            // GroupJoin query syntax mirip-mirip seperti operator Join
            // Gunakan kata kunci "into" untuk membuat koleksi yang dikelompokkan
            // Syntax:
            /*
             * from ... in outerSequence

                join ... in innerSequence  

                on outerKey equals innerKey

                into groupedCollection    

                select ...
             */

            var example2 = from stan in standardList
                           join murid in studentList
                           on stan.StandardID equals murid.StandardID
                           into studenGroup
                           select new
                           {
                               Murid = studenGroup,
                               StandardName = stan.StandardName
                           };

            foreach (var item in example2)
            {
                Console.WriteLine(item.StandardName);
                foreach (var student in item.Murid)
                {
                    Console.WriteLine(student.StudentName);
                }
            }

        }
    }
}
