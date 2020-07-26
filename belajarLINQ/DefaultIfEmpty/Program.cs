using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.DefaultIfEmpty
{
    class Program
    {
        static void Main()
        {
            /* Metode DefaultIfEmpty () mengembalikan koleksi baru dengan nilai default jika koleksi yang diberikan di mana DefaultIfEmpty () dipanggil kosong.
             * Method overload dari DefaultIfEmpty () mengambil parameter nilai yang harus diganti dengan nilai default.
             */

            IList<string> emptyList = new List<string>();

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("Kosong");

            //Console.WriteLine("Count = {0}", newList1.Count());
            //Console.WriteLine("Value = {0}", newList1.ElementAt(0));

            //Console.WriteLine("Count = {0}", newList2.Count());
            //Console.WriteLine("Value = {0}", newList2.ElementAt(0));

            // Contoh DefaultIfEmpty() untuk complex type
            IList<Student> emptyStudentList = new List<Student>();

            var newStudentList1 = emptyStudentList.DefaultIfEmpty(new Student());

            var newStudentList2 = emptyStudentList.DefaultIfEmpty(new Student()
            {
                StudentID = 1,
                StudentName = ""
            });

            Console.WriteLine("Count = {0}", newStudentList1.Count());
            Console.WriteLine("Student ID = {0}", newStudentList1.ElementAt(0).StudentID);

            Console.WriteLine("Count = {0}", newStudentList2.Count());
            Console.WriteLine("Student ID = {0}", newStudentList2.ElementAt(0).StudentID);
        }
    }
}
