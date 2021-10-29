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
    public partial class GUI_Admin_QLHocTap : Form
    {
        public GUI_Admin_QLHocTap()
        {
            InitializeComponent();
        }
        public static string loaiLop = "HP";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_Admin_QLHocTap_Load(object sender, EventArgs e)
        {
            cbNamHoc.Text = "";
            cbHocKy.Text = "";
            cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
            cbHocKy.Text = BUS_Config.HocKy.ToString();
            cbNamHoc.Text = BUS_Config.NamHoc.ToString();
            if(loaiLop == "HP")
            {
                dtQLHocTap.DataSource = BUS_HocTap.KetQuaHocTap(cbHocKy.Text, cbNamHoc.Text);
            }
            if (BUS_HocPhan.KiemTraTrangThaiDKHocPhan())
            {
                tbDiem.ReadOnly = true;
            }
        }

        private void dtQLHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtQLHocTap.Rows[e.RowIndex];
                tbTenHV.Text = row.Cells["TENHV"].Value.ToString();
                tbMaHV.Text = row.Cells["MAHV"].Value.ToString();
                tbDiem.Text = row.Cells["DIEM"].Value.ToString();
                tbMaLop.Text = row.Cells["MALOP"].Value.ToString();
                tbTenMH.Text = row.Cells["TENMH"].Value.ToString();
                tbTrangThai.Text = row.Cells["TRANGTHAI"].Value.ToString() == "0" ? "Đậu" : "Rớt";
                if(tbDiem.Text == "")
                {
                    tbTrangThai.Text = "Chưa có điểm";
                }
            }
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbHocKy.Text != BUS_Config.HocKy.ToString() || cbNamHoc.Text != BUS_Config.NamHoc.ToString())
            {
                tbDiem.ReadOnly = true;
                btnUpdate.Enabled = false;
                
            }
            else
            {
                tbDiem.ReadOnly = false;
                btnUpdate.Enabled = true;
                
            }
            if (cbHocKy.Text != "" && cbNamHoc.Text != "")
            {
                dtQLHocTap_Reload();
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHocKy.Text != BUS_Config.HocKy.ToString() || cbNamHoc.Text != BUS_Config.NamHoc.ToString())
            {
                tbDiem.ReadOnly = true;
                btnUpdate.Enabled = false;
            }
            else
            {
                tbDiem.ReadOnly = false;
                btnUpdate.Enabled = true;
            }
            if(cbHocKy.Text !=  "" && cbNamHoc.Text != "")
            {
                dtQLHocTap_Reload();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(tbTrangThai.Text == "Chưa có điểm")
            {
                MessageBox.Show("Vui lòng nhập đúng điểm số");
                return;
            }
            else
            {
                string trangthai = "0";
                if(tbTrangThai.Text == "Đậu")
                {
                    trangthai = "0";
                }
                if(tbTrangThai.Text == "Rớt")
                {
                    trangthai = "1";
                }
                if(BUS_HocTap.CapNhatDiem(tbMaHV.Text, tbMaLop.Text, tbDiem.Text, trangthai))
                {
                    MessageBox.Show("Cập nhật điểm thành công");
                    dtQLHocTap.DataSource = BUS_HocTap.KetQuaHocTap(cbHocKy.Text, cbNamHoc.Text);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }

        }

        private void tbDiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (float.Parse(tbDiem.Text) >= 5 && float.Parse(tbDiem.Text)  <= 10)
                {
                    tbTrangThai.Text = "Đậu";
                }
                else
                {
                    try
                    {
                        if (float.Parse(tbDiem.Text) < 5 && float.Parse(tbDiem.Text) >= 0)
                        {
                            tbTrangThai.Text = "Rớt";
                        }
                    }
                    catch
                    {
 
                        tbTrangThai.Text = "Chưa có điểm";
                        return;
                        
                    }
                }
            }
            catch
            {
                tbTrangThai.Text = "Chưa có điểm";
                return;

            }

        }

        private void btnLoaiLop_Click(object sender, EventArgs e)
        {
            if(loaiLop == "HP")
            {
                loaiLop = "CC";
                btnLoaiLop.Text = "Học phần";
            }
            else
            {
                loaiLop = "HP";
                btnLoaiLop.Text = "Chứng chỉ";
            }
            dtQLHocTap_Reload();
        }

        private void dtQLHocTap_Reload()
        {
            if(loaiLop == "HP")
            {
                dtQLHocTap.DataSource = BUS_HocTap.KetQuaHocTap(cbHocKy.Text, cbNamHoc.Text);
                if (BUS_HocPhan.KiemTraTrangThaiDKHocPhan())
                {
                    tbDiem.ReadOnly = true;
                }
                else
                {
                    tbDiem.ReadOnly = false;
                }
            }
            else
            {
                dtQLHocTap.DataSource = BUS_HocTap.KetQuaHocTapChungChiAdmin(cbHocKy.Text, cbNamHoc.Text);
                if (BUS_ChungChi.KiemTraTrangThaiDKChungChi())
                {
                    tbDiem.ReadOnly = true;
                }
                else
                {
                    tbDiem.ReadOnly = false;
                }
            }
            textBox_Clear();
            
            
        }

        private void textBox_Clear()
        {
            tbTenHV.Text = "";
            tbMaHV.Text = "";
            tbMaLop.Text = "";
            tbTenMH.Text = "";
            tbTrangThai.Text = "";
            tbDiem.Text = "";
        }
    }
}
