using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_MVC_SQL.Models
{
    public class Teacher
    {
        public string firstName;
        public string lastName;
        public string domain;
        public string email;
        public int salary;


        public Teacher() { }
        public Teacher(string _firstName, string _lastName, string _domain, string _email, int _salary)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.domain = _domain;
            this.email = _email;
            this.salary = _salary;
        }
    }
}