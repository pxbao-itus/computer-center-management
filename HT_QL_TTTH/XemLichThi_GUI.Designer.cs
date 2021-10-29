
namespace HT_QL_TTTH
{
    partial class XemLichThi_GUI
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.dtLichThi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXemTL = new System.Windows.Forms.Button();
            this.cbNamHocTL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHocKyTL = new System.Windows.Forms.ComboBox();
            this.dtLichThiLai = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtLichThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLichThiLai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(576, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(416, 65);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(151, 23);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(284, 65);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(80, 24);
            this.cbNamHoc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(213, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Năm học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Học kỳ:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(104, 65);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(80, 24);
            this.cbHocKy.TabIndex = 11;
            // 
            // dtLichThi
            // 
            this.dtLichThi.BackgroundColor = System.Drawing.Color.White;
            this.dtLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLichThi.Location = new System.Drawing.Point(12, 115);
            this.dtLichThi.Name = "dtLichThi";
            this.dtLichThi.ReadOnly = true;
            this.dtLichThi.Size = new System.Drawing.Size(584, 231);
            this.dtLichThi.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(608, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lịch thi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnXemTL
            // 
            this.btnXemTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnXemTL.FlatAppearance.BorderSize = 0;
            this.btnXemTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTL.ForeColor = System.Drawing.Color.White;
            this.btnXemTL.Location = new System.Drawing.Point(416, 353);
            this.btnXemTL.Name = "btnXemTL";
            this.btnXemTL.Size = new System.Drawing.Size(151, 23);
            this.btnXemTL.TabIndex = 23;
            this.btnXemTL.Text = "Xem";
            this.btnXemTL.UseVisualStyleBackColor = false;
            // 
            // cbNamHocTL
            // 
            this.cbNamHocTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHocTL.FormattingEnabled = true;
            this.cbNamHocTL.Location = new System.Drawing.Point(284, 353);
            this.cbNamHocTL.Name = "cbNamHocTL";
            this.cbNamHocTL.Size = new System.Drawing.Size(80, 24);
            this.cbNamHocTL.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(213, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Năm học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Học kỳ:";
            // 
            // cbHocKyTL
            // 
            this.cbHocKyTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKyTL.FormattingEnabled = true;
            this.cbHocKyTL.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKyTL.Location = new System.Drawing.Point(104, 353);
            this.cbHocKyTL.Name = "cbHocKyTL";
            this.cbHocKyTL.Size = new System.Drawing.Size(80, 24);
            this.cbHocKyTL.TabIndex = 19;
            // 
            // dtLichThiLai
            // 
            this.dtLichThiLai.BackgroundColor = System.Drawing.Color.White;
            this.dtLichThiLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLichThiLai.Location = new System.Drawing.Point(12, 402);
            this.dtLichThiLai.Name = "dtLichThiLai";
            this.dtLichThiLai.ReadOnly = true;
            this.dtLichThiLai.Size = new System.Drawing.Size(584, 161);
            this.dtLichThiLai.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lịch thi chính thức";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Lịch thi lại";
            // 
            // XemLichThi_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXemTL);
            this.Controls.Add(this.cbNamHocTL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHocKyTL);
            this.Controls.Add(this.dtLichThiLai);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.dtLichThi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XemLichThi_GUI";
            this.Text = "XemLichThi_GUI";
            this.Load += new System.EventHandler(this.XemLichThi_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLichThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLichThiLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.DataGridView dtLichThi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXemTL;
        private System.Windows.Forms.ComboBox cbNamHocTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHocKyTL;
        private System.Windows.Forms.DataGridView dtLichThiLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}