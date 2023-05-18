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
    public partial class RecipientForm : Form
    {
        public RecipientForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ERecipient eRecipient = new ERecipient();
            ORecipient oRecipient = new ORecipient();

            eRecipient.Name = txtName.Text;
            eRecipient.Address = txtAddress.Text;
            eRecipient.Contact = Convert.ToInt32(txtContact.Text);

            if (oRecipient.Submit(eRecipient) > 0)
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
