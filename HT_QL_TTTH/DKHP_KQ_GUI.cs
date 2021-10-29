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
    public partial class DKHP_KQ_GUI : Form
    {
        public DKHP_KQ_GUI()
        {
            InitializeComponent();
        }

        private void DKHP_KQ_GUI_Load(object sender, EventArgs e)
        {
            try
            {

                dtKQ_DKHP.DataSource = BUS_HocPhan.KetQuaDangKyHP();
                cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
                cbHocKy.Text = BUS_Config.HocKy.ToString();
                cbNamHoc.Text = BUS_Config.NamHoc.ToString();
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbNamHoc.Text == "" || cbHocKy.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            try
            {               
                dtKQ_DKHP.DataSource = BUS_HocPhan.KetQuaDangKyHP(cbHocKy.Text, cbNamHoc.Text);
            }catch
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
