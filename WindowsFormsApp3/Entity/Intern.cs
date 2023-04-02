﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_OOP.Entity
{
    public class Intern : Employee, IEmployee
    {
        private string majors;
        private int semester;
        private string university;
        public string Majors { get { return majors; } set { majors = value; } }
        public int Semester { get { return semester; } set { semester = value; } }
        public string University { get { return university; } set { university = value; } }

        public Intern()
        {

        }

        public Intern(string id, string fullname, DateTime birthday, string phone, string email, byte employee_type, string majors, int semester, string university)
        {
            base.id = id;
            base.fullname = fullname;
            base.birthday = birthday;
            base.phone = phone;
            base.email = email;
            base.employee_type = employee_type;
            this.majors = majors;
            this.semester = semester;
            this.university = university;
        }

        public override string ToString()
        {
            return base.ToString().Insert(7, ":") + $",\tMajors: {majors}, \tSemester: {semester}, \tUniversity: {university}";
        }

        public double CalcSalary()
        {
            return 3000000 + 26 * 10000;
        }

        public override string ShowSalary()
        {
            return GetType().ToString().Remove(0, 10) + $"\tId: {id}, Fullname: {fullname}, Work days: 26, Salary: {String.Format("{0:0,0 vnđ}", CalcSalary())}";
        }
    }
}
