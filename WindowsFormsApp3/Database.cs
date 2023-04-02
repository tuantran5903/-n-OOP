using Do_an_OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_OOP
{
    public class Database
    {
        private List<Employee> data;
        private Dictionary<string, string> admin;

        public List<Employee> Data { get { return data; } set { data = value; } }

        public Database()
        {
            data = new List<Employee>();
            admin = new Dictionary<string, string>();
            data.Add(new Experience("01", "Trần Hữu Tùng", new DateTime(2003, 5, 18), "0973452864", "phuoctungtran@gmail.com", 0, 7, "C#"));
            data.Add(new Experience("02", "Hà Thanh Tú", new DateTime(2002, 4, 20), "0922245679", "thanhtu2002@gmail.com", 0, 10, "Python"));
            data.Add(new Intern("03", "Nguyễn Văn Tiến", new DateTime(2001, 10, 30), "0953697410", "Tuiyeutien@gmail.com", 1, "IT", 4, "UEH"));
            data.Add(new Fresher("04", "Mai Công Huy", new DateTime(2001, 3, 2), "0915699454", "Cghuyhuycg@gmail.com", 2, new DateTime(2022, 5, 16), 3, "UEH"));
            data.Add(new Experience("05", "Nguyễn Văn Cường", new DateTime(2002, 6, 10), "0954245339", "cuongnguyen@gmail.com", 0, 3, "Python"));
            data.Add(new Fresher("06", "Hồ Tấn Dũng", new DateTime(2000, 9, 15), "0933357846", "dungdavid15@gmail.com", 2, new DateTime(2022, 3, 20), 2, "UEH"));
            data.Add(new Intern("07", "Nguyễn Hữu Hưng", new DateTime(2002, 10, 9), "0905420668", "hunghuunguyen@gmail.com", 1, "IT", 3, "UEH"));
            data.Add(new Experience("08", "Võ Minh Toàn", new DateTime(2003, 12, 3), "0927334046", "minhtoanthu2@gmail.com", 0, 6, "C#"));
            data.Add(new Intern("09", "Huỳnh Thị My", new DateTime(2001, 2, 15), "0964578234", "mydrahuynh@gmail.com", 1, "IT", 4, "UEH"));
            data.Add(new Fresher("10", "Thái Hữu Khánh", new DateTime(2003, 1, 15), "0987662340", "khanhthai1501@gmail.com", 2, new DateTime(2022, 6, 22), 1, "UEH"));
            data.Add(new Intern("11", "Đào Trung Sơn", new DateTime(2003, 3, 26), "0917882654", "trungsonidol@gmail.com", 1, "IT", 3, "UEH"));
            data.Add(new Intern("12", "Lê Hoàng Hải", new DateTime(2002, 5, 6), "0926440028", "haile0202@gmail.com", 1, "IT", 2, "UEH"));
            data.Add(new Experience("13", "Võ Hoàng Tú", new DateTime(2003, 9, 20), "0917556489", "hoangtuvo2003@gmail.com", 0, 8, "Python"));
            data.Add(new Fresher("14", "Tạ Huyền Trân", new DateTime(2001, 4, 30), "0979665420", "Trantoptop1@gmail.com", 2, new DateTime(2022, 4, 19), 2, "UEH"));
            data.Add(new Intern("15", "Khổng Tú Quỳnh", new DateTime(2000, 6, 9), "0956992136", "tustusquynh@gmail.com", 1, "IT", 4, "UEH"));
            data.Add(new Experience("16", "Mai Hoàng Phước", new DateTime(2003, 4, 26), "0926597463", "maiphuochoang@gmail.com", 0, 5, "C#"));
            data.Add(new Fresher("17", "Trần Mai Sương", new DateTime(2002, 3, 6), "0946555782", "suongmaigtran@gmail.com", 2, new DateTime(2022, 6, 22), 3, "UEH"));
            data.Add(new Intern("18", "Phan Minh Trí", new DateTime(2003, 11, 9), "0905420668", "hunghuunguyen@gmail.com", 1, "IT", 2, "UEH"));
            data.Add(new Fresher("19", "Nguyễn Hoàng Như", new DateTime(2001, 4, 20), "0345699725", "nhunguyen01@gmail.com", 2, new DateTime(2022, 6, 22), 3, "UEH"));
            data.Add(new Fresher("20", "Dương Tuấn Ngọc", new DateTime(2003, 5, 4), "0977561425", "duongduong.ng@gmail.com", 2, new DateTime(2022, 6, 15), 2, "UEH"));

            data.Add(new Experience("21", "Chu Việt Thắng", new DateTime(2002, 12, 5), "0987663210", "thangviettt123@gmail.com", 0, 4, "Python"));
            data.Add(new Intern("22", "Huỳnh Tấn Phát", new DateTime(2003, 10, 15), "0940321125", "phathuynhlaso1@gmail.com", 1, "IT", 2, "UEH"));
            data.Add(new Fresher("23", "Nguyễn Hồng Nhân", new DateTime(2001, 5, 2), "0993357924", "nhnngn0205@gmail.com", 2, new DateTime(2022, 3, 14), 2, "UEH"));
            data.Add(new Experience("24", "Lý Sinh Hùng", new DateTime(2002, 4, 19), "0946933257", "sinhhungbien@gmail.com", 0, 6, "C#"));
            data.Add(new Fresher("25", "Võ Nam Việt", new DateTime(2000, 4, 4), "0956470234", "namvietnam@gmail.com", 2, new DateTime(2022, 3, 25), 2, "UEH"));
            data.Add(new Intern("26", "Nguyễn Tuấn Hải", new DateTime(2001, 10, 15), "0917336592", "haituannggg@gmail.com", 1, "IT", 1, "UEH"));
            data.Add(new Experience("27", "Lưu Đức Triều", new DateTime(2003, 5, 26), "0926975213", "ueirtcud@gmail.com", 0, 2, "C#"));
            data.Add(new Fresher("28", "Nguyễn Bá Kha", new DateTime(2002, 7, 1), "0969722345", "bakhangg55@gmail.com", 2, new DateTime(2022, 6, 22), 3, "UEH"));
            data.Add(new Intern("29", "Đinh Tiên Khả Ái", new DateTime(2002, 4, 2), "0905458664", "tinhiukhaai@gmail.com", 1, "IT", 3, "UEH"));
            data.Add(new Fresher("30", "Lê Hoàng Minh Tâm", new DateTime(2002, 5, 8), "0919393726", "minhtamle0805@gmail.com", 2, new DateTime(2022, 3, 15),3, "UEH"));

            admin.Add("admin", "123");
            admin.Add("user1", "123");
            admin.Add("user2", "456");
        }

        public bool QueryForLogin(string username, string password)
        {
            foreach (KeyValuePair<string, string> entry in admin)
            {
                if (username.Equals((string)entry.Key) && password.Equals((string)entry.Value))
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Employee emp)
        {
            foreach (Employee item in data)
            {
                if (item.Id.Equals(emp.Id))
                {
                    Console.WriteLine("ID này đã tồn tại trong dữ liệu!");
                    return;
                }
            }
            data.Add(emp);
        }

        public void Delete(string id)
        {
            foreach (Employee item in data)
            {
                if (item.Id.Equals(id))
                {
                    data.Remove(item);
                    return;
                }
            }
            MessageBox.Show("ID này không tồn tại trong dữ liệu!");
        }
    }
}
