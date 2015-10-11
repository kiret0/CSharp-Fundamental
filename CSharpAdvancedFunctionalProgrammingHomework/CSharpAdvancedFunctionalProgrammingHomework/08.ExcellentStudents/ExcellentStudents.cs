using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _08.ExcellentStudents
{
    class ExcellentStudents
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();
            var filterByMarks =
                from st in students
                where st.Marks.Max() == 6
                select new {Fullname = string.Join(" ",st.FirstName,st.LastName), Marks = string.Join(", ",st.Marks) };
            foreach (var st in filterByMarks)
            {
                Console.WriteLine(st.Fullname + " " + st.Marks);
            }
        }
    }
}
