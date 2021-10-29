
namespace HT_QL_TTTH
{
    partial class DKHP_GUI
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
            this.dtHPDcDk = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTinChi_ConLai = new System.Windows.Forms.TextBox();
            this.tbTinChi_DaDangKy = new System.Windows.Forms.TextBox();
            this.tbTinChi_ToiDa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtHpDaDK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtHPDcDk)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHpDaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHPDcDk
            // 
            this.dtHPDcDk.BackgroundColor = System.Drawing.Color.White;
            this.dtHPDcDk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtHPDcDk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHPDcDk.Location = new System.Drawing.Point(12, 327);
            this.dtHPDcDk.Name = "dtHPDcDk";
            this.dtHPDcDk.ReadOnly = true;
            this.dtHPDcDk.Size = new System.Drawing.Size(385, 237);
            this.dtHPDcDk.TabIndex = 0;
            this.dtHPDcDk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHPDcDk_CellClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Danh sách học phần được phép đăng ký ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnHuyDangKy.FlatAppearance.BorderSize = 0;
            this.btnHuyDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDangKy.ForeColor = System.Drawing.Color.White;
            this.btnHuyDangKy.Location = new System.Drawing.Point(403, 244);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(193, 35);
            this.btnHuyDangKy.TabIndex = 3;
            this.btnHuyDangKy.Text = "Hủy đăng ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = false;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(403, 327);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(193, 35);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbTinChi_ConLai);
            this.panel1.Controls.Add(this.tbTinChi_DaDangKy);
            this.panel1.Controls.Add(this.tbTinChi_ToiDa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(403, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 100);
            this.panel1.TabIndex = 5;
            // 
            // tbTinChi_ConLai
            // 
            this.tbTinChi_ConLai.ForeColor = System.Drawing.Color.Black;
            this.tbTinChi_ConLai.Location = new System.Drawing.Point(125, 65);
            this.tbTinChi_ConLai.Name = "tbTinChi_ConLai";
            this.tbTinChi_ConLai.ReadOnly = true;
            this.tbTinChi_ConLai.Size = new System.Drawing.Size(61, 20);
            this.tbTinChi_ConLai.TabIndex = 5;
            this.tbTinChi_ConLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTinChi_DaDangKy
            // 
            this.tbTinChi_DaDangKy.ForeColor = System.Drawing.Color.Black;
            this.tbTinChi_DaDangKy.Location = new System.Drawing.Point(125, 39);
            this.tbTinChi_DaDangKy.Name = "tbTinChi_DaDangKy";
            this.tbTinChi_DaDangKy.ReadOnly = true;
            this.tbTinChi_DaDangKy.Size = new System.Drawing.Size(61, 20);
            this.tbTinChi_DaDangKy.TabIndex = 4;
            this.tbTinChi_DaDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTinChi_ToiDa
            // 
            this.tbTinChi_ToiDa.ForeColor = System.Drawing.Color.Black;
            this.tbTinChi_ToiDa.Location = new System.Drawing.Point(125, 10);
            this.tbTinChi_ToiDa.Name = "tbTinChi_ToiDa";
            this.tbTinChi_ToiDa.ReadOnly = true;
            this.tbTinChi_ToiDa.Size = new System.Drawing.Size(61, 20);
            this.tbTinChi_ToiDa.TabIndex = 3;
            this.tbTinChi_ToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ còn lại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tín chỉ đăng ký: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tín chỉ tối đa: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(576, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(166)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(608, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "Đăng ký học phần";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(12, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(385, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Danh sách học phần đã đăng ký ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dtHpDaDK
            // 
            this.dtHpDaDK.BackgroundColor = System.Drawing.Color.White;
            this.dtHpDaDK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtHpDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHpDaDK.Location = new System.Drawing.Point(12, 99);
            this.dtHpDaDK.Name = "dtHpDaDK";
            this.dtHpDaDK.ReadOnly = true;
            this.dtHpDaDK.Size = new System.Drawing.Size(385, 180);
            this.dtHpDaDK.TabIndex = 20;
            this.dtHpDaDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHpDaDK_CellClick);
            // 
            // DKHP_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.dtHpDaDK);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnHuyDangKy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtHPDcDk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DKHP_GUI";
            this.Text = "DKHPGUI";
            this.Load += new System.EventHandler(this.DKHP_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHPDcDk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHpDaDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtHPDcDk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTinChi_ConLai;
        private System.Windows.Forms.TextBox tbTinChi_DaDangKy;
        private System.Windows.Forms.TextBox tbTinChi_ToiDa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtHpDaDK;
    }
}