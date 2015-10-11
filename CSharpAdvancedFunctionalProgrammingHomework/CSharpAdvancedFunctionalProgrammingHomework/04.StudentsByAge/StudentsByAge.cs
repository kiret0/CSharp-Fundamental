using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _04.StudentsByAge
{
    class StudentsByAge
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();

            var studentOrderByAlphabet =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;
            foreach (var st in studentOrderByAlphabet)
            {

                Console.WriteLine("First name = {0} Last name = {1} Age = {2}",
                       st.FirstName, st.LastName, st.Age);
            }
        }
    }
}
