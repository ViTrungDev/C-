using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioCheckButton
{
    public partial class CheckBoxRadio : Form
    {
        public CheckBoxRadio()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Muốn thoát!", "Xin Ý Kiến", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (thoat == DialogResult.Yes) Close();
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                textBoxKetQua.ForeColor = Color.Red;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked)
            {
                textBoxKetQua.ForeColor = Color.Blue;
            }
        }

        private void radioButtonViolet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonViolet.Checked)
            {
                textBoxKetQua.ForeColor = Color.Violet;
            }
        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYellow.Checked)
            {
                textBoxKetQua.ForeColor= Color.Yellow;
            }
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBold.Checked==true && checkBoxItalic.Checked == false && checkBoxUderLine.Checked == false&& checkBoxRegular.Checked == false) ;
            {
                textBoxKetQua.Font = new Font(textBoxKetQua.Font.Name, textBoxKetQua.Font.Size, textBoxKetQua.Font.Style ^ FontStyle.Bold);
                    }
        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBold.Checked == false && checkBoxItalic.Checked == true && checkBoxUderLine.Checked == false && checkBoxRegular.Checked == false)
            {
                textBoxKetQua.Font = new Font(textBoxKetQua.Font.Name, textBoxKetQua.Font.Size, textBoxKetQua.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkBoxUderLine_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBold.Checked == false && checkBoxItalic.Checked == false && checkBoxUderLine.Checked == true && checkBoxRegular.Checked == false) 
            {
                textBoxKetQua.Font=new Font(textBoxKetQua.Font.Name,textBoxKetQua.Font.Size,textBoxKetQua.Font.Style^FontStyle.Underline);
            } 
        }

        private void checkBoxRegular_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBold.Checked == false && checkBoxItalic.Checked == false && checkBoxUderLine.Checked == false && checkBoxRegular.Checked == true) {
                textBoxKetQua.Font= new Font(textBoxKetQua.Font.Name,textBoxKetQua.Font.Size,textBoxKetQua.Font.Style^FontStyle.Regular);
            }
        }

        private void textBoxNhapChuoi_TextChanged(object sender, EventArgs e)
        {
            textBoxKetQua.Text = textBoxNhapChuoi.Text;
        }
    }
}


