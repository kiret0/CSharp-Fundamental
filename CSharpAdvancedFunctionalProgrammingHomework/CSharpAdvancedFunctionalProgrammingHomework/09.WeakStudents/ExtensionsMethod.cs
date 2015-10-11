using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

namespace _09.WeakStudents
{
    public static class ExtensionsMethod
    {
        public static List<Student> ExtensionCount(this IList<Student> marks)
        {
            var result =
                from st in marks
                where (st.Marks.Count(a => a == 2) == 2)
                select st;

            return result.ToList();
        }
    }
}
