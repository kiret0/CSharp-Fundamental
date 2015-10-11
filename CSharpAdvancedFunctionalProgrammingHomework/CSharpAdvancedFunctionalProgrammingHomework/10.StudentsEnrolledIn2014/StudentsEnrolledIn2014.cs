using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;
using System.Text.RegularExpressions;

namespace _10.StudentsEnrolledIn2014
{
    class StudentsEnrolledIn2014
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();
            string pattern = @"\d14";
            var enrolledStudents =
                from st in students
                where Regex.IsMatch(st.FacultyNumber.ToString(), pattern)
                select st;
            foreach (var st in enrolledStudents)
            {
                Console.WriteLine("{0} {1} {2}",st.FirstName,st.LastName,string.Join(", ",st.Marks));
            }
            
        }
    }
}
