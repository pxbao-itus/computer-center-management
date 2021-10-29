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
using System.Data;
namespace HT_QL_TTTH
{
    public partial class GUI_Admin_QLQuyDinh : Form
    {
        public GUI_Admin_QLQuyDinh()
        {
            InitializeComponent();
        }
        public static bool status = true;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_Admin_Dashboard.adminForm = null;
        }
        
        private void GUI_Admin_QLQuyDinh_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = BUS_Config.LayThongTinQuyDinh();
                tbtinchi.Text = dt.Rows[0]["SOTINCHITOIDA"].ToString();
                tbchuyende.Text = dt.Rows[0]["SOCHUYENDETOIDA"].ToString();
                tbmon.Text = dt.Rows[0]["SOMONTOIDA"].ToString();
                tbsotien.Text = dt.Rows[0]["SOTIENTRENTINCHI"].ToString();
            }
            catch
            {
                status = false;
            }
            
            if (BUS_HocPhan.KiemTraTrangThaiDKHocPhan())
            {
                btnDKHP.Text = "Tắt đăng ký học phần";
            }
            if (BUS_ChuyenDe.KiemTraTrangThaiDKChuyenDe())
            {
                btnDKCD.Text = "Tắt đăng ký chuyên đề";
            }
            if (BUS_ChungChi.KiemTraTrangThaiDKChungChi())
            {
                btnDKCC.Text = "Tắt đăng ký chứng chỉ";
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if(tbchuyende.Text == "" || tbmon.Text == "" || tbtinchi.Text == "" || tbsotien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(status == false)
            {
                if(BUS_Config.ThemQuyDinh(tbtinchi.Text, tbchuyende.Text, tbmon.Text, tbsotien.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                    return;
                }
            }
            else
            {
                if (BUS_Config.CapQuyDinh(tbtinchi.Text, tbchuyende.Text, tbmon.Text, tbsotien.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                    return;
                }
            }
            
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            int trangThai = 0;
            if(btnDKHP.Text == "Tắt đăng ký học phần")
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }
            if(BUS_Config.DongMoDangKy("Hoc Phan", trangThai))
            {
                if(trangThai == 1)
                {
                    MessageBox.Show("Tắt đăng ký học phần thành công");
                    btnDKHP.Text = "Bật đăng ký học phần";
                    return;
                }
                else
                {
                    MessageBox.Show("Bật đăng ký học phần thành công");
                    btnDKHP.Text = "Tắt đăng ký học phần";
                    return;
                }

            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnDKCD_Click(object sender, EventArgs e)
        {
            int trangThai = 0;
            if (btnDKCD.Text == "Tắt đăng ký chuyên đề")
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }
            if (BUS_Config.DongMoDangKy("Chuyen De", trangThai))
            {
                if (trangThai == 1)
                {
                    MessageBox.Show("Tắt đăng ký chuyên đề thành công");
                    btnDKCD.Text = "Bật đăng ký chuyên đề";
                    return;
                }
                else
                {
                    MessageBox.Show("Bật đăng ký chuyên đề thành công");
                    btnDKCD.Text = "Tắt đăng ký chuyên đề";
                    return;
                }

            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnDKCC_Click(object sender, EventArgs e)
        {
            int trangThai = 0;
            if (btnDKCC.Text == "Tắt đăng ký chứng chỉ")
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }
            if (BUS_Config.DongMoDangKy("Chung Chi", trangThai))
            {
                if (trangThai == 1)
                {
                    MessageBox.Show("Tắt đăng ký chứng chỉ thành công");
                    btnDKCC.Text = "Bật đăng ký chứng chỉ";
                    return;
                }
                else
                {
                    MessageBox.Show("Bật đăng ký chứng chỉ thành công");
                    btnDKCC.Text = "Tắt đăng ký chứng chỉ";
                    return;
                }

            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }
    }
}
