using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace HT_QL_TTTH
{
    public partial class GUI_Admin_DSHocVien : Form
    {
        public GUI_Admin_DSHocVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtDSHV.Rows[e.RowIndex];
                tbName.Text = row.Cells["TENHV"].Value.ToString();
                tbMaHV.Text = row.Cells["MAHV"].Value.ToString();
                tbNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
                tbEmail.Text = row.Cells["EMAIL"].Value.ToString();
                tbSDT.Text = row.Cells["SDT"].Value.ToString();
                tbNgayBatDau.Text = row.Cells["NGAYBATDAU"].Value.ToString();
            }
        }

        private void GUI_Admin_DSHocVien_Load(object sender, EventArgs e)
        {
            dtDSHV.DataSource = BUS_User.DanhSachHocVien();
        }
    }
}
