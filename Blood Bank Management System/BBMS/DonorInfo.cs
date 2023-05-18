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
    public partial class DonorInfo : Form
    {
        public DonorInfo()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new SearchDonorForm().Show();
            this.Hide();
        }

        private void donorInfoView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OShowInfo oInfo = new OShowInfo();
            SqlDataAdapter sqlDataAdapter = oInfo.ShowDonorList();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            donorListView.DataSource = dataTable;
        }
    }
}
