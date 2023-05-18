using DatabaseBBMS.Entities;
using DatabaseBBMS.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class DonorForm : Form
    {
        public DonorForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EDonor eDonor = new EDonor();
            ODonor oDonor = new ODonor();

            eDonor.Name = txtName.Text;
            eDonor.Username = txtUsername.Text;
            eDonor.State = comboBoxState.Text;
            eDonor.Contact = Convert.ToInt32(txtContact.Text);
            eDonor.Email = txtEmail.Text;
            eDonor.Password = txtPassword.Text;
            eDonor.Age = Convert.ToInt32(txtAge.Text);
            eDonor.Bmi = float.Parse(txtBMI.Text);
            eDonor.BloodGroup = comboBoxBloodGroup.Text;
            eDonor.Disease = comboBoxDisease.Text;
            eDonor.OtherDisease = txtOtherDisease.Text;

            if (oDonor.Submit(eDonor) > 0)
            {
                MessageBox.Show("Successfully Submitted!");
            }
            else
            {
                MessageBox.Show("Submit Failed!");
            }

            OShowInfo oInfo = new OShowInfo();
            SqlDataAdapter sqlDataAdapter = oInfo.ShowDonorInfo(eDonor);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            donorInfoView.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EDonor eDonor = new EDonor();
            ODonor oDonor = new ODonor();

            eDonor.Name = txtName.Text;
            eDonor.Username = txtUsername.Text;
            eDonor.State = comboBoxState.Text;
            eDonor.Contact = Convert.ToInt32(txtContact.Text);
            eDonor.Email = txtEmail.Text;
            eDonor.Password = txtPassword.Text;
            eDonor.Age = Convert.ToInt32(txtAge.Text);
            eDonor.Bmi = float.Parse(txtBMI.Text);
            eDonor.BloodGroup = comboBoxBloodGroup.Text;
            eDonor.Disease = comboBoxDisease.Text;
            eDonor.OtherDisease = txtOtherDisease.Text;

            if (oDonor.Update(eDonor) > 0)
            {
                MessageBox.Show("Successfully Updated!");
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }

            OShowInfo oInfo = new OShowInfo();
            SqlDataAdapter sqlDataAdapter = oInfo.ShowDonorInfo(eDonor);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            donorInfoView.DataSource = dataTable;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            EDonor eDonor = new EDonor();
            ODonor oDonor = new ODonor();

            eDonor.Username = txtUsername.Text;

            if (oDonor.Remove(eDonor) > 0)
            {
                MessageBox.Show("Successfully Removed!");
            }
            else
            {
                MessageBox.Show("Remove Failed!");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new UserIdentity().Show();
            this.Hide();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAge_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "No need to insert age. Age will be automatically calculated according to DOB.";
        }

        private void txtAge_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void DonorDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = DonorDOB.Value;
            DateTime presentTime = DateTime.Now;
            TimeSpan age = presentTime - dob;
            txtAge.Text = (age.TotalDays / 365).ToString("0");
        }
        private int NumPass(string password)
        {
            int num = 0;
            foreach(char check in password)
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

        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            int minLengthPass = 8;
            if (txtPassword.Text.Length >= minLengthPass && NumPass(txtPassword.Text) >= 1 && UpperPass(txtPassword.Text) >=1)
            {
                MessageBox.Show("Password Matched Requirement!");
            }
            else
            {
                MessageBox.Show("Password Did Not Match Requirement!");
            }
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Password Requirement: 1. Uppercase,  2. Number,  3. Minimum Length 8.";
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            int minLength = 11;
            if (txtContact.Text.Length < minLength)
            {
                lblContactMessage.Text = "There must be 11 digits  [e.g 01*********]";
            }
            else if (txtContact.Text.Length == minLength)
            {
                lblContactMessage.Text = "";
            }
            else
            {
                lblContactMessage.Text = "There must be 11 digits  [e.g 01*********]";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblRequirementMessage.Text = "Please check Requirements below \nby placing the cursor on this TextBox!";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
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
