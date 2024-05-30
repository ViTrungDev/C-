using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLySinhVien
{
    public partial class QLSinhVien : Form
    {
        public QLSinhVien()
        {
            InitializeComponent();
        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            int ma;
            if(int.TryParse(textBoxMaSinhVien.Text, out ma))
            {
                sinhVien.Ma = ma;
            }
            else
            {
                MessageBox.Show("Nhập mã sai");
            }
            sinhVien.HoTen = textBoxHoTenSinhVien.Text;
            DateTime ngaySinh;
            if(DateTime.TryParse(textBoxNgaySinh.Text, out ngaySinh))
            {
                sinhVien.NgaySinh= ngaySinh;
            }
            else
            {
                MessageBox.Show("Bạn nhập sai ngày sinh ");
            }
            if((int.TryParse(textBoxMaSinhVien.Text, out ma))&&(DateTime.TryParse(textBoxNgaySinh.Text, out ngaySinh))){
                listDanhSachSinhVien.Items.Add(sinhVien);
            }
            textBoxMaSinhVien.Focus();
            textBoxMaSinhVien.Text = " ";
            textBoxHoTenSinhVien.Text = " ";
            textBoxNgaySinh.Text=" ";
        }

        private void listDanhSachSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDanhSachSinhVien.SelectedIndex == -1) {
                MessageBox.Show("Cần chọn sinh viên");

            }
            else
            {
                SinhVien sinhVien = listDanhSachSinhVien.SelectedItem as SinhVien;
                textBoxMaSinhVien.Text = sinhVien.Ma.ToString();
                textBoxHoTenSinhVien.Text=sinhVien.HoTen.ToString();

                textBoxNgaySinh.Text=sinhVien.NgaySinh.ToString();

            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(listDanhSachSinhVien.SelectedIndex != -1)
            {
                int x = listDanhSachSinhVien.SelectedIndex;
                listDanhSachSinhVien.Items.RemoveAt(x);
                SinhVien sv = new SinhVien();
                int ma;

                if(int.TryParse(textBoxMaSinhVien.Text,out ma)) { 
                    sv.Ma = ma;
                }
                else
                {
                    MessageBox.Show("Nhap ma sai", "Chu y");
                }
                sv.HoTen = textBoxHoTenSinhVien.Text;
                DateTime ns;
                if(DateTime.TryParse(textBoxNgaySinh.Text,out ns))
                {
                    sv.NgaySinh = ns;
                }
                else
                {
                    MessageBox.Show("Nhap ngay sinh sai", "chu y");
                }
                if ((int.TryParse(textBoxMaSinhVien.Text, out ma)) && (DateTime.TryParse(textBoxNgaySinh.Text, out ns)))
                {
                    listDanhSachSinhVien.Items.Insert(x,ns);
                }
            }
            
            else 
            {
                MessageBox.Show("Chọn sinh viên cần sửa");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(listDanhSachSinhVien.SelectedIndex == -1)
            {
                int x = listDanhSachSinhVien.SelectedIndex;
                listDanhSachSinhVien.Items.Remove(x);
            }
            else
            {
                MessageBox.Show("Chon sinh vien can xoa");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
