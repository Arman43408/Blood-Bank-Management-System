using DatabaseBBMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Operations
{
    public class OHospital
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TN1P0I6;Initial Catalog=DatabaseBBMS;Integrated Security=True");
        public int Submit(EHospital eHospital)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Hospital_Table(Hosp_Name, Username, Address, Contact, Email, Password) values('"+eHospital.Name+"', '"+eHospital.Username+"', '"+eHospital.Address+"', "+eHospital.Contact+", '"+eHospital.Email+"', '"+eHospital.Password+"')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();

            return check;
        }
    }
}
