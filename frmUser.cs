using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KUNIS
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cleanData();
        }
        private void cleanData()
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtPhoneNo.Text = "";
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cboPriviledges.Text = "";
            chckStatus.CheckState = 1;
            txtUserID.focus();
        }

        private void cboPriviledges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
