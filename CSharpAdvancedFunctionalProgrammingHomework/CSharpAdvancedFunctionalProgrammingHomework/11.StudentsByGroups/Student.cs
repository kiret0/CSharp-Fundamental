﻿using System.Collections.Generic;

namespace _11.StudentsByGroups
{
    public class Student
    {
        
        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupName = groupName;
        }
        public int Age { get; set; }
        public string Email { get; set; }
        public int FacultyNumber { get; set; }
        public string FirstName { get; set; }
        public string GroupName { get; set; }
        public string LastName { get; set; }
        public IList<int> Marks { get; set; }
        public string Phone { get; set; }
    }
}