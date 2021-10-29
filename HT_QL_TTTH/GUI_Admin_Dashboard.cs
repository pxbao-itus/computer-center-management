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
    public partial class GUI_Admin_Dashboard : Form
    {
        public GUI_Admin_Dashboard()
        {
            InitializeComponent();
        }

        public static Form adminForm = null;
        public void openChildForm(Form childForm)
        {
            if (adminForm != null)
                adminForm.Close();
            adminForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlAdminChild.Controls.Add(childForm);
            pnlAdminChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLHV_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Admin_DSHocVien());
        }

        private void btnQLHT_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Admin_QLHocTap());
        }

        private void btnQLLM_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Admin_QLLopMo());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void GUI_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            btnAdmin.Text = BUS_Account._username;
        }

        private void btnQLQD_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Admin_QLQuyDinh());
        }
    }
}
