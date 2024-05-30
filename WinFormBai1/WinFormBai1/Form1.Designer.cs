namespace WinFormBai1
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
            this.Txta = new System.Windows.Forms.TextBox();
            this.Txtb = new System.Windows.Forms.TextBox();
            this.TxtketQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiaiPTbac1 = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.ChanOrle = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.TextAB = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txta
            // 
            this.Txta.Location = new System.Drawing.Point(290, 55);
            this.Txta.Name = "Txta";
            this.Txta.Size = new System.Drawing.Size(219, 22);
            this.Txta.TabIndex = 1;
            this.Txta.TextChanged += new System.EventHandler(this.Txta_TextChanged);
            // 
            // Txtb
            // 
            this.Txtb.Location = new System.Drawing.Point(290, 99);
            this.Txtb.Name = "Txtb";
            this.Txtb.Size = new System.Drawing.Size(219, 22);
            this.Txtb.TabIndex = 3;
            this.Txtb.TextChanged += new System.EventHandler(this.Txtb_TextChanged);
            // 
            // TxtketQua
            // 
            this.TxtketQua.Location = new System.Drawing.Point(290, 151);
            this.TxtketQua.Name = "TxtketQua";
            this.TxtketQua.Size = new System.Drawing.Size(375, 22);
            this.TxtketQua.TabIndex = 5;
            this.TxtketQua.TextChanged += new System.EventHandler(this.TxtketQua_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap a:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhap b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ket Qua:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGiaiPTbac1
            // 
            this.btnGiaiPTbac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPTbac1.Location = new System.Drawing.Point(167, 242);
            this.btnGiaiPTbac1.Name = "btnGiaiPTbac1";
            this.btnGiaiPTbac1.Size = new System.Drawing.Size(100, 40);
            this.btnGiaiPTbac1.TabIndex = 6;
            this.btnGiaiPTbac1.Text = "Giai PT bac nhat";
            this.btnGiaiPTbac1.UseVisualStyleBackColor = true;
            this.btnGiaiPTbac1.Click += new System.EventHandler(this.btnGiaiPTbac1_Click);
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(290, 242);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(100, 40);
            this.btnCong.TabIndex = 7;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnhan
            // 
            this.btnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhan.Location = new System.Drawing.Point(421, 242);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(100, 40);
            this.btnhan.TabIndex = 10;
            this.btnhan.Text = "Nhan";
            this.btnhan.UseVisualStyleBackColor = true;
            this.btnhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChanOrle
            // 
            this.ChanOrle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanOrle.Location = new System.Drawing.Point(544, 242);
            this.ChanOrle.Name = "ChanOrle";
            this.ChanOrle.Size = new System.Drawing.Size(100, 40);
            this.ChanOrle.TabIndex = 11;
            this.ChanOrle.Text = "Chan or le";
            this.ChanOrle.UseVisualStyleBackColor = true;
            this.ChanOrle.Click += new System.EventHandler(this.ChanOrle_Click);
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChia.Location = new System.Drawing.Point(167, 302);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(100, 40);
            this.btChia.TabIndex = 8;
            this.btChia.Text = "Chia";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(290, 302);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(100, 40);
            this.btTru.TabIndex = 9;
            this.btTru.Text = "Tru";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // TextAB
            // 
            this.TextAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAB.Location = new System.Drawing.Point(421, 302);
            this.TextAB.Name = "TextAB";
            this.TextAB.Size = new System.Drawing.Size(100, 40);
            this.TextAB.TabIndex = 12;
            this.TextAB.Text = "Text a>b";
            this.TextAB.UseVisualStyleBackColor = true;
            this.TextAB.Click += new System.EventHandler(this.TextAB_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancel.Location = new System.Drawing.Point(354, 381);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(97, 32);
            this.BTCancel.TabIndex = 14;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.ChanOrle);
            this.Controls.Add(this.TextAB);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnGiaiPTbac1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtketQua);
            this.Controls.Add(this.Txtb);
            this.Controls.Add(this.Txta);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giai Phuong Trinh Bac nhat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txta;
        private System.Windows.Forms.TextBox Txtb;
        private System.Windows.Forms.TextBox TxtketQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiaiPTbac1;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button ChanOrle;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button TextAB;
        private System.Windows.Forms.Button BTCancel;
    }
}

