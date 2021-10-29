
namespace HT_QL_TTTH
{
    partial class GUI_Admin_ThemLopMo
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSiSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbTietBD = new System.Windows.Forms.ComboBox();
            this.cbTietKT = new System.Windows.Forms.ComboBox();
            this.cbThu = new System.Windows.Forms.ComboBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(573, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(121)))), ((int)(((byte)(242)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(608, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm lớp mở";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbSiSo
            // 
            this.tbSiSo.ForeColor = System.Drawing.Color.Black;
            this.tbSiSo.Location = new System.Drawing.Point(410, 106);
            this.tbSiSo.Name = "tbSiSo";
            this.tbSiSo.Size = new System.Drawing.Size(186, 20);
            this.tbSiSo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại lớp mở:";
            // 
            // cbLoaiLop
            // 
            this.cbLoaiLop.FormattingEnabled = true;
            this.cbLoaiLop.Items.AddRange(new object[] {
            "Hoc Phan",
            "Chuyen De",
            "Chung Chi"});
            this.cbLoaiLop.Location = new System.Drawing.Point(111, 105);
            this.cbLoaiLop.Name = "cbLoaiLop";
            this.cbLoaiLop.Size = new System.Drawing.Size(186, 21);
            this.cbLoaiLop.TabIndex = 6;
            this.cbLoaiLop.SelectedIndexChanged += new System.EventHandler(this.cbLoaiLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Môn học:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(111, 157);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(186, 21);
            this.cbMonHoc.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sĩ số tối đa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thứ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tiết bắt đầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tiết kết thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Thông tin lớp học";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Thông tin thời khóa biểu";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(121)))), ((int)(((byte)(242)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(224, 361);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(189, 31);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbTietBD
            // 
            this.cbTietBD.FormattingEnabled = true;
            this.cbTietBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbTietBD.Location = new System.Drawing.Point(410, 245);
            this.cbTietBD.Name = "cbTietBD";
            this.cbTietBD.Size = new System.Drawing.Size(186, 21);
            this.cbTietBD.TabIndex = 27;
            // 
            // cbTietKT
            // 
            this.cbTietKT.FormattingEnabled = true;
            this.cbTietKT.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbTietKT.Location = new System.Drawing.Point(410, 296);
            this.cbTietKT.Name = "cbTietKT";
            this.cbTietKT.Size = new System.Drawing.Size(186, 21);
            this.cbTietKT.TabIndex = 28;
            this.cbTietKT.SelectedIndexChanged += new System.EventHandler(this.cbTietKT_SelectedIndexChanged);
            // 
            // cbThu
            // 
            this.cbThu.FormattingEnabled = true;
            this.cbThu.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbThu.Location = new System.Drawing.Point(111, 245);
            this.cbThu.Name = "cbThu";
            this.cbThu.Size = new System.Drawing.Size(186, 21);
            this.cbThu.TabIndex = 29;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(111, 296);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(186, 20);
            this.dtpNgayBatDau.TabIndex = 30;
            // 
            // lbThongBao
            // 
            this.lbThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbThongBao.Location = new System.Drawing.Point(407, 320);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(186, 13);
            this.lbThongBao.TabIndex = 0;
            this.lbThongBao.Text = "Tiết kết thúc phải lớn hơn tiết bắt đầu";
            // 
            // GUI_Admin_ThemLopMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.cbThu);
            this.Controls.Add(this.cbTietKT);
            this.Controls.Add(this.cbTietBD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSiSo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Admin_ThemLopMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Admin_ThemLopMo";
            this.Load += new System.EventHandler(this.GUI_Admin_ThemLopMo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTietBD;
        private System.Windows.Forms.ComboBox cbTietKT;
        private System.Windows.Forms.ComboBox cbThu;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lbThongBao;
    }
}