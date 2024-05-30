namespace Bài_2
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
            this.ButtonHienThi = new System.Windows.Forms.Button();
            this.JLThang = new System.Windows.Forms.Label();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.JTKetQua = new System.Windows.Forms.Label();
            this.JTKetQuKetqua = new System.Windows.Forms.TextBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonHienThi
            // 
            this.ButtonHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHienThi.Location = new System.Drawing.Point(108, 272);
            this.ButtonHienThi.Name = "ButtonHienThi";
            this.ButtonHienThi.Size = new System.Drawing.Size(122, 46);
            this.ButtonHienThi.TabIndex = 0;
            this.ButtonHienThi.Text = "Hiển Thị";
            this.ButtonHienThi.UseVisualStyleBackColor = true;
            this.ButtonHienThi.Click += new System.EventHandler(this.ButtonHienThi_Click);
            // 
            // JLThang
            // 
            this.JLThang.AutoSize = true;
            this.JLThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JLThang.Location = new System.Drawing.Point(108, 49);
            this.JLThang.Name = "JLThang";
            this.JLThang.Size = new System.Drawing.Size(113, 25);
            this.JLThang.TabIndex = 1;
            this.JLThang.Text = "Nhập tháng";
            // 
            // textBoxThang
            // 
            this.textBoxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThang.Location = new System.Drawing.Point(326, 40);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(171, 34);
            this.textBoxThang.TabIndex = 2;
            // 
            // JTKetQua
            // 
            this.JTKetQua.AutoSize = true;
            this.JTKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTKetQua.Location = new System.Drawing.Point(108, 165);
            this.JTKetQua.Name = "JTKetQua";
            this.JTKetQua.Size = new System.Drawing.Size(80, 25);
            this.JTKetQua.TabIndex = 1;
            this.JTKetQua.Text = "Kết quả";
            // 
            // JTKetQuKetqua
            // 
            this.JTKetQuKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTKetQuKetqua.Location = new System.Drawing.Point(326, 156);
            this.JTKetQuKetqua.Name = "JTKetQuKetqua";
            this.JTKetQuKetqua.Size = new System.Drawing.Size(327, 34);
            this.JTKetQuKetqua.TabIndex = 2;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNam.Location = new System.Drawing.Point(108, 108);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(102, 25);
            this.labelNam.TabIndex = 1;
            this.labelNam.Text = "Nhập nam";
            // 
            // textBoxNam
            // 
            this.textBoxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNam.Location = new System.Drawing.Point(326, 99);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(171, 34);
            this.textBoxNam.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(443, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 46);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.ButtonHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JTKetQuKetqua);
            this.Controls.Add(this.textBoxNam);
            this.Controls.Add(this.textBoxThang);
            this.Controls.Add(this.JTKetQua);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.JLThang);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ButtonHienThi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập tháng tính số ngày";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonHienThi;
        private System.Windows.Forms.Label JLThang;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.Label JTKetQua;
        private System.Windows.Forms.TextBox JTKetQuKetqua;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.Button btnCancel;
    }
}

