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
    public partial class DKCC_GUI : Form
    {
        public DKCC_GUI()
        {
            InitializeComponent();
        }

        public static string MaLop = "";
        public static string TrangThai = "";
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void DKCC_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                if (BUS_ChungChi.KiemTraTrangThaiDKChungChi())
                {
                    dtDSCC_DaDK.DataSource = BUS_ChungChi.DanhSachMonChungChiDaDangKy();
                    dtDSCC_DcDK.DataSource = BUS_ChungChi.DanhSachMonChungChi();
                    tbSoMon_ToiDa.Text = BUS_Config.SoMonToiDa.ToString();
                    tbSoMon_DaDangKy.Text = BUS_ChungChi.SoMonChungChiDaDangKy().ToString();
                    tbSoMon_ConLai.Text = (BUS_Config.SoMonToiDa - BUS_ChungChi.SoMonChungChiDaDangKy()).ToString();
                    MaLop = "";
                    TrangThai = "";
                }
                else
                {
                    MessageBox.Show("Không trong thời gian đăng ký chứng chỉ");
                    dtDSCC_DaDK.Visible = false;
                    dtDSCC_DcDK.Visible = false;
                    panel1.Visible = false;
                    btnHuyDangKy.Visible = false;
                    btnDangKy.Visible = false;
                    button1.Visible = false;
                    button4.Visible = false;
                    return;
                }
                
            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (tbSoMon_DaDangKy.Text == tbSoMon_ToiDa.Text)
            {
                MessageBox.Show("Đã đăng ký tối đa số môn");
                return;
            }
            if (TrangThai != "DK")
            {
                MessageBox.Show("Vui lòng chọn chuyên đề muốn đăng ký!");
                return;
            }
            try
            {
                if (BUS_ChungChi.DangKyChungChi(MaLop))
                {
                    DKCC_GUI_Load(sender, e);
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
                if (BUS_ChungChi.HuyDangKyChungChi(MaLop))
                {
                    DKCC_GUI_Load(sender, e);
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

        private void dtDSCC_DcDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaLop = dtDSCC_DcDK.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                TrangThai = "DK";
            }
        }

        private void dtDSCC_DaDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaLop = dtDSCC_DaDK.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                TrangThai = "Huy";
            }
        }
    }
}
