
namespace HT_QL_TTTH
{
    partial class GUI_Admin_DSHocVien
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtDSHV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMaHV = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNgayBatDau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHV)).BeginInit();
            this.SuspendLayout();
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
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý học viên";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(573, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtDSHV
            // 
            this.dtDSHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDSHV.BackgroundColor = System.Drawing.Color.White;
            this.dtDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSHV.Location = new System.Drawing.Point(12, 181);
            this.dtDSHV.Name = "dtDSHV";
            this.dtDSHV.ReadOnly = true;
            this.dtDSHV.Size = new System.Drawing.Size(584, 382);
            this.dtDSHV.TabIndex = 2;
            this.dtDSHV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên học viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã học viên:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 72);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(181, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbMaHV
            // 
            this.tbMaHV.Location = new System.Drawing.Point(106, 105);
            this.tbMaHV.Name = "tbMaHV";
            this.tbMaHV.ReadOnly = true;
            this.tbMaHV.Size = new System.Drawing.Size(181, 20);
            this.tbMaHV.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(415, 72);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(181, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(415, 105);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.ReadOnly = true;
            this.tbSDT.Size = new System.Drawing.Size(181, 20);
            this.tbSDT.TabIndex = 10;
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(106, 141);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.ReadOnly = true;
            this.tbNgaySinh.Size = new System.Drawing.Size(181, 20);
            this.tbNgaySinh.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày sinh:";
            // 
            // tbNgayBatDau
            // 
            this.tbNgayBatDau.Location = new System.Drawing.Point(415, 141);
            this.tbNgayBatDau.Name = "tbNgayBatDau";
            this.tbNgayBatDau.ReadOnly = true;
            this.tbNgayBatDau.Size = new System.Drawing.Size(181, 20);
            this.tbNgayBatDau.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // GUI_Admin_DSHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.tbNgayBatDau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbMaHV);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDSHV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Admin_DSHocVien";
            this.Text = "GUI_Admin_DSHocVien";
            this.Load += new System.EventHandler(this.GUI_Admin_DSHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtDSHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMaHV;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNgayBatDau;
        private System.Windows.Forms.Label label6;
    }
}