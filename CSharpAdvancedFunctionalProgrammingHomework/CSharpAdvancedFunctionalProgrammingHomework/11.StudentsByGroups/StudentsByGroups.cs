using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StudentsByGroups
{
    class StudentsByGroups
    {
        static void Main()
        {
            var students = StudentsInfo.StudentsInformantion();
            var filterByGroups =
                from st in students
                group st by st.GroupName;
                
                
            foreach (var studentGroupName in filterByGroups)
            {
                Console.WriteLine("GroupName: {0}, Number of student: {1}",studentGroupName.Key,studentGroupName.Count());
                foreach (var st in studentGroupName)
                {
                    Console.WriteLine("{0} {1}",st.FirstName,st.LastName);
                }
            }
        }
    }
}
