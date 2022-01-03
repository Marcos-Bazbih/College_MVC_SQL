using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_MVC_SQL.Models
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public DateTime birthday;
        public string email;
        public int schoolYear;
        
        static public List<Student> students = new List<Student>();

        public Student() { }

        public Student(string _firstName, string _lastName, DateTime _birthday, string _email, int _schoolYear)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.birthday = _birthday;
            this.email = _email;
            this.schoolYear = _schoolYear;
        }
    }
}