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
    public partial class UserInformation_GUI : Form
    {
        public UserInformation_GUI()
        {
            InitializeComponent();
        }

        private void btnUser_ChangePassword_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard_GUI.activeForm = null;
        }

        private void UserInformation_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                DTO_User user = BUS_User.LayThongTinCaNhan();
                tbUser_Name.Text = user.TenHV;
                tbUser_ID.Text = user.MaHV.ToString();
                tbUser_Email.Text = user.Email;
                tbUser_Bachelor.Text = user.NgayBatDau.Substring(0, user.NgayBatDau.IndexOf(" "));
                tbUser_DateOfBirth.Text = user.NgaySinh.Substring(0, user.NgaySinh.IndexOf(" "));
                tbUser_PhoneNumber.Text = user.PhoneNumber;
                lbVerifyNewPassword.Visible = false;
            }
            catch
            {
                MessageBox.Show("Lấy dữ liệu không thành công");
            }
            
        }

        private void btnActChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int result = BUS_Account.DoiMatKhau(tbOldPassword.Text, tbNewPassword.Text);
                if (result == 1)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                    return;
                }
                if(result == 2)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    tbOldPassword.Text = "";
                    tbNewPassword.Text = "";
                    tbVerifyNewPassword.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu không thành công vui lòng thử lại sau!");
            }
        }

        private void tbVerifyNewPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbVerifyNewPassword.Text != tbNewPassword.Text)
            {
                lbVerifyNewPassword.Visible = true;
                btnActChangePassword.Enabled = false;
            }
            else
            {
                lbVerifyNewPassword.Visible = false;
                btnActChangePassword.Enabled = true;
                
            }
        }

        private void btnUser_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if(BUS_User.CapNhatThongTinCaNhan(new DTO_User(Int32.Parse(tbUser_ID.Text), tbUser_Name.Text, tbUser_Email.Text, tbUser_Bachelor.Text, tbUser_DateOfBirth.Text, tbUser_PhoneNumber.Text))){
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin không thành công!");
                return;
            }
        }
    }
}
