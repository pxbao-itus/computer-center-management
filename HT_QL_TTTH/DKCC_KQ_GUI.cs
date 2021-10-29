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
    public partial class DKCC_KQ_GUI : Form
    {
        public DKCC_KQ_GUI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void DKCC_KQ_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                dtDSCC_DaDK.DataSource = BUS_ChungChi.DanhSachMonChungChiDaDangKy();
                cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHoc.Text = BUS_Config.NamHoc.ToString();
                cbHocKy.Text = BUS_Config.HocKy.ToString();

            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbHocKy.Text == "" || cbNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            dtDSCC_DaDK.DataSource = BUS_ChungChi.DanhSachMonChungChiDaDangKy(cbHocKy.Text, cbNamHoc.Text);
        }
    }
}
