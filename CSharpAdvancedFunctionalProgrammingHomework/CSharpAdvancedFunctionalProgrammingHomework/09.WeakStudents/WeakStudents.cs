using System;
using StudentClass;

namespace _09.WeakStudents
{
    class WeakStudents
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();

            var filterByMarksWeak = students.ExtensionCount();

            foreach (var st in filterByMarksWeak)
            {
                Console.WriteLine("{0} {1} {2}",st.FirstName,st.LastName,string.Join(", ", st.Marks));
            }
        }
    }
}
