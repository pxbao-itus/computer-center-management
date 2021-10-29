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
    public partial class DKCD_KQ_GUI : Form
    {
        public DKCD_KQ_GUI()
        {
            InitializeComponent();
        }

        private void DKCD_KQ_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                dtDS_CD_DK.DataSource = BUS_ChuyenDe.DanhSachChuyenDeDaDangKy();
                cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHoc.Text = BUS_Config.NamHoc.ToString();
                cbHocKy.Text = BUS_Config.HocKy.ToString();

            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(cbHocKy.Text == "" || cbNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            dtDS_CD_DK.DataSource = BUS_ChuyenDe.DanhSachChuyenDeDaDangKy(cbHocKy.Text, cbNamHoc.Text);
        }
    }
}
