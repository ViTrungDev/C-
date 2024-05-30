namespace ArrayList
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
            this.components = new System.ComponentModel.Container();
            this.labelNhapSoNguyen = new System.Windows.Forms.Label();
            this.textBoxNhapDanhSach = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InDanhSach = new System.Windows.Forms.ListBox();
            this.buttonNhapVaoDanhSach = new System.Windows.Forms.Button();
            this.buttonXoaPhanTu = new System.Windows.Forms.Button();
            this.buttonHienThiCacPhanTu = new System.Windows.Forms.Button();
            this.buttonNhapTuDong = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonSoPhanTu = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonSoNT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNhapSoNguyen
            // 
            this.labelNhapSoNguyen.AutoSize = true;
            this.labelNhapSoNguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapSoNguyen.Location = new System.Drawing.Point(31, 29);
            this.labelNhapSoNguyen.Name = "labelNhapSoNguyen";
            this.labelNhapSoNguyen.Size = new System.Drawing.Size(161, 25);
            this.labelNhapSoNguyen.TabIndex = 0;
            this.labelNhapSoNguyen.Text = "Nhập số nguyên:";
            // 
            // textBoxNhapDanhSach
            // 
            this.textBoxNhapDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapDanhSach.Location = new System.Drawing.Point(198, 29);
            this.textBoxNhapDanhSach.Name = "textBoxNhapDanhSach";
            this.textBoxNhapDanhSach.Size = new System.Drawing.Size(284, 30);
            this.textBoxNhapDanhSach.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // InDanhSach
            // 
            this.InDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDanhSach.FormattingEnabled = true;
            this.InDanhSach.ItemHeight = 25;
            this.InDanhSach.Location = new System.Drawing.Point(198, 98);
            this.InDanhSach.Name = "InDanhSach";
            this.InDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.InDanhSach.Size = new System.Drawing.Size(284, 279);
            this.InDanhSach.TabIndex = 3;
            // 
            // buttonNhapVaoDanhSach
            // 
            this.buttonNhapVaoDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhapVaoDanhSach.Location = new System.Drawing.Point(538, 24);
            this.buttonNhapVaoDanhSach.Name = "buttonNhapVaoDanhSach";
            this.buttonNhapVaoDanhSach.Size = new System.Drawing.Size(202, 39);
            this.buttonNhapVaoDanhSach.TabIndex = 4;
            this.buttonNhapVaoDanhSach.Text = "Nhập vào danh sách";
            this.buttonNhapVaoDanhSach.UseVisualStyleBackColor = true;
            this.buttonNhapVaoDanhSach.Click += new System.EventHandler(this.buttonNhapVaoDanhSach_Click);
            // 
            // buttonXoaPhanTu
            // 
            this.buttonXoaPhanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaPhanTu.Location = new System.Drawing.Point(538, 69);
            this.buttonXoaPhanTu.Name = "buttonXoaPhanTu";
            this.buttonXoaPhanTu.Size = new System.Drawing.Size(145, 39);
            this.buttonXoaPhanTu.TabIndex = 4;
            this.buttonXoaPhanTu.Text = "Xóa phần tử";
            this.buttonXoaPhanTu.UseVisualStyleBackColor = true;
            this.buttonXoaPhanTu.Click += new System.EventHandler(this.buttonXoaPhanTu_Click);
            // 
            // buttonHienThiCacPhanTu
            // 
            this.buttonHienThiCacPhanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHienThiCacPhanTu.Location = new System.Drawing.Point(538, 114);
            this.buttonHienThiCacPhanTu.Name = "buttonHienThiCacPhanTu";
            this.buttonHienThiCacPhanTu.Size = new System.Drawing.Size(177, 39);
            this.buttonHienThiCacPhanTu.TabIndex = 4;
            this.buttonHienThiCacPhanTu.Text = "Hiển các phần tử";
            this.buttonHienThiCacPhanTu.UseVisualStyleBackColor = true;
            this.buttonHienThiCacPhanTu.Click += new System.EventHandler(this.buttonHienThiCacPhanTu_Click);
            // 
            // buttonNhapTuDong
            // 
            this.buttonNhapTuDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhapTuDong.Location = new System.Drawing.Point(538, 159);
            this.buttonNhapTuDong.Name = "buttonNhapTuDong";
            this.buttonNhapTuDong.Size = new System.Drawing.Size(159, 39);
            this.buttonNhapTuDong.TabIndex = 4;
            this.buttonNhapTuDong.Text = "Nhập tự động";
            this.buttonNhapTuDong.UseVisualStyleBackColor = true;
            this.buttonNhapTuDong.Click += new System.EventHandler(this.buttonNhapTuDong_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(538, 346);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(114, 39);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoat";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonSoPhanTu
            // 
            this.buttonSoPhanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoPhanTu.Location = new System.Drawing.Point(538, 204);
            this.buttonSoPhanTu.Name = "buttonSoPhanTu";
            this.buttonSoPhanTu.Size = new System.Drawing.Size(159, 35);
            this.buttonSoPhanTu.TabIndex = 5;
            this.buttonSoPhanTu.Text = "Số phần tử";
            this.buttonSoPhanTu.UseVisualStyleBackColor = true;
            this.buttonSoPhanTu.Click += new System.EventHandler(this.buttonSoPhanTu_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(538, 245);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(159, 40);
            this.buttonSua.TabIndex = 6;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonSoNT
            // 
            this.buttonSoNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoNT.Location = new System.Drawing.Point(538, 291);
            this.buttonSoNT.Name = "buttonSoNT";
            this.buttonSoNT.Size = new System.Drawing.Size(159, 38);
            this.buttonSoNT.TabIndex = 7;
            this.buttonSoNT.Text = "Số NT";
            this.buttonSoNT.UseVisualStyleBackColor = true;
            this.buttonSoNT.Click += new System.EventHandler(this.buttonSoNT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSoNT);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonSoPhanTu);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonNhapTuDong);
            this.Controls.Add(this.buttonHienThiCacPhanTu);
            this.Controls.Add(this.buttonXoaPhanTu);
            this.Controls.Add(this.buttonNhapVaoDanhSach);
            this.Controls.Add(this.InDanhSach);
            this.Controls.Add(this.textBoxNhapDanhSach);
            this.Controls.Add(this.labelNhapSoNguyen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhapSoNguyen;
        private System.Windows.Forms.TextBox textBoxNhapDanhSach;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox InDanhSach;
        private System.Windows.Forms.Button buttonNhapVaoDanhSach;
        private System.Windows.Forms.Button buttonXoaPhanTu;
        private System.Windows.Forms.Button buttonHienThiCacPhanTu;
        private System.Windows.Forms.Button buttonNhapTuDong;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonSoPhanTu;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonSoNT;
    }
}

