using DatabaseBBMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Operations
{
    public class ODonor
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TN1P0I6;Initial Catalog=DatabaseBBMS;Integrated Security=True");
        public int Submit(EDonor eDonor)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Donor_Table(Name, Username, State, Contact, Email, Password, Age, BMI, Blood_Group, Disease, Other_Disease) values('"+eDonor.Name+"', '"+eDonor.Username+"', '"+eDonor.State+"', "+eDonor.Contact+", '"+eDonor.Email+"', '"+eDonor.Password+"', "+eDonor.Age+", "+eDonor.Bmi+", '"+eDonor.BloodGroup+"', '"+eDonor.Disease+"', '"+eDonor.OtherDisease+"')", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();

            return check;
        }

        public int Update(EDonor eDonor)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update Donor_Table Set Name='"+eDonor.Name+"', State='"+eDonor.State+"', Contact="+eDonor.Contact+", Email='"+eDonor.Email+"', Password='"+eDonor.Password+"', Age="+eDonor.Age+", BMI="+eDonor.Bmi+", Blood_Group='"+eDonor.BloodGroup+"', Disease='"+eDonor.Disease+"', Other_Disease='"+eDonor.OtherDisease+"' Where Username='"+eDonor.Username+"'", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();

            return check;
        }
        public int Remove(EDonor eDonor)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from Donor_Table Where Username='"+eDonor.Username+"'", connection);
            int check = cmd.ExecuteNonQuery();
            connection.Close();

            return check;
        }
    }
}
