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
    public partial class SearchDonorForm : Form
    {
        public SearchDonorForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OShowInfo oInfo = new OShowInfo();
            string status = oInfo.Check(comboBoxBloodGroup.Text, comboBoxState.Text);

            if (status == "Donor Found!")
            {
                SqlDataAdapter sqlDataAdapter = oInfo.ShowSearchedInfo(comboBoxBloodGroup.Text, comboBoxState.Text);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                SearchInfoView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show(status);
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new UserIdentity().Show();
            this.Hide();
        }

        private void btnDonorList_Click(object sender, EventArgs e)
        {
            new DonorInfo().Show();
            this.Hide();
        }
    }
}
