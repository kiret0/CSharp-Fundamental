using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _05.SortStudents
{
     class SortStudents
    {
         static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();
            Console.WriteLine("Using Lambda:");
            Console.WriteLine();
            var LambdaOrderByDescending = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => string.Format("{0} {1}",st.FirstName,st.LastName));
            foreach (var st in LambdaOrderByDescending)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ query:");
            Console.WriteLine();

            var sortStudentLINQ =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var st in sortStudentLINQ)
            {
                Console.WriteLine("{0} {1}",st.FirstName,st.LastName);
            }
        }
    }
}
