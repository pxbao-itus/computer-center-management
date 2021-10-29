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
    public partial class DSHP_GUI : Form
    {
        public DSHP_GUI()
        {
            InitializeComponent();
        }

        private void DSHP_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                cbTenHP.Text = "Tat Ca";
                dtDSHP.DataSource = BUS_HocPhan.DanhSachHocPhanTongQuan();
                for (int i = 0; i < BUS_HocPhan.LayDanhSachTenHP().Count; i++)
                {
                    cbTenHP.Items.Add(BUS_HocPhan.LayDanhSachTenHP()[i]);
                }
                cbTenHP.Items.Add("Tat Ca");
                tbDTBTotNghiep.Text = BUS_HocPhan.TinhDTBXetTotNghiep();
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {

                dtDSHP.DataSource = BUS_HocPhan.DanhSachHocPhanChiTiet(cbTenHP.Text);
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void btnXemTongQuan_Click(object sender, EventArgs e)
        {
            try
            {
                dtDSHP.DataSource = BUS_HocPhan.DanhSachHocPhanTongQuan();
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void tbnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
