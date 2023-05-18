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
    public partial class UserIdentity : Form
    {
        public UserIdentity()
        {
            InitializeComponent();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            new DonorForm().Show();
            this.Hide();
        }

        private void btnRecipient_Click(object sender, EventArgs e)
        {
            new RecipientForm().Show();
            this.Hide();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            new HospitalForm().Show();
            this.Hide();
        }

        private void btnBloodBank_Click(object sender, EventArgs e)
        {
            new BloodBankForm().Show();
            this.Hide();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
