using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace HT_QL_TTTH
{
    public partial class GUI_Admin_ThemLopMo : Form
    {
        public GUI_Admin_ThemLopMo()
        {
            InitializeComponent();
        }

        private void GUI_Admin_ThemLopMo_Load(object sender, EventArgs e)
        {
            dtpNgayBatDau.CustomFormat = "dd-MM-yyyy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbLoaiLop.Text == "" || cbMonHoc.Text == "" || tbSiSo.Text == "" || cbThu.Text == "" || cbTietBD.Text == "" || cbTietKT.Text == "" || dtpNgayBatDau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (BUS_LopMo.ThemLop(SetThongTin()))
            {
                MessageBox.Show("Thêm lớp thành công");
                textBox_Clear();
                return;
            }
            else
            {
                MessageBox.Show("Thêm lớp không thành công");
                return;
            }
        }

        private DTO_LopMo_TKB SetThongTin()
        {

            DTO_LopMo_TKB lop = new DTO_LopMo_TKB();
            lop.LoaiLopMo = cbLoaiLop.Text;
            lop.SLHVToiDa = Int32.Parse(tbSiSo.Text);
            lop.MaMH = BUS_LopMo.LayMaMonHocTuTen(cbMonHoc.Text);
            lop.HocKy = BUS_Config.HocKy;
            lop.NamHoc = BUS_Config.NamHoc;
            lop.NgayBatDau = dtpNgayBatDau.Text;

            lop.TietBatDau = Int32.Parse(cbTietBD.Text);
            lop.TietKetThuc = Int32.Parse(cbTietKT.Text);
            lop.Thu = Int32.Parse(cbThu.Text);
            return lop;
        }

        private void textBox_Clear()
        {
            cbLoaiLop.Text = "";
            cbMonHoc.Text = "";
            tbSiSo.Text = "";
            cbThu.Text = "";
            cbTietBD.Text = "";
            cbTietKT.Text = "";
            
        }

        private void cbLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonHoc.DataSource = BUS_LopMo.LayDanhSachTenMonHoc(cbLoaiLop.Text);
        }

        private void cbTietKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Int32.Parse(cbTietKT.Text) <= Int32.Parse(cbTietBD.Text))
            {
                lbThongBao.Visible = true;
            }
            else
            {
                lbThongBao.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
