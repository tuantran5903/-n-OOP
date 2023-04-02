using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace Do_an_OOP.Entity
{
    public class Employee
    {
        protected string id;
        protected string fullname;
        protected DateTime birthday;
        protected string phone;
        protected string email;
        protected byte employee_type;
        protected int employee_count;

        public string Id { get { return id; } set { id = value; } }
        public string Fullname { get { return fullname; } set { fullname = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public byte Employee_type { get { return employee_type; } set { employee_type = value; } }

        public Employee()
        {

        }

        public override string ToString()
        {
            return GetType().ToString().Remove(0, 10) + $"\tId: {id},\tFullname: {fullname},\tBirthday: {birthday.ToShortDateString()},\tPhone: {phone},\tEmail: {email}";
        }

        public virtual string ShowSalary()
        {
            return "";
        }
        public static void Delete(string id)
        {
            QUANLYNHANVIEN.manage.Delete(id);
        }
    }
}
