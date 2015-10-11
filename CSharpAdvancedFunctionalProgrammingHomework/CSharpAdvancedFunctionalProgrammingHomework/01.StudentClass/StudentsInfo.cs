using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class StudentsInfo
    {
        public List<Student> ListStudents = StudentsInformantion();
        public static List<Student> StudentsInformantion()
        {
            var students = new List<Student>()
            {
                new Student("Kolio", "Petrov", 20, 80413, "02 991 3221", "KolioPetrov@abv.bg", new List<int> { 6, 2, 4, 2 }, 2),
                new Student("Mitko","Angelov",25,80414,"+359 2 123 8888","MitkoAngelov@gmail.com",new List<int>{ 6, 5, 5, 3 }, 1),
                new Student("Atanas","Filkov",18,80415,"+359 883 123 321","AtanasFilkov@mail.bg",new List<int>{ 5, 2, 4, 2 }, 2),
                new Student("Qnko","Stoichev",22,80414,"02 112 3654","QnkoStoichev@abv.bg",new List<int>{ 4, 6, 4, 5 }, 3),
                new Student("Stefan","Dimitrov",19,80414,"+3592 439 1001","StefanDimitrov@gmail.com",new List<int> { 6, 6, 2, 6 }, 2),
                new Student("Anatoli","Dqnkov",30,80415,"+359 2 666 2030","AnatoliDqnkov@abv.bg",new List<int> { 3, 4, 4, 5 }, 1),
                new Student("Boris","Toshev",24,80415,"+359 888 000 412","borisToshev@abv.bg",new List<int>{ 2, 5, 2, 3 }, 4),
            };

            return students;
        }
    }
}
