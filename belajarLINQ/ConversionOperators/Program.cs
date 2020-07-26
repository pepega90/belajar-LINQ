using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.ConversionOperators
{
    class Program
    {
        // Method untuk contoh AsEnumerable & AsQueryable
        static void ReportTypesProperties<T>(T obj)
        {
            Console.WriteLine("Compile-time type = {0}", typeof(T).Name);
            Console.WriteLine("Actual type = {0}", obj.GetType());
        }

        static void Main()
        {
            /* Metode AsEnumerable dan AsQueryable melemparkan atau mengonversi objek sumber ke IEnumerable <T> atau IQueryable <T>.
             */

            Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            };

            //ReportTypesProperties(studentArray);
            //ReportTypesProperties(studentArray.AsEnumerable());
            //ReportTypesProperties(studentArray.AsQueryable());

            // Cast(), cast source objek ke IEnumerable<T>
            //ReportTypesProperties(studentArray.Cast<Student>());

            IList<string> strList = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Three"
                                            };

            // ToArra()
            string[] strArray = strList.ToArray<string>(); // <= konversi list ke array
            // ToList()
            IList<string> list = strArray.ToList<string>(); // <= konversi array ke list

            // Contoh untuk dictionary
            IList<Student> studentList = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
                };

            IDictionary<int, Student> studentDict = studentList.ToDictionary<Student, int>(s => s.StudentID);

            foreach (KeyValuePair<int,Student> item in studentDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    item.Key, item.Value.StudentName);
            }

        }
    }
}
