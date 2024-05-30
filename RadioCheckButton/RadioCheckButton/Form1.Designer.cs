namespace RadioCheckButton
{
    partial class CheckBoxRadio
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxChonMauChu = new System.Windows.Forms.GroupBox();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.radioButtonViolet = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.groupBoxChonDangchu = new System.Windows.Forms.GroupBox();
            this.checkBoxUderLine = new System.Windows.Forms.CheckBox();
            this.checkBoxRegular = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBoxChonMauChu.SuspendLayout();
            this.groupBoxChonDangchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNhapChuoi
            // 
            this.labelNhapChuoi.AutoSize = true;
            this.labelNhapChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapChuoi.Location = new System.Drawing.Point(55, 28);
            this.labelNhapChuoi.Name = "labelNhapChuoi";
            this.labelNhapChuoi.Size = new System.Drawing.Size(140, 29);
            this.labelNhapChuoi.TabIndex = 0;
            this.labelNhapChuoi.Text = "Nhập Chuỗi";
            // 
            // textBoxNhapChuoi
            // 
            this.textBoxNhapChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapChuoi.Location = new System.Drawing.Point(260, 25);
            this.textBoxNhapChuoi.Name = "textBoxNhapChuoi";
            this.textBoxNhapChuoi.Size = new System.Drawing.Size(380, 34);
            this.textBoxNhapChuoi.TabIndex = 1;
            this.textBoxNhapChuoi.Text = "weg";
            this.textBoxNhapChuoi.TextChanged += new System.EventHandler(this.textBoxNhapChuoi_TextChanged);
            // 
            // groupBoxChonMauChu
            // 
            this.groupBoxChonMauChu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxChonMauChu.Controls.Add(this.radioButtonYellow);
            this.groupBoxChonMauChu.Controls.Add(this.radioButtonViolet);
            this.groupBoxChonMauChu.Controls.Add(this.radioButtonBlue);
            this.groupBoxChonMauChu.Controls.Add(this.radioButtonRed);
            this.groupBoxChonMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChonMauChu.Location = new System.Drawing.Point(93, 114);
            this.groupBoxChonMauChu.Name = "groupBoxChonMauChu";
            this.groupBoxChonMauChu.Size = new System.Drawing.Size(240, 186);
            this.groupBoxChonMauChu.TabIndex = 2;
            this.groupBoxChonMauChu.TabStop = false;
            this.groupBoxChonMauChu.Text = "Chọn màu chữ";
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYellow.ForeColor = System.Drawing.Color.Yellow;
            this.radioButtonYellow.Location = new System.Drawing.Point(26, 147);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(84, 26);
            this.radioButtonYellow.TabIndex = 0;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yellow";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            this.radioButtonYellow.CheckedChanged += new System.EventHandler(this.radioButtonYellow_CheckedChanged);
            // 
            // radioButtonViolet
            // 
            this.radioButtonViolet.AutoSize = true;
            this.radioButtonViolet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonViolet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButtonViolet.Location = new System.Drawing.Point(26, 108);
            this.radioButtonViolet.Name = "radioButtonViolet";
            this.radioButtonViolet.Size = new System.Drawing.Size(76, 26);
            this.radioButtonViolet.TabIndex = 0;
            this.radioButtonViolet.TabStop = true;
            this.radioButtonViolet.Text = "Violet";
            this.radioButtonViolet.UseVisualStyleBackColor = true;
            this.radioButtonViolet.CheckedChanged += new System.EventHandler(this.radioButtonViolet_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(26, 71);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(67, 26);
            this.radioButtonBlue.TabIndex = 0;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(26, 31);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(64, 26);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // groupBoxChonDangchu
            // 
            this.groupBoxChonDangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxChonDangchu.Controls.Add(this.checkBoxUderLine);
            this.groupBoxChonDangchu.Controls.Add(this.checkBoxRegular);
            this.groupBoxChonDangchu.Controls.Add(this.checkBoxItalic);
            this.groupBoxChonDangchu.Controls.Add(this.checkBoxBold);
            this.groupBoxChonDangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChonDangchu.Location = new System.Drawing.Point(473, 114);
            this.groupBoxChonDangchu.Name = "groupBoxChonDangchu";
            this.groupBoxChonDangchu.Size = new System.Drawing.Size(231, 186);
            this.groupBoxChonDangchu.TabIndex = 3;
            this.groupBoxChonDangchu.TabStop = false;
            this.groupBoxChonDangchu.Text = "Chọn dáng chữ";
            // 
            // checkBoxUderLine
            // 
            this.checkBoxUderLine.AutoSize = true;
            this.checkBoxUderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUderLine.Location = new System.Drawing.Point(34, 109);
            this.checkBoxUderLine.Name = "checkBoxUderLine";
            this.checkBoxUderLine.Size = new System.Drawing.Size(99, 26);
            this.checkBoxUderLine.TabIndex = 0;
            this.checkBoxUderLine.Text = "Uderline";
            this.checkBoxUderLine.UseVisualStyleBackColor = true;
            this.checkBoxUderLine.CheckedChanged += new System.EventHandler(this.checkBoxUderLine_CheckedChanged);
            // 
            // checkBoxRegular
            // 
            this.checkBoxRegular.AutoSize = true;
            this.checkBoxRegular.Location = new System.Drawing.Point(34, 148);
            this.checkBoxRegular.Name = "checkBoxRegular";
            this.checkBoxRegular.Size = new System.Drawing.Size(95, 26);
            this.checkBoxRegular.TabIndex = 0;
            this.checkBoxRegular.Text = "Regular";
            this.checkBoxRegular.UseVisualStyleBackColor = true;
            this.checkBoxRegular.CheckedChanged += new System.EventHandler(this.checkBoxRegular_CheckedChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItalic.Location = new System.Drawing.Point(34, 71);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(68, 26);
            this.checkBoxItalic.TabIndex = 0;
            this.checkBoxItalic.Text = "Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBold.Location = new System.Drawing.Point(34, 28);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(72, 26);
            this.checkBoxBold.TabIndex = 0;
            this.checkBoxBold.Text = "Bold";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBoxBold_CheckedChanged);
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKetQua.Location = new System.Drawing.Point(60, 358);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(95, 29);
            this.labelKetQua.TabIndex = 4;
            this.labelKetQua.Text = "Kết quả";
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKetQua.Location = new System.Drawing.Point(161, 353);
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(370, 34);
            this.textBoxKetQua.TabIndex = 5;
            this.textBoxKetQua.Text = "r";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(600, 353);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(104, 34);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // CheckBoxRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.groupBoxChonDangchu);
            this.Controls.Add(this.groupBoxChonMauChu);
            this.Controls.Add(this.textBoxNhapChuoi);
            this.Controls.Add(this.labelNhapChuoi);
            this.Name = "CheckBoxRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Check Box";
            this.groupBoxChonMauChu.ResumeLayout(false);
            this.groupBoxChonMauChu.PerformLayout();
            this.groupBoxChonDangchu.ResumeLayout(false);
            this.groupBoxChonDangchu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhapChuoi;
        private System.Windows.Forms.TextBox textBoxNhapChuoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxChonMauChu;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.RadioButton radioButtonViolet;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.GroupBox groupBoxChonDangchu;
        private System.Windows.Forms.CheckBox checkBoxUderLine;
        private System.Windows.Forms.CheckBox checkBoxRegular;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Button buttonThoat;
    }
}

