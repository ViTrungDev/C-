using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtketQua_TextChanged(object sender, EventArgs e)
        {

        }
       public string  GiaiPhuongTrinhBacNhat(float a, float b)
        {
            string ketQua = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    ketQua = "Phương trình đúng với mọi nghiệm!";
                }
                else
                {
                    ketQua = "Phương trình vô nghiệm";
                }

            }
            else
            {
                ketQua ="Pt ax + b = "+(-b/a);
            }

            return ketQua;
        }
        private void btnGiaiPTbac1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);

            TxtketQua.Text = GiaiPhuongTrinhBacNhat( a, b);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);

            TxtketQua.Text = a + b + "";
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);

            TxtketQua.Text = a - b + "";
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);

            TxtketQua.Text = a / b + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);

            TxtketQua.Text = a * b + "";
        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextAB_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);
            String ketQua = " ";
            if (a > b)
            {
                ketQua = "A lon hon B";
            }
            else
            {
        ketQua  = "A be hon B ";
            }
            TxtketQua.Text = ketQua;
        }

        private void ChanOrle_Click(object sender, EventArgs e)
        {
            float a = float.Parse(Txta.Text);
            float b = float.Parse(Txtb.Text);
            String ketQua = " ";
            if (a %2==0 && b % 2 == 0)
            {
                ketQua = "A va b la so chan ";
            }
            else if(a %2 !=0 && b%2==0) 
            {
                ketQua = "A khong phai la so chan, B la so chan ";
            }
            else if(a%2 !=0 && b%2 != 0)
            {
                ketQua = "A va B la so le";
            }
          
            else
            {
                ketQua = "A la so chan,B khong phai la so chan";
            }
            TxtketQua.Text = ketQua;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
