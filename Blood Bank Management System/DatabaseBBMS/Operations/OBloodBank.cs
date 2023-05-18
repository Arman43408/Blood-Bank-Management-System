using DatabaseBBMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Operations
{
    public class OBloodBank
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TN1P0I6;Initial Catalog=DatabaseBBMS;Integrated Security=True");
        public int Submit(EBloodBank eBloodBank)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into BloodBank_Table(BB_Name, Username, Address, Contact, Email, Password) values('" + eBloodBank.Name + "', '" + eBloodBank.Username + "', '" + eBloodBank.Address + "', " + eBloodBank.Contact + ", '" + eBloodBank.Email + "', '" + eBloodBank.Password + "')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();

            return check;
        }
    }
}
