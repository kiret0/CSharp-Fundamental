using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _07.FilterStudentsByPhone
{
    class FilterStudentsByPhone
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();

            var filterByPhone =
                from st in students
                where st.Phone.Contains("02") || st.Phone.Contains("+3592") || st.Phone.Contains("+359 2")
                select st;

            foreach (var st in filterByPhone)
            {
                Console.WriteLine("{0} {1} {2}",st.FirstName,st.LastName,st.Phone);
            }
        }
    }
}
