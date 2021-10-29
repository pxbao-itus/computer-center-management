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
    public partial class XemLichThi_GUI : Form
    {
        public XemLichThi_GUI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void XemLichThi_GUI_Load(object sender, EventArgs e)
        {
            cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
            cbHocKy.Text = BUS_Config.HocKy.ToString();
            cbNamHoc.Text = BUS_Config.NamHoc.ToString();
            dtLichThi.DataSource = BUS_LichThi.LichThi(cbHocKy.Text, cbNamHoc.Text);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(cbHocKy.Text == "" || cbNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            dtLichThi.DataSource = BUS_LichThi.LichThi(cbHocKy.Text, cbNamHoc.Text);
        }
    }
}
