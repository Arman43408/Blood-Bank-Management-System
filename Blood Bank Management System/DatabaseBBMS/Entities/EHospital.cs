using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Entities
{
    public class EHospital
    {
        private string name, username, address, email, password;
        private int contact;
        public string Name
        {
            set;
            get;
        }
        public string Username
        {
            set;
            get;
        }
        public string Address
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public string Password
        {
            set;
            get;
        }
        public int Contact
        {
            set;
            get;
        }
    }
}
