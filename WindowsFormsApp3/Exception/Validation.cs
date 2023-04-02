using Do_an_OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Do_an_OOP
{
    public class Validation
    {
        public static void CheckId(string id)
        {
            Database db = new Database();
            foreach (Employee item in db.Data)
            {
                if (item.Id.Equals(id))
                {
                    Exception e = new IdException();
                    throw e;
                }
            }
        }

        public static void CheckEmail(string email)
        {
            if (email.Length==0)
            {

            }
            else  if (!email.Contains('@'))
            {
                Exception e = new EmailException();
                throw e;
            }
        }
        
        public static void CheckGraRank(byte s)
        {
            if (s < 0 || s > 3)
            {
                Exception e = new GraduateRankException();
                throw e;
            }
        }
        public static void CheckPhone(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new NumberPhoneException();
                throw e;
            }
        }

        public static byte InputGraRank(string rank)
        {
            try
            {
                byte graRank;
                bool result = byte.TryParse(rank, out graRank);
                if (result==true)
                {
                    CheckGraRank(graRank);
                }
                return graRank;
            }
            catch (GraduateRankException e)
            {
                MessageBox.Show(e.ToString());
            }
            return 0;
        }
        public static string InputPhone(string sdt)
        {
            try
            {
                string phone = sdt;
                CheckPhone(phone);
                if (phone.Length==0)
                {
                    return ChucNang.EMP.Phone;
                }
                return phone;
            }
            catch (NumberPhoneException e)
            {
                MessageBox.Show(e.Message);               
            }
            return "";
        }
        public static string InputEmail(string Email)
        {
            try
            {
                string email = Email;
                CheckEmail(email);
                if (email.Length==0)
                {
                    return ChucNang.EMP.Email;
                }
                return email;
            }
            catch (EmailException e)
            {
                MessageBox.Show(e.Message);
            }
            return "";
        }
        
        public static string InputId(string id)
        {
            try
            {
                CheckId(id);
                return id;
            }
            catch (IdException e)
            {
                MessageBox.Show(e.Message);             
            }
            return "";
        }        
    }
}
