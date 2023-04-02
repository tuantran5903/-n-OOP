using Do_an_OOP;
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
    public partial class QUANLYNHANVIEN : Form
    {
        public QUANLYNHANVIEN()
        {
            InitializeComponent();
        }
        public static ManageEmployee manage = new ManageEmployee();
        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbTK.Text;
            string password = tbMK.Text;
            if (manage.QueryForLogin(username, password))
            {
                ChucNang chucNang = new ChucNang();
                this.Hide();
                chucNang.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau");
            }
 
        }
        private void QUANLYNHANVIEN_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoai khoi chuong trinh khong !!!", "THONG BAO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)!=System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel=true;
            }
        }
    }
}
