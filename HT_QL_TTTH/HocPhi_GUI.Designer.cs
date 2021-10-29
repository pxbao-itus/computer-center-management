
namespace HT_QL_TTTH
{
    partial class HocPhi_GUI
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
            this.dtHocPhi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.dtHocPhiCC = new System.Windows.Forms.DataGridView();
            this.tbTongTienCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXemCC = new System.Windows.Forms.Button();
            this.cbNamHocCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHocKyCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHocPhiCC)).BeginInit();
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
            this.btnXem.Location = new System.Drawing.Point(410, 77);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(186, 23);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.BackColor = System.Drawing.Color.White;
            this.cbNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.ForeColor = System.Drawing.Color.Black;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(284, 77);
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
            this.label2.Location = new System.Drawing.Point(213, 80);
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
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Học kỳ:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.BackColor = System.Drawing.Color.White;
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.ForeColor = System.Drawing.Color.Black;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(104, 77);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(80, 24);
            this.cbHocKy.TabIndex = 11;
            // 
            // dtHocPhi
            // 
            this.dtHocPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtHocPhi.BackgroundColor = System.Drawing.Color.White;
            this.dtHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHocPhi.Location = new System.Drawing.Point(12, 146);
            this.dtHocPhi.Name = "dtHocPhi";
            this.dtHocPhi.ReadOnly = true;
            this.dtHocPhi.Size = new System.Drawing.Size(584, 174);
            this.dtHocPhi.TabIndex = 10;
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
            this.button1.Text = "Học phí";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(262, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tổng tiền phải đóng: ";
            // 
            // tbSum
            // 
            this.tbSum.BackColor = System.Drawing.Color.White;
            this.tbSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSum.Location = new System.Drawing.Point(410, 120);
            this.tbSum.Multiline = true;
            this.tbSum.Name = "tbSum";
            this.tbSum.ReadOnly = true;
            this.tbSum.Size = new System.Drawing.Size(186, 20);
            this.tbSum.TabIndex = 19;
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtHocPhiCC
            // 
            this.dtHocPhiCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtHocPhiCC.BackgroundColor = System.Drawing.Color.White;
            this.dtHocPhiCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHocPhiCC.Location = new System.Drawing.Point(12, 404);
            this.dtHocPhiCC.Name = "dtHocPhiCC";
            this.dtHocPhiCC.ReadOnly = true;
            this.dtHocPhiCC.Size = new System.Drawing.Size(584, 159);
            this.dtHocPhiCC.TabIndex = 20;
            // 
            // tbTongTienCC
            // 
            this.tbTongTienCC.BackColor = System.Drawing.Color.White;
            this.tbTongTienCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTienCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTongTienCC.Location = new System.Drawing.Point(410, 378);
            this.tbTongTienCC.Multiline = true;
            this.tbTongTienCC.Name = "tbTongTienCC";
            this.tbTongTienCC.ReadOnly = true;
            this.tbTongTienCC.Size = new System.Drawing.Size(186, 20);
            this.tbTongTienCC.TabIndex = 27;
            this.tbTongTienCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(262, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tổng tiền phải đóng: ";
            // 
            // btnXemCC
            // 
            this.btnXemCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnXemCC.FlatAppearance.BorderSize = 0;
            this.btnXemCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCC.ForeColor = System.Drawing.Color.White;
            this.btnXemCC.Location = new System.Drawing.Point(410, 336);
            this.btnXemCC.Name = "btnXemCC";
            this.btnXemCC.Size = new System.Drawing.Size(186, 23);
            this.btnXemCC.TabIndex = 25;
            this.btnXemCC.Text = "Xem";
            this.btnXemCC.UseVisualStyleBackColor = false;
            this.btnXemCC.Click += new System.EventHandler(this.btnXemCC_Click);
            // 
            // cbNamHocCC
            // 
            this.cbNamHocCC.BackColor = System.Drawing.Color.White;
            this.cbNamHocCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHocCC.ForeColor = System.Drawing.Color.Black;
            this.cbNamHocCC.FormattingEnabled = true;
            this.cbNamHocCC.Location = new System.Drawing.Point(284, 336);
            this.cbNamHocCC.Name = "cbNamHocCC";
            this.cbNamHocCC.Size = new System.Drawing.Size(80, 24);
            this.cbNamHocCC.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(213, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Năm học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Học kỳ:";
            // 
            // cbHocKyCC
            // 
            this.cbHocKyCC.BackColor = System.Drawing.Color.White;
            this.cbHocKyCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKyCC.ForeColor = System.Drawing.Color.Black;
            this.cbHocKyCC.FormattingEnabled = true;
            this.cbHocKyCC.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKyCC.Location = new System.Drawing.Point(104, 336);
            this.cbHocKyCC.Name = "cbHocKyCC";
            this.cbHocKyCC.Size = new System.Drawing.Size(80, 24);
            this.cbHocKyCC.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Học phí các lớp học phần";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Học phí các lớp chứng chỉ";
            // 
            // HocPhi_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTongTienCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemCC);
            this.Controls.Add(this.cbNamHocCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbHocKyCC);
            this.Controls.Add(this.dtHocPhiCC);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.dtHocPhi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HocPhi_GUI";
            this.Text = "HocPhi_GUI";
            this.Load += new System.EventHandler(this.HocPhi_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHocPhiCC)).EndInit();
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
        private System.Windows.Forms.DataGridView dtHocPhi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.DataGridView dtHocPhiCC;
        private System.Windows.Forms.TextBox tbTongTienCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemCC;
        private System.Windows.Forms.ComboBox cbNamHocCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHocKyCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}