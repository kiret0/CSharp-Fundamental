using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _06.FilterStudentsByEmailDomain
{
    class FilterStudentsByEmailDomain
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();
            var filterByEmail = from st in students
                                where st.Email.Contains("@abv.bg")
                                select st;
            foreach (var st in filterByEmail)
            {
                Console.WriteLine("{0} {1} {2}",st.FirstName,st.LastName,st.Email);
            }
        }
    }
}
