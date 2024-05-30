using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNhapVaoDanhSach_Click(object sender, EventArgs e)
        {
            int so;
            if(int.TryParse(textBoxNhapDanhSach.Text, out so))
            {
                InDanhSach.Items.Add(so);
                textBoxNhapDanhSach.Text = " ";
                textBoxNhapDanhSach.Focus();
            }
            else
            {
                MessageBox.Show("Cần nhập số ", " Bạn chú ý");
                textBoxNhapDanhSach.Focus();
            }
        }

        private void buttonNhapTuDong_Click(object sender, EventArgs e)
        {
            Random rd =  new Random();
            for(int i = 1;i<=3;i++)
            {
                InDanhSach.Items.Add((int)rd.Next(1,10));
            }
        }

        private void buttonHienThiCacPhanTu_Click(object sender, EventArgs e)
        {
            if(InDanhSach.Items.Count > 0)
            {
                string s = "";
                foreach (int so in InDanhSach.Items)
                    s += so +"\t";
                MessageBox.Show("Danh sach so:\n " + s+" \t", "Bao cao");
            }
            else
            {
                MessageBox.Show("Danh sach rong", "Thong bao");
            }
        }

        private void buttonXoaPhanTu_Click(object sender, EventArgs e)
        {
            if(InDanhSach.SelectedIndex != -1)
            {
                while(InDanhSach.SelectedIndex != -1)
                {
                    InDanhSach.Items.RemoveAt(InDanhSach.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Can chon so de xoa!");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void buttonSoPhanTu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So phan tu cua danh sach " + InDanhSach.Items.Count, "Thong bao");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(InDanhSach.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon phan tu de sua");
            }
            else
            {
                int x = InDanhSach.SelectedIndex;
                InDanhSach.Items.RemoveAt(InDanhSach.SelectedIndex);
                InDanhSach.Items.Insert(x,int.Parse(textBoxNhapDanhSach.Text));
                textBoxNhapDanhSach.Focus();
            }

        }

        private void  testNguyenTo(int dansach) { 

        }

        private void buttonSoNT_Click(object sender, EventArgs e)
        {
            string SoNT=" ";
            for(int i = 0;i<InDanhSach.Items.Count;i++)
            {
                if (! testNguyenTo((int)InDanhSach.Items[i]))
                {
                    SoNT += InDanhSach.Items[i] + " ";
                    InDanhSach.SelectedIndex = i;
                }

            }
            if (SoNT == " ") MessageBox.Show("Khong co so nao la so nguyen to");
            else
            {
                MessageBox.Show("Cac so nguyen to la: " + SoNT);
                textBoxNhapDanhSach.Focus();
            }
        }
    }
    
}
