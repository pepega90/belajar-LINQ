using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.LetInLINQ
{
    class Program
    {
        static void Main()
        {
            /* Keyword "let" sangat berguna pada sintaks query di LINQ
             * Ini memproyeksikan variabel rentang baru, 
             * memungkinkan penggunaan kembali ekspresi dan membuat kueri lebih mudah dibaca.
             */

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            // Contoh dibawah, kita tidak menggunakan keyword "let"
            // dimana kita harus memanggil method ToLower() berkali-kali untuk mengubah properti StudentName menjadi lowecase
            var loweCaseStudent = from s in studentList
                                  where s.StudentName.ToLower().StartsWith("r")
                                  select s.StudentName.ToLower();

            // Contoh menggunakan keyword "let". dimana kita membuat variabel dengan properti StudentName lowecase
            // yang bisa digunakan disetiap tempat
            var letLowerCaseStudent = from s in studentList
                                      let loweCaseName = s.StudentName.ToLower()
                                      where loweCaseName.StartsWith("r")
                                      select loweCaseName;

            foreach (var item in letLowerCaseStudent)
            {
                Console.WriteLine(item);
            }
        }
    }
}
