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
    public partial class DKHP_GUI : Form
    {
        public DKHP_GUI()
        {
            InitializeComponent();
        }
        private string MaLop = "0";
        private string TrangThai = "";
        private int SoTinChi = 0;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void DKHP_GUI_Load(object sender, EventArgs e)
        {
            try { 
                if (BUS_HocPhan.KiemTraTrangThaiDKHocPhan())
                {
                    dtHpDaDK.DataSource = BUS_HocPhan.KetQuaDangKyHP();
                    dtHPDcDk.DataSource = BUS_HocPhan.DanhSachHocPhan();
                    tbTinChi_ToiDa.Text = BUS_Config.SoTinChiToiDa.ToString();
                    tbTinChi_DaDangKy.Text = BUS_HocPhan.SoTinChiDangKy().ToString();
                    tbTinChi_ConLai.Text = (BUS_Config.SoTinChiToiDa - BUS_HocPhan.SoTinChiDangKy()).ToString();
                    TrangThai = "";
                    MaLop = "0";
                    return;
                }
                else
                {
                    MessageBox.Show("Không trong thời gian đăng ký học phần");
                    dtHpDaDK.Visible = false;
                    dtHPDcDk.Visible = false;
                    panel1.Visible = false;
                    btnDangKy.Visible = false;
                    btnHuyDangKy.Visible = false;
                    button4.Visible = false;
                    button1.Visible = false;
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công");
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if(TrangThai != "Huy")
            {
                MessageBox.Show("Vui lòng chọn lớp muốn hủy!");
                return;
            }
            try
            {
                if (BUS_HocPhan.HuyDangKyHocPhan(MaLop))
                {
                    DKHP_GUI_Load(sender, e);
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(SoTinChi > Int32.Parse(tbTinChi_ConLai.Text))
            {
                MessageBox.Show("Số tín chỉ đăng ký vượt quá số tín chỉ tối đa");
                return;
            }
            if (TrangThai != "DK")
            {
                MessageBox.Show("Vui lòng chọn lớp muốn đăng ký!");
                return;
            }
            try
            {
                if (BUS_HocPhan.DangKyHocPhan(MaLop))
                {
                    DKHP_GUI_Load(sender, e);
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

        private void dtHpDaDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    MaLop = dtHpDaDK.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                    TrangThai = "Huy";
                }
            }
            catch
            {

            }
            
        }

        private void dtHPDcDk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    MaLop = dtHPDcDk.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                    TrangThai = "DK";
                    SoTinChi = Int32.Parse(dtHPDcDk.Rows[e.RowIndex].Cells["SOTINCHI"].Value.ToString());
                }
            }
            catch
            {

            }
            
        }


    }
}
