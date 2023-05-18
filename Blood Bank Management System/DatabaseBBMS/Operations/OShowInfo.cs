using DatabaseBBMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Operations
{
    public class OShowInfo
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TN1P0I6;Initial Catalog=DatabaseBBMS;Integrated Security=True");
        public SqlDataAdapter ShowDonorList()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name, State, Contact, Email, Age, Bmi, Blood_Group, Disease, Other_Disease from Donor_Table", connection);
            connection.Close();

            return sqlDataAdapter;
        }

        public string Check(string bloodGroup, string state)
        {
            connection.Open();
            SqlCommand searchCmd = new SqlCommand("Select count(*) from Donor_Table Where Blood_Group='" + bloodGroup + "' and State='" + state + "'", connection);
            int resultRow = Convert.ToInt32(searchCmd.ExecuteScalar());
            connection.Close();

            if (resultRow > 0)
            {
                return "Donor Found!";
            }
            else
            {
                return "Donor does not Exist!";
            }
        }

        public SqlDataAdapter ShowSearchedInfo(string bloodGroup, string state)
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Name, Contact, Email, Age, Bmi, Disease, Other_Disease From Donor_Table Where Blood_Group = '"+bloodGroup+ "' and State = '" +state+"'", connection);
            connection.Close();

            return sqlDataAdapter;
        }
        public SqlDataAdapter ShowDonorInfo(EDonor eDonor)
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Donor_Table Where Username = '" + eDonor.Username + "'", connection);
            connection.Close();

            return sqlDataAdapter;
        }
    }
}
