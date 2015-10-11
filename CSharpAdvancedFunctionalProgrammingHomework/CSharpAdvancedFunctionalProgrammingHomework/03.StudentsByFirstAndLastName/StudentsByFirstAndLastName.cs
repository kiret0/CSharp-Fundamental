using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _03.StudentsByFirstAndLastName
{
    class StudentsByFirstAndLastName
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();

            var studentOrderByAlphabet =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;
            foreach (var st in studentOrderByAlphabet)
            {

                Console.WriteLine("First name = {0} Last name = {1} Age = {2} FacultyNumber = {3} Phone = {4} Email = {5} Marks = {6} Group number = {7}",
                       st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(", ", st.Marks), st.GroupNumber);
            }
        }
    }
}
