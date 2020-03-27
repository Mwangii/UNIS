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
    public partial class frmSchool : Form
    {
        public frmSchool()
        {
            InitializeComponent();
        }

       

       
        private void cleanData()
        {
            txtSchoolID.Text = "";
            txtSchoolName.Text = "";
            txtRoom.Text = "";
            txtDescription.Text = "";
            txtSchoolID.Focus();
        }

        private void frmSchool_Load(object sender, EventArgs e)
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

        

       
    }
}
