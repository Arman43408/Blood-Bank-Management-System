using DatabaseBBMS.Entities;
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
    public partial class BloodBankForm : Form
    {
        public BloodBankForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EBloodBank eBloodBank = new EBloodBank();
            OBloodBank oBloodBank = new OBloodBank();

            eBloodBank.Name = txtName.Text;
            eBloodBank.Username = txtUsername.Text;
            eBloodBank.Address = txtAddress.Text;
            eBloodBank.Contact = Convert.ToInt32(txtContact.Text);
            eBloodBank.Email = txtEmail.Text;
            eBloodBank.Password = txtPassword.Text;

            if (oBloodBank.Submit(eBloodBank) > 0)
            {
                MessageBox.Show("Successfully Submitted!");
            }
            else
            {
                MessageBox.Show("Submit Failed!");
            }

            new SearchDonorForm().Show();
            this.Hide();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new UserIdentity().Show();
            this.Hide();
        }
        private int NumPass(string password)
        {
            int num = 0;
            foreach (char check in password)
            {
                if (char.IsDigit(check))
                {
                    num++;
                }
            }
            return num;
        }
        private int UpperPass(string password)
        {
            int num = 0;
            foreach (char check in password)
            {
                if (char.IsUpper(check))
                {
                    num++;
                }
            }
            return num;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblRequirementMessage.Text = "Please check Requirements below \nby placing the cursor on this TextBox!";
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Password Requirement: 1. Uppercase,  2. Number,  3. Minimum Length 8.";
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            int minLengthPass = 8;
            if (txtPassword.Text.Length >= minLengthPass && NumPass(txtPassword.Text) >= 1 && UpperPass(txtPassword.Text) >= 1)
            {
                MessageBox.Show("Password Matched Requirement!");
            }
            else
            {
                MessageBox.Show("Password Did Not Match Requirement!");
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            int minLength = 11;
            if (txtContact.Text.Length < minLength)
            {
                lblContactMessage.Text = "There must be 11 digits e.g 01*********";
            }
            else
            {
                lblContactMessage.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailMessage.Text = "e.g.  someone@gmail.com";
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                MessageBox.Show("Insert Number [e.g 01*********]");
            }
        }
    }
}
