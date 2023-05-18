using DatabaseBBMS.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserIdentity().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OCheckUser oCheck = new OCheckUser();

            string checkedButton="";
            if (rBtnDonor.Checked) { checkedButton = "Donor_Table"; }
            if (rBtnHospital.Checked){ checkedButton = "Hospital_Table"; }
            if (rBtnBloodBank.Checked) { checkedButton = "BloodBank_Table"; }

            string status = oCheck.Check(checkedButton, txtUsername.Text, txtPassword.Text);

            if (status == "Logged In Successfully!")
            {
                MessageBox.Show(status);
                new SearchDonorForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(status);
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            lblShowPass.Text = txtPassword.Text;
        }

        private void rBtnDonor_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDonor.Checked) { lblSelectOne.Visible = false; }
        }

        private void rBtnHospital_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHospital.Checked) { lblSelectOne.Visible = false; }
        }

        private void rBtnBloodBank_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBloodBank.Checked) { lblSelectOne.Visible = false; }
        }
    }
}
