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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cleanData();
        }
        private void cleanData()
        {
            txtRegNo.Text = "";
            txtStudName.Text = "";
            txtPhoneNo.Text = "";
            dtPicDoB.Value =DateTime.Now();
            rbtnMale.Checked = true;
            rbtnFemale.Checked = false;
            txtEmail.Text = "";
            txtPostalAddress.Text = "";
            txtPic.Text = "";
            chckStatus.CheckState = 1;
            cboProgID.Text = "";
            txtRegNo.focus();
        }
    }
}
