using belajarLINQ.Join;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace belajarLINQ.Contains
{
    // Jika kita ingin menggunakan Contains ke custom value, kita bisa melakukan inherit ke IEqualityComparer
    // dan mengoverride method Equals
    public class StudenComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            /* Operator Contains, memeriksa apakah elemen tertentu ada dalam koleksi atau tidak .
             * dan mengembalikan boolean
             */

            //IList<int> num = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //bool adaLima = num.Contains(6);

            //Console.WriteLine(adaLima);

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            Student std = new Student() { StudentID = 3, StudentName = "Bill", Age = 25 };

            bool cekStudent = studentList.Contains(std, new StudenComparer());

            Console.WriteLine(cekStudent);
        }
    }
}
