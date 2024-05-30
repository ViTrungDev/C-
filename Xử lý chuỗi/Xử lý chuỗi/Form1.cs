using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xử_lý_chuỗi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChuanHoaHoTen_Click(object sender, EventArgs e)
        {
            string chuan ="",tg= textBoxNhapChuoi.Text;
            string[] tachTu = tg.Split(new char[] {' '}
            ,StringSplitOptions.RemoveEmptyEntries);// tach thanh tung tu
            for(int i = 0;i< tachTu.Length;i++)
            {
                tachTu[i] = tachTu[i].Trim();
                char[] mangKyTu = tachTu[i].ToCharArray();
                mangKyTu[0] = char.ToUpper(mangKyTu[0]);// chuyen ky tu dau thanh
                string tuMoi = new string(mangKyTu);
                chuan += tuMoi + " ";
            }
            chuan=chuan.Trim();
            textBoxKetQua.Text = chuan;
        }

        private void buttonDemsotu_Click(object sender, EventArgs e)
        {
            this.Text = "Thuc hien dem so tu";
            this.BackColor = Color.White;
            string tg = textBoxNhapChuoi.Text + " ";
            int demTu = 0;
            for(int i = 0; i< textBoxNhapChuoi.Text.Length;i++) {
                if ((tg[i] != ' ') && (tg[i + 1] == ' ')) demTu++;
                textBoxKetQua.Text = demTu.ToString();
            }
        }

        private void buttonDemKyTuSo_Click(object sender, EventArgs e)
        {
            this.Text = "Thuc hien dem chu hoa";
            int demchuHoa = 0;
            for(int i = 0; i < textBoxNhapChuoi.Text.Length; i++)
            {

            }
        }
    }
}
