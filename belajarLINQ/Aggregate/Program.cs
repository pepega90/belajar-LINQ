
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace belajarLINQ.Aggregate
{
    class Program
    {
        static void Main()
        {
            //  Metode Agregat melakukan operasi akumulasi
            //IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            //var pisahDenganKoma = strList.Aggregate((s1, s2) => s1 + "," + s2);

            //Console.WriteLine(pisahDenganKoma);


            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
             };

            // Contoh method aggregate dengan seed value

            //string muridDipisahDenganKoma = studentList.Aggregate<Student, string>("Nama Murid: ",
            //    (str, s) => str += s.StudentName + ",");

            //int sumOfAllStudent = studentList.Aggregate<Student, int>(0, (totalAge, s) => totalAge += s.Age);

            //Console.WriteLine(muridDipisahDenganKoma);

            //Console.WriteLine(sumOfAllStudent);

            // Contoh method aggregate dengan result selector

            string removeLastKoma = studentList.Aggregate<Student, string, string>(string.Empty,
                                    (str, student) => str += student.StudentName + ",",
                                    finalStr => finalStr.Substring(0, finalStr.Length - 1));

            Console.WriteLine(removeLastKoma);
        }
    }
}
