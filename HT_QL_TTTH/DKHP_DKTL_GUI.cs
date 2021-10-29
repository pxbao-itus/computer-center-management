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
    public partial class DKHP_DKTL_GUI : Form
    {
        public DKHP_DKTL_GUI()
        {
            InitializeComponent();
        }

        public static string MaDKHocPhan = "";
        public static string TrangThai = "";
        public static string MaMH = "";
        public static string STT = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void DKHP_DKTL_GUI_Load(object sender, EventArgs e)
        {
            dtHPTLDcDK.DataSource = BUS_HocPhan.DanhSachHocPhanThiLai();
            dtHPTLDaDK.DataSource = BUS_HocPhan.KetQuaDangKyThiLai();
            TrangThai = "";
            MaDKHocPhan = "";
            MaMH = "";
            STT = "";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (TrangThai != "DK")
            {
                MessageBox.Show("Vui lòng chọn lớp muốn đăng ký!");
                return;
            }
            try
            {
                if (BUS_HocPhan.DangKyThiLai(MaMH))
                {
                    DKHP_DKTL_GUI_Load(sender, e);
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
                MessageBox.Show("Vui lòng chọn lớp muốn hủy!");
                return;
            }
            try
            {
                if (BUS_HocPhan.HuyDangKyThiLai(MaDKHocPhan, STT))
                {
                    DKHP_DKTL_GUI_Load(sender, e);
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

        private void dtHPTLDaDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaDKHocPhan = dtHPTLDaDK.Rows[e.RowIndex].Cells["MADKHOCPHAN"].Value.ToString();
                STT = dtHPTLDaDK.Rows[e.RowIndex].Cells["STT"].Value.ToString();
                TrangThai = "Huy";
            }
        }

        private void dtHPTLDcDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaMH = dtHPTLDcDK.Rows[e.RowIndex].Cells["MAMH"].Value.ToString();
                TrangThai = "DK";
            }
        }
    }
}
