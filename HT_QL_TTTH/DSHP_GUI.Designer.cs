
namespace HT_QL_TTTH
{
    partial class DSHP_GUI
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
            this.tbDTBTotNghiep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemTongQuan = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenHP = new System.Windows.Forms.ComboBox();
            this.dtDSHP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHP)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDTBTotNghiep
            // 
            this.tbDTBTotNghiep.BackColor = System.Drawing.Color.White;
            this.tbDTBTotNghiep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDTBTotNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDTBTotNghiep.ForeColor = System.Drawing.Color.Black;
            this.tbDTBTotNghiep.Location = new System.Drawing.Point(482, 545);
            this.tbDTBTotNghiep.Multiline = true;
            this.tbDTBTotNghiep.Name = "tbDTBTotNghiep";
            this.tbDTBTotNghiep.ReadOnly = true;
            this.tbDTBTotNghiep.Size = new System.Drawing.Size(50, 27);
            this.tbDTBTotNghiep.TabIndex = 41;
            this.tbDTBTotNghiep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(253, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Điểm Trung Bình Xét Tốt Nghiệp";
            // 
            // btnXemTongQuan
            // 
            this.btnXemTongQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnXemTongQuan.FlatAppearance.BorderSize = 0;
            this.btnXemTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTongQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnXemTongQuan.Location = new System.Drawing.Point(12, 79);
            this.btnXemTongQuan.Name = "btnXemTongQuan";
            this.btnXemTongQuan.Size = new System.Drawing.Size(114, 23);
            this.btnXemTongQuan.TabIndex = 39;
            this.btnXemTongQuan.Text = "Xem Tổng Quan";
            this.btnXemTongQuan.UseVisualStyleBackColor = false;
            this.btnXemTongQuan.Click += new System.EventHandler(this.btnXemTongQuan_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnXemChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(482, 75);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(114, 23);
            this.btnXemChiTiet.TabIndex = 38;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(209, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên Học Phần";
            // 
            // cbTenHP
            // 
            this.cbTenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenHP.FormattingEnabled = true;
            this.cbTenHP.Location = new System.Drawing.Point(324, 79);
            this.cbTenHP.Name = "cbTenHP";
            this.cbTenHP.Size = new System.Drawing.Size(127, 24);
            this.cbTenHP.TabIndex = 36;
            // 
            // dtDSHP
            // 
            this.dtDSHP.BackgroundColor = System.Drawing.Color.White;
            this.dtDSHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSHP.Location = new System.Drawing.Point(12, 109);
            this.dtDSHP.Name = "dtDSHP";
            this.dtDSHP.Size = new System.Drawing.Size(584, 418);
            this.dtDSHP.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(608, 50);
            this.button1.TabIndex = 34;
            this.button1.Text = "Danh Sách Học Phần";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbnClose
            // 
            this.tbnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbnClose.FlatAppearance.BorderSize = 0;
            this.tbnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnClose.ForeColor = System.Drawing.Color.White;
            this.tbnClose.Location = new System.Drawing.Point(573, 12);
            this.tbnClose.Name = "tbnClose";
            this.tbnClose.Size = new System.Drawing.Size(23, 23);
            this.tbnClose.TabIndex = 42;
            this.tbnClose.Text = "X";
            this.tbnClose.UseVisualStyleBackColor = false;
            this.tbnClose.Click += new System.EventHandler(this.tbnClose_Click);
            // 
            // DSHP_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.tbnClose);
            this.Controls.Add(this.tbDTBTotNghiep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXemTongQuan);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenHP);
            this.Controls.Add(this.dtDSHP);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DSHP_GUI";
            this.Text = "DSHP_GUI";
            this.Load += new System.EventHandler(this.DSHP_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDTBTotNghiep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXemTongQuan;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenHP;
        private System.Windows.Forms.DataGridView dtDSHP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tbnClose;
    }
}