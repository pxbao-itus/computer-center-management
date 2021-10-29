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
    public partial class Dashboard_GUI : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage sender;
        public static string maHV;
        public Dashboard_GUI()
        {
            InitializeComponent();
            customizeDesign();
        }



        

        public static Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customizeDesign()
        {
            pnlDKHP.Visible = false;
            pnlDKCD.Visible = false;
            pnlDKCC.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (pnlDKHP.Visible == true)
                pnlDKHP.Visible = false;
            if (pnlDKCD.Visible == true)
                pnlDKCD.Visible = false;
            if (pnlDKCC.Visible == true)
                pnlDKCC.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void resetColor()
        {
            btnDKHP_LM.BackColor = Color.FromArgb(55, 38, 166);
            btnDKHP_KQ.BackColor = Color.FromArgb(55, 38, 166);
            btnDKHP_DKTL.BackColor = Color.FromArgb(55, 38, 166);
            btnDKCD_KQ.BackColor = Color.FromArgb(55, 38, 166);
            btnDKCC_KQ.BackColor = Color.FromArgb(55, 38, 166);
            btnDKHP.BackColor = Color.FromArgb(2, 6, 89);
            btnDKCD.BackColor = Color.FromArgb(2, 6, 89);
            btnDKCC.BackColor = Color.FromArgb(2, 6, 89);
            btnKQHT.BackColor = Color.FromArgb(2, 6, 89);
            btnHocPhi.BackColor = Color.FromArgb(2, 6, 89);
            btnXemLichThi.BackColor = Color.FromArgb(2, 6, 89);
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            maHV = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        
        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserInformation_GUI());
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDKHP);
            resetColor();
            btnDKHP.BackColor = Color.FromArgb(1, 5, 38);
            openChildForm(new DKHP_GUI());
        }

        private void btnDKHP_KQ_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKHP_KQ.BackColor = Color.FromArgb(36, 5, 166);
            hideSubMenu();
            pnlDKHP.Visible = true;
            openChildForm(new DKHP_KQ_GUI());
        }

        private void btnDKHP_LM_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKHP_LM.BackColor = Color.FromArgb(36, 5, 166);
            hideSubMenu();
            pnlDKHP.Visible = true;
            openChildForm(new DKHP_LM_GUI());
        }

        private void btnDKHP_DKTL_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKHP_DKTL.BackColor = Color.FromArgb(36, 5, 166);
            hideSubMenu();
            pnlDKHP.Visible = true;
            //openChildForm(new DKHP_DKTL_GUI());
        }

        private void btnDKCD_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKCD.BackColor = Color.FromArgb(1, 5, 38);
            showSubMenu(pnlDKCD);
            openChildForm(new DKCD_GUI());
        }

        private void btnDKCD_KQ_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKCD_KQ.BackColor = Color.FromArgb(36, 5, 166);
            hideSubMenu();
            pnlDKCD.Visible = true;
            openChildForm(new DKCD_KQ_GUI());
        }

        private void btnDKCC_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKCC.BackColor = Color.FromArgb(1, 5, 38);
            hideSubMenu();
            pnlDKCC.Visible = true;
            openChildForm(new DKCC_GUI());
        }

        private void btnDKCC_KQ_Click(object sender, EventArgs e)
        {
            resetColor();
            btnDKCC_KQ.BackColor = Color.FromArgb(36, 5, 166);
            hideSubMenu();
            pnlDKCC.Visible = true;
            openChildForm(new DKCC_KQ_GUI());
        }

        private void btnXemLichThi_Click(object sender, EventArgs e)
        {
            resetColor();
            btnXemLichThi.BackColor = Color.FromArgb(1, 5, 38);
            hideSubMenu();
            openChildForm(new XemLichThi_GUI());
        }

        private void btnKQHT_Click(object sender, EventArgs e)
        {
            resetColor();
            btnKQHT.BackColor = Color.FromArgb(1, 5, 38);
            hideSubMenu();
            openChildForm(new KQHT_GUI());
        }

        private void btnHocPhi_Click(object sender, EventArgs e)
        {
            resetColor();
            btnHocPhi.BackColor = Color.FromArgb(1, 5, 38);
            hideSubMenu();
            openChildForm(new HocPhi_GUI());
        }

        private void Dashboard_GUI_Load(object sender, EventArgs e)
        {
            btnUser.Text = BUS_User.LayThongTinCaNhan().TenHV;
        }

        private void btnDSHP_Click(object sender, EventArgs e)
        {
            openChildForm(new DSHP_GUI());
        }
    }
}
