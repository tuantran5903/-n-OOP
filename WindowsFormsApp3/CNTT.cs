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
using System.Xml;

namespace WindowsFormsApp3
{
    public partial class CNTT : Form
    {
        public CNTT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChucNang.EMP.Id!=null)
            {
                if (tbHoten.Text.Length>0)
                {
                    ChucNang.EMP.Fullname = tbHoten.Text;
                }
                ChucNang.EMP.Phone = Validation.InputPhone(tbSDT.Text);
                ChucNang.EMP.Email = Validation.InputEmail(tbEmail.Text);
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            
        }
        private void btCNTTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbHoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
