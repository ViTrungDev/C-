namespace ChuongTrinhQuanLySinhVien
{
    partial class QLSinhVien
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
            this.labelMaSinhVien = new System.Windows.Forms.Label();
            this.textBoxMaSinhVien = new System.Windows.Forms.TextBox();
            this.labelHoTenSinhVien = new System.Windows.Forms.Label();
            this.textBoxHoTenSinhVien = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.buttonNhap = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.listDanhSachSinhVien = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelMaSinhVien
            // 
            this.labelMaSinhVien.AutoSize = true;
            this.labelMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSinhVien.Location = new System.Drawing.Point(179, 36);
            this.labelMaSinhVien.Name = "labelMaSinhVien";
            this.labelMaSinhVien.Size = new System.Drawing.Size(135, 25);
            this.labelMaSinhVien.TabIndex = 0;
            this.labelMaSinhVien.Text = "Mã Sinh Viên ";
            // 
            // textBoxMaSinhVien
            // 
            this.textBoxMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSinhVien.Location = new System.Drawing.Point(366, 33);
            this.textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            this.textBoxMaSinhVien.Size = new System.Drawing.Size(229, 30);
            this.textBoxMaSinhVien.TabIndex = 1;
            // 
            // labelHoTenSinhVien
            // 
            this.labelHoTenSinhVien.AutoSize = true;
            this.labelHoTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTenSinhVien.Location = new System.Drawing.Point(179, 97);
            this.labelHoTenSinhVien.Name = "labelHoTenSinhVien";
            this.labelHoTenSinhVien.Size = new System.Drawing.Size(164, 25);
            this.labelHoTenSinhVien.TabIndex = 0;
            this.labelHoTenSinhVien.Text = "Họ tên Sinh Viên ";
            // 
            // textBoxHoTenSinhVien
            // 
            this.textBoxHoTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTenSinhVien.Location = new System.Drawing.Point(366, 94);
            this.textBoxHoTenSinhVien.Name = "textBoxHoTenSinhVien";
            this.textBoxHoTenSinhVien.Size = new System.Drawing.Size(229, 30);
            this.textBoxHoTenSinhVien.TabIndex = 2;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(179, 162);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(103, 25);
            this.labelNgaySinh.TabIndex = 0;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgaySinh.Location = new System.Drawing.Point(366, 159);
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.Size = new System.Drawing.Size(229, 30);
            this.textBoxNgaySinh.TabIndex = 4;
            // 
            // buttonNhap
            // 
            this.buttonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhap.Location = new System.Drawing.Point(103, 215);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.Size = new System.Drawing.Size(110, 42);
            this.buttonNhap.TabIndex = 2;
            this.buttonNhap.Text = "Nhập";
            this.buttonNhap.UseVisualStyleBackColor = true;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(259, 215);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(110, 42);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(414, 215);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(110, 42);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(562, 215);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(110, 42);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // listDanhSachSinhVien
            // 
            this.listDanhSachSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDanhSachSinhVien.FormattingEnabled = true;
            this.listDanhSachSinhVien.ItemHeight = 25;
            this.listDanhSachSinhVien.Location = new System.Drawing.Point(140, 275);
            this.listDanhSachSinhVien.Name = "listDanhSachSinhVien";
            this.listDanhSachSinhVien.Size = new System.Drawing.Size(532, 154);
            this.listDanhSachSinhVien.TabIndex = 3;
            this.listDanhSachSinhVien.SelectedIndexChanged += new System.EventHandler(this.listDanhSachSinhVien_SelectedIndexChanged);
            // 
            // QLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listDanhSachSinhVien);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonNhap);
            this.Controls.Add(this.textBoxNgaySinh);
            this.Controls.Add(this.textBoxHoTenSinhVien);
            this.Controls.Add(this.textBoxMaSinhVien);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelHoTenSinhVien);
            this.Controls.Add(this.labelMaSinhVien);
            this.Name = "QLSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Quản Lý Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaSinhVien;
        private System.Windows.Forms.TextBox textBoxMaSinhVien;
        private System.Windows.Forms.Label labelHoTenSinhVien;
        private System.Windows.Forms.TextBox textBoxHoTenSinhVien;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.Button buttonNhap;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.ListBox listDanhSachSinhVien;
    }
}

