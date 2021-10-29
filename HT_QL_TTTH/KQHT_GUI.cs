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
    public partial class KQHT_GUI : Form
    {
        public KQHT_GUI()
        {
            InitializeComponent();
        }

        private void KQHT_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                dtDS_KQ_HP.DataSource = BUS_HocTap.KetQuaHocTapHocPhan();
                cbNamHocHP.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHocHP.Text = BUS_Config.NamHoc.ToString();
                cbHocKyHP.Text = BUS_Config.HocKy.ToString();

                dtDS_KQ_CC.DataSource = BUS_HocTap.KetQuaHocTapChungChi();
                cbNamHocCC.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHocCC.Text = BUS_Config.NamHoc.ToString();
                cbHocKyCC.Text = BUS_Config.HocKy.ToString();
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void ckbViewAllHP_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbViewAllHP.Checked == true)
            {
                cbHocKyHP.Enabled = false;
                cbNamHocHP.Enabled = false;
                dtDS_KQ_HP.DataSource = BUS_HocTap.XemTatCaHocTapHocPhan();
            }
            else
            {
                cbHocKyHP.Enabled = true;
                cbNamHocHP.Enabled = true;
            }
        }

        private void btnXemHP_Click(object sender, EventArgs e)
        {
            if(cbHocKyHP.Text == "" || cbNamHocHP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            else
            {
                dtDS_KQ_HP.DataSource = BUS_HocTap.KetQuaHocTapHocPhan(cbHocKyHP.Text, cbNamHocHP.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void btnXemCC_Click(object sender, EventArgs e)
        {
            if (cbHocKyCC.Text == "" || cbNamHocCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            else
            {
                dtDS_KQ_CC.DataSource = BUS_HocTap.KetQuaHocTapChungChi(cbHocKyCC.Text, cbNamHocCC.Text);
            }
        }

        private void ckbViewAllCC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbViewAllCC.Checked == true)
            {
                cbHocKyCC.Enabled = false;
                cbNamHocCC.Enabled = false;
                dtDS_KQ_CC.DataSource = BUS_HocTap.XemTatCaHocTapChungChi();
            }
            else
            {
                cbHocKyCC.Enabled = true;
                cbNamHocCC.Enabled = true;
            }
        }

    }
}
