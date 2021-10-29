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
    public partial class DKCD_GUI : Form
    {
        public DKCD_GUI()
        {
            InitializeComponent();
        }
        public static string MaLop = "0";
        public static string TrangThai = "";

        private void DKCD_GUI_Load(object sender, EventArgs e)
        {
            if (BUS_ChuyenDe.KiemTraTrangThaiDKChuyenDe())
            {
                dtDSCD_DaDK.DataSource = BUS_ChuyenDe.DanhSachChuyenDeDaDangKy();
                dtDSCD_DcDK.DataSource = BUS_ChuyenDe.DanhSachChuyenDe();
                tbCDToiDa.Text = BUS_Config.SoChuyenDeToiDa.ToString();
                tbCDDaDK.Text = BUS_ChuyenDe.SoChuyenDeDaDangKy().ToString();
                tbCDConLai.Text = (BUS_Config.SoChuyenDeToiDa - BUS_ChuyenDe.SoChuyenDeDaDangKy()).ToString();
                MaLop = "0";
                TrangThai = "";
                return;
            }
            else
            {
                MessageBox.Show("Không trong thời gian đăng ký chuyên đề");
                dtDSCD_DaDK.Visible = false;
                dtDSCD_DcDK.Visible = false;
                panel1.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
                btnDangKy.Visible = false;
                btnHuyDangKy.Visible = false;
                return;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(tbCDDaDK.Text == tbCDToiDa.Text)
            {
                MessageBox.Show("Đã đăng ký tối đa số chuyên đề");
                return;
            }
            if (TrangThai != "DK")
            {
                MessageBox.Show("Vui lòng chọn chuyên đề muốn đăng ký!");
                return;
            }
            try
            {
                if (BUS_ChuyenDe.DangKyChuyenDe(MaLop))
                {
                    DKCD_GUI_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Đăng ký không thành công!");
            }

        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if (TrangThai != "Huy")
            {
                MessageBox.Show("Vui lòng chọn chuyên đề muốn hủy!");
                return;
            }
            try
            {
                if (BUS_ChuyenDe.HuyDangKyChuyenDe(MaLop))
                {
                    DKCD_GUI_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Hủy đăng ký không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Hủy đăng ký không thành công!");
            }
        }

        private void dtDSCD_DaDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                MaLop = dtDSCD_DaDK.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                TrangThai = "Huy";
            }
        }

        private void dtDSCD_DcDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaLop = dtDSCD_DcDK.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                TrangThai = "DK";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }
    }
}
