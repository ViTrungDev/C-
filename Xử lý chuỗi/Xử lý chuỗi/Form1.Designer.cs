namespace Xử_lý_chuỗi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNhapChuoi = new System.Windows.Forms.Label();
            this.textBoxNhapChuoi = new System.Windows.Forms.TextBox();
            this.labelKetqua = new System.Windows.Forms.Label();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonDemsotu = new System.Windows.Forms.Button();
            this.buttonDemSoKyTuTrong = new System.Windows.Forms.Button();
            this.buttonDemKyTuSo = new System.Windows.Forms.Button();
            this.buttonDemsoKyTu = new System.Windows.Forms.Button();
            this.buttonDemsokyTuHoa = new System.Windows.Forms.Button();
            this.buttonChuanHoaHoTen = new System.Windows.Forms.Button();
            this.buttonTrichTen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNhapChuoi
            // 
            this.labelNhapChuoi.AutoSize = true;
            this.labelNhapChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapChuoi.Location = new System.Drawing.Point(43, 46);
            this.labelNhapChuoi.Name = "labelNhapChuoi";
            this.labelNhapChuoi.Size = new System.Drawing.Size(116, 25);
            this.labelNhapChuoi.TabIndex = 0;
            this.labelNhapChuoi.Text = "Nhập chuỗi ";
            // 
            // textBoxNhapChuoi
            // 
            this.textBoxNhapChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapChuoi.Location = new System.Drawing.Point(165, 43);
            this.textBoxNhapChuoi.Name = "textBoxNhapChuoi";
            this.textBoxNhapChuoi.Size = new System.Drawing.Size(415, 30);
            this.textBoxNhapChuoi.TabIndex = 0;
            // 
            // labelKetqua
            // 
            this.labelKetqua.AutoSize = true;
            this.labelKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetqua.Location = new System.Drawing.Point(43, 87);
            this.labelKetqua.Name = "labelKetqua";
            this.labelKetqua.Size = new System.Drawing.Size(85, 25);
            this.labelKetqua.TabIndex = 0;
            this.labelKetqua.Text = "Kết Quả";
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKetQua.Location = new System.Drawing.Point(165, 84);
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(415, 30);
            this.textBoxKetQua.TabIndex = 1;
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(648, 62);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(103, 50);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            // 
            // buttonDemsotu
            // 
            this.buttonDemsotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemsotu.Location = new System.Drawing.Point(59, 190);
            this.buttonDemsotu.Name = "buttonDemsotu";
            this.buttonDemsotu.Size = new System.Drawing.Size(147, 46);
            this.buttonDemsotu.TabIndex = 3;
            this.buttonDemsotu.Text = "Đếm số từ";
            this.buttonDemsotu.UseVisualStyleBackColor = true;
            this.buttonDemsotu.Click += new System.EventHandler(this.buttonDemsotu_Click);
            // 
            // buttonDemSoKyTuTrong
            // 
            this.buttonDemSoKyTuTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemSoKyTuTrong.Location = new System.Drawing.Point(281, 190);
            this.buttonDemSoKyTuTrong.Name = "buttonDemSoKyTuTrong";
            this.buttonDemSoKyTuTrong.Size = new System.Drawing.Size(207, 46);
            this.buttonDemSoKyTuTrong.TabIndex = 3;
            this.buttonDemSoKyTuTrong.Text = "Đếm số ký tự trống";
            this.buttonDemSoKyTuTrong.UseVisualStyleBackColor = true;
            // 
            // buttonDemKyTuSo
            // 
            this.buttonDemKyTuSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemKyTuSo.Location = new System.Drawing.Point(542, 190);
            this.buttonDemKyTuSo.Name = "buttonDemKyTuSo";
            this.buttonDemKyTuSo.Size = new System.Drawing.Size(180, 46);
            this.buttonDemKyTuSo.TabIndex = 3;
            this.buttonDemKyTuSo.Text = "Đếm số ký tự số";
            this.buttonDemKyTuSo.UseVisualStyleBackColor = true;
            this.buttonDemKyTuSo.Click += new System.EventHandler(this.buttonDemKyTuSo_Click);
            // 
            // buttonDemsoKyTu
            // 
            this.buttonDemsoKyTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemsoKyTu.Location = new System.Drawing.Point(48, 272);
            this.buttonDemsoKyTu.Name = "buttonDemsoKyTu";
            this.buttonDemsoKyTu.Size = new System.Drawing.Size(158, 46);
            this.buttonDemsoKyTu.TabIndex = 3;
            this.buttonDemsoKyTu.Text = "Đếm số ký tự";
            this.buttonDemsoKyTu.UseVisualStyleBackColor = true;
            // 
            // buttonDemsokyTuHoa
            // 
            this.buttonDemsokyTuHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemsokyTuHoa.Location = new System.Drawing.Point(264, 272);
            this.buttonDemsokyTuHoa.Name = "buttonDemsokyTuHoa";
            this.buttonDemsokyTuHoa.Size = new System.Drawing.Size(207, 46);
            this.buttonDemsokyTuHoa.TabIndex = 3;
            this.buttonDemsokyTuHoa.Text = "Đếm số ký tự hoa";
            this.buttonDemsokyTuHoa.UseVisualStyleBackColor = true;
            // 
            // buttonChuanHoaHoTen
            // 
            this.buttonChuanHoaHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChuanHoaHoTen.Location = new System.Drawing.Point(504, 272);
            this.buttonChuanHoaHoTen.Name = "buttonChuanHoaHoTen";
            this.buttonChuanHoaHoTen.Size = new System.Drawing.Size(255, 46);
            this.buttonChuanHoaHoTen.TabIndex = 3;
            this.buttonChuanHoaHoTen.Text = "Chuẩn hóa chuỗi họ tên";
            this.buttonChuanHoaHoTen.UseVisualStyleBackColor = true;
            this.buttonChuanHoaHoTen.Click += new System.EventHandler(this.buttonChuanHoaHoTen_Click);
            // 
            // buttonTrichTen
            // 
            this.buttonTrichTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrichTen.Location = new System.Drawing.Point(315, 354);
            this.buttonTrichTen.Name = "buttonTrichTen";
            this.buttonTrichTen.Size = new System.Drawing.Size(130, 46);
            this.buttonTrichTen.TabIndex = 3;
            this.buttonTrichTen.Text = "Trích tên";
            this.buttonTrichTen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTrichTen);
            this.Controls.Add(this.buttonChuanHoaHoTen);
            this.Controls.Add(this.buttonDemKyTuSo);
            this.Controls.Add(this.buttonDemsokyTuHoa);
            this.Controls.Add(this.buttonDemsoKyTu);
            this.Controls.Add(this.buttonDemSoKyTuTrong);
            this.Controls.Add(this.buttonDemsotu);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.textBoxNhapChuoi);
            this.Controls.Add(this.labelKetqua);
            this.Controls.Add(this.labelNhapChuoi);
            this.Name = "Form1";
            this.Text = "Xử lý chuỗi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhapChuoi;
        private System.Windows.Forms.TextBox textBoxNhapChuoi;
        private System.Windows.Forms.Label labelKetqua;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonDemsotu;
        private System.Windows.Forms.Button buttonDemSoKyTuTrong;
        private System.Windows.Forms.Button buttonDemKyTuSo;
        private System.Windows.Forms.Button buttonDemsoKyTu;
        private System.Windows.Forms.Button buttonDemsokyTuHoa;
        private System.Windows.Forms.Button buttonChuanHoaHoTen;
        private System.Windows.Forms.Button buttonTrichTen;
    }
}

