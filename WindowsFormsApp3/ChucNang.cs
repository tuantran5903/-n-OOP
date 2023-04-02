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
    public partial class ChucNang : Form
    {
        public ChucNang()
        {
            InitializeComponent();
        }
        public static Employee EMP = new Employee();
        private void btTimID_Click(object sender, EventArgs e)
        {
            tbShowemp.Text="";
            if (tbID.Text.Length>0 )
            {
                if (QUANLYNHANVIEN.manage.CheckId(tbID.Text)==true)
                {
                    Employee emp = QUANLYNHANVIEN.manage.FindById(tbID.Text);
                    tbShowemp.Text=emp.ToString();
                    EMP=emp;
                }  
                else
                {
                    MessageBox.Show("ID can tim khong ton tai");
                }
            }  
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            tbShowemp.Text="";
            Employee.Delete(tbID.Text);
            MessageBox.Show("Xoá nhân viên thành công");
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            CNTT cntt = new CNTT();
            this.Hide();
            cntt.ShowDialog();
            this.Show();           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemEmp themEmp = new ThemEmp();
            this.Hide();
            themEmp.ShowDialog();
            this.Show();
        }

        private void btExperience_Click(object sender, EventArgs e)
        {
            dgvDs.DataSource=QUANLYNHANVIEN.manage.FindByType(0);
        }

        private void btIntern_Click(object sender, EventArgs e)
        {
            dgvDs.DataSource=QUANLYNHANVIEN.manage.FindByType(1);
        }

        private void btFresher_Click(object sender, EventArgs e)
        {
            dgvDs.DataSource=QUANLYNHANVIEN.manage.FindByType(2);
        }

        private void btKN_Click(object sender, EventArgs e)
        {
            dgvKN.DataSource=QUANLYNHANVIEN.manage.FindByExp(Convert.ToInt16(tbKN.Text));
        }

        private void btKyNang_Click(object sender, EventArgs e)
        {
            dgvKyNang.DataSource=QUANLYNHANVIEN.manage.FindBySkills(tbKyNang.Text);
        }

        private void btTrungbinh_Click(object sender, EventArgs e)
        {
            dgvLTNghiep.DataSource=QUANLYNHANVIEN.manage.FindByGraRank(0);
        }

        private void btKha_Click(object sender, EventArgs e)
        {
            dgvLTNghiep.DataSource=QUANLYNHANVIEN.manage.FindByGraRank(1);
        }

        private void btGioi_Click(object sender, EventArgs e)
        {
            dgvLTNghiep.DataSource=QUANLYNHANVIEN.manage.FindByGraRank(2);
        }

        private void btXuatsac_Click(object sender, EventArgs e)
        {
            dgvLTNghiep.DataSource=QUANLYNHANVIEN.manage.FindByGraRank(3);
        }

        private void btCN_Click(object sender, EventArgs e)
        {
            dgvCN.DataSource=QUANLYNHANVIEN.manage.FindByMajor(tbCN.Text);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>(); 
            list=QUANLYNHANVIEN.manage.ShowEmpSalary();
            string S = "";
            foreach(string s in list)
            {
                S+=s;
                for (int i = 0; i < 115-s.Length; i++)
                {
                    S+=" ";
                }
            }
            tbDsLuong.Text=S;
        }
    }
}
