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
using DTO;
namespace HT_QL_TTTH
{
    public partial class GUI_Admin_QLLopMo : Form
    {
        public int MaLop;
        public int TinhTrang;
        public GUI_Admin_QLLopMo()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string loaiLop = "Hoc Phan";

        private void GUI_Admin_QLLopMo_Load(object sender, EventArgs e)
        {
            cbHocKy.Text = "";
            cbNamHoc.Text = "";
            cbNamHoc.DataSource = BUS_HocPhan.LayDanhSachNamHoc();
            cbNamHoc.Text = BUS_Config.NamHoc.ToString();
            cbHocKy.Text = BUS_Config.HocKy.ToString();
            dtDanhSachLop.DataSource = BUS_LopMo.DanhSachLopMo(cbHocKy.Text, cbNamHoc.Text, loaiLop);
        }

        private void dtDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < BUS_LopMo.DanhSachLopMo(cbHocKy.Text, cbNamHoc.Text, loaiLop).Rows.Count)
            {
                if (cbNamHoc.Text != BUS_Config.NamHoc.ToString() || cbHocKy.Text != BUS_Config.HocKy.ToString())
                {
                    btnHuy.Enabled = false;
                }
                else
                {
                    btnHuy.Enabled = true;
                }
                
                MaLop = Int32.Parse(dtDanhSachLop.Rows[e.RowIndex].Cells["MALOP"].Value.ToString());
                TinhTrang = Int32.Parse(dtDanhSachLop.Rows[e.RowIndex].Cells["TRANGTHAILOP"].Value.ToString());
                if(TinhTrang == 0)
                {
                    rbtnBinhThuong.Checked = true;
                    btnHuy.Text = "Hủy lớp";
                }
                else
                {
                    rbtnDaHuy.Checked = true;
                    btnHuy.Text = "Mở lại lớp";
                }
            }
        }

        private void dtDanhSachLopMo_Reload()
        {
            dtDanhSachLop.DataSource = BUS_LopMo.DanhSachLopMo(cbHocKy.Text, cbNamHoc.Text, loaiLop);
            rbtnBinhThuong.Checked = false;
            rbtnDaHuy.Checked = false;
            btnHuy.Enabled = false;
            MaLop = -1;
            TinhTrang = 0;
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            loaiLop = "Hoc Phan";
            dtDanhSachLopMo_Reload();
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            loaiLop = "Chuyen De";
            dtDanhSachLopMo_Reload();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            loaiLop = "Chung Chi";
            dtDanhSachLopMo_Reload();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbNamHoc.Text != BUS_Config.NamHoc.ToString() || cbHocKy.Text != BUS_Config.HocKy.ToString())
            {
                btnHuy.Enabled = false;
            }
            else
            {
                btnHuy.Enabled = true;
            }
            if (cbHocKy.Text != "" && cbNamHoc.Text != "")
            {
                dtDanhSachLopMo_Reload();
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbNamHoc.Text != BUS_Config.NamHoc.ToString() || cbHocKy.Text != BUS_Config.HocKy.ToString())
            {
                btnHuy.Enabled = false;
            }
            else
            {
                btnHuy.Enabled = true;
            }
            if (cbHocKy.Text != "" && cbNamHoc.Text != "")
            {
                dtDanhSachLopMo_Reload();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MaLop == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp muốn hủy");
                return;
            }
            if(TinhTrang == 0)
            {
                TinhTrang = 1;
            }
            else
            {
                TinhTrang = 0;
            }
            if(BUS_LopMo.MoHuyLop(MaLop, TinhTrang))
            {
                if(TinhTrang == 0)
                {
                    MessageBox.Show("Mở lại lớp thành công");
                }
                else
                {
                    MessageBox.Show("Hủy lớp thành công");
                }
                dtDanhSachLopMo_Reload();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUI_Admin_ThemLopMo them = new GUI_Admin_ThemLopMo();
            them.Show();
        }
    }
}
