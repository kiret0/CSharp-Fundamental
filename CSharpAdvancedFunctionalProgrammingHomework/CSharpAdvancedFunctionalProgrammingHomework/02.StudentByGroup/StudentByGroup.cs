using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;
namespace _02.StudentByGroup
{
    class StudentByGroup
    {
        static void Main()
        {
            var list = StudentsInfo.StudentsInformantion();
            var studentsInTwoGroup = from st in list
                                     where st.GroupNumber == 2
                                     orderby st.FirstName
                                     select st;
            foreach (var st in studentsInTwoGroup)
            {
                Console.WriteLine("First name = {0} Last name = {1} Age = {2} FacultyNumber = {3} Phone = {4} Email = {5} Marks = {6} Group number = {7}",
                    st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(", ", st.Marks), st.GroupNumber);
            }
        }
    }
}
