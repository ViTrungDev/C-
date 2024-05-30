using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int snThang2(int nam)
        {
            if(nam % 4 == 0 && nam % 100 != 0 || nam %400 == 0) {
                return 29;

                    }
            else
            {
                return 28;
            }
        }
        int sn(int thang)
        {
            if (thang == 2) return snThang2(int.Parse(textBoxThang.Text));
            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                    return 30;
            }
            return 31;
        }
    
    private void ButtonHienThi_Click(object sender, EventArgs e)
        {
            if ((textBoxThang.Text == "2") && (textBoxNam.Text == ""))
                MessageBox.Show("Tháng 2 cần nhập năm", "chú ý");
            else
                if (int.Parse(textBoxThang.Text) == 2)
                JTKetQuKetqua.Text = "" + snThang2(int.Parse(textBoxNam.Text));
            else
                JTKetQuKetqua.Text = sn(int.Parse(textBoxThang.Text)).ToString();
        }
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

}
