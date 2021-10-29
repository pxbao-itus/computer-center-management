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
    public partial class DKHP_LM_GUI : Form
    {
        public DKHP_LM_GUI()
        {
            InitializeComponent();
        }

        private void DKHP_LM_GUI_Load(object sender, EventArgs e)
        {
            cbHocKy.Text = BUS_Config.HocKy.ToString() ;
            try
            {
                cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbNamHoc.Text = BUS_Config.NamHoc.ToString();
                dtDS_LM.DataSource = BUS_HocPhan.DanhSachLopMo();
            }
            catch
            {

            }
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(cbHocKy.Text == "" || cbNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                dtDS_LM.DataSource = BUS_HocPhan.DanhSachLopMo(cbHocKy.Text, cbNamHoc.Text);
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
    }
}
