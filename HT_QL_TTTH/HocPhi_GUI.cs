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
    public partial class HocPhi_GUI : Form
    {
        public HocPhi_GUI()
        {
            InitializeComponent();
        }

        private void HocPhi_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                cbHocKy.Text = BUS_Config.HocKy.ToString();
                cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHoc.Text = BUS_Config.NamHoc.ToString();
                dtHocPhi.DataSource = BUS_HocPhi.HocPhi(cbHocKy.Text, cbNamHoc.Text);
                tbSum.Text = BUS_HocPhi.TinhHocPhi(cbHocKy.Text, cbNamHoc.Text).ToString() + " đồng";

                cbHocKyCC.Text = BUS_Config.HocKy.ToString();
                cbNamHocCC.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHocCC.Text = BUS_Config.NamHoc.ToString();
                dtHocPhiCC.DataSource = BUS_HocPhi.HocPhiChungChi(cbHocKyCC.Text, cbNamHocCC.Text);
                tbTongTienCC.Text = BUS_HocPhi.TinhHocPhiChungChi(cbHocKyCC.Text, cbNamHocCC.Text).ToString() + " đồng";
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if( cbHocKy.Text == "" || cbHocKy.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            else
            {
                dtHocPhi.DataSource = BUS_HocPhi.HocPhi(cbHocKy.Text, cbNamHoc.Text);
                tbSum.Text = BUS_HocPhi.TinhHocPhi(cbHocKy.Text, cbNamHoc.Text).ToString() + " đồng";
            }
        }

        private void btnXemCC_Click(object sender, EventArgs e)
        {
            if (cbHocKyCC.Text == "" || cbHocKyCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            else
            {
                dtHocPhiCC.DataSource = BUS_HocPhi.HocPhiChungChi(cbHocKyCC.Text, cbNamHocCC.Text);
                tbSum.Text = BUS_HocPhi.TinhHocPhiChungChi(cbHocKyCC.Text, cbNamHocCC.Text).ToString() + " đồng";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

    }
}
