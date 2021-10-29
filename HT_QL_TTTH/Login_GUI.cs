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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            {
                if (BUS_Account.DangNhap(tbUsername.Text, tbPassword.Text))
                {
                    if(BUS_Account._role == "admin")
                    {
                        GUI_Admin_Dashboard adDashboard = new GUI_Admin_Dashboard();
                        adDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        Dashboard_GUI hvDashboard = new Dashboard_GUI();
                        hvDashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
            //catch
            //{
            //    MessageBox.Show("Đăng nhập không thành công, vui lòng thử lại.");
            //}
            
     
            
        }
    }
}
