using Do_an_OOP;
using Do_an_OOP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ThemEmp : Form
    {
        public ThemEmp()
        {
            InitializeComponent();
        }

        private void btThemEmp_Click(object sender, EventArgs e)
        {            
            string id = Validation.InputId(tbThemID.Text);
            string fullname = tbThemHT.Text;
            byte day = byte.Parse(tbThemngay.Text);
            byte month = byte.Parse(tbThemthang.Text);
            int year = int.Parse(tbThemnam.Text);
            DateTime birthday = new DateTime(year, month, day);
            string phone = Validation.InputPhone(tbThemSDT.Text);
            string email = Validation.InputEmail(tbThemEmail.Text);
            int yearOfExp = int.Parse(tbThemNKN.Text);
            string proSkills = tbThemKN.Text;
            QUANLYNHANVIEN.manage.Add(new Experience(id, fullname, birthday, phone, email, 0, yearOfExp, proSkills));
            MessageBox.Show("Thêm nhân viên thành công");

        }

        private void btThemIntern_Click(object sender, EventArgs e)
        {
            string id = Validation.InputId(tbThemIDInt.Text);
            string fullname = tbThemHTInt.Text;
            byte day = byte.Parse(tbThemngayInt.Text);
            byte month = byte.Parse(tbThemthangInt.Text);
            int year = int.Parse(tbThemnamInt.Text);
            DateTime birthday = new DateTime(year, month, day);
            string phone = Validation.InputPhone(tbThemSDTInt.Text);
            string email = Validation.InputEmail(tbThemEmailInt.Text);
            string majors = tbThemCNInt.Text;
            int semester = int.Parse(tbThemHKInt.Text);
            string university = tbThemTruongInt.Text;
            QUANLYNHANVIEN.manage.Add(new Intern(id, fullname, birthday, phone, email, 1, majors, semester, university));
            MessageBox.Show("Thêm nhân viên thành công");

        }

        private void btThemFre_Click(object sender, EventArgs e)
        {
            string id = Validation.InputId(tbThemIDFre.Text);
            string fullname = tbThemHTFre.Text;
            byte day = byte.Parse(tbThemngayFre.Text);
            byte month = byte.Parse(tbThemthangFre.Text);
            int year = int.Parse(tbThemnamFre.Text);
            DateTime birthday = new DateTime(year, month, day);
            string phone = Validation.InputPhone(tbThemSDTFre.Text);
            string email = Validation.InputEmail(tbThemEmailFre.Text);
            byte graDay = byte.Parse(tbThemNTNFre.Text);
            byte graMonth = byte.Parse(tbThemTTNFre.Text);
            int graYear = int.Parse(tbThemNamTNFre.Text);
            DateTime graDate = new DateTime(graYear, graMonth, graDay);
            byte graRank = Validation.InputGraRank(tbThemLTNFre.Text);
            string graUni = tbThemTruongTNFre.Text;
            QUANLYNHANVIEN.manage.Add(new Fresher(id, fullname, birthday, phone, email, 2, graDate, graRank, graUni));
            MessageBox.Show("Thêm nhân viên thành công");
        }

        private void btThoatExp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoatInt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoatFre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
