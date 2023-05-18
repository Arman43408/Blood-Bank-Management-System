using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Entities
{
    public class EDonor
    {
        private string name, username, state, email, password, bloodGroup, disease, otherDisease;
        private int contact, age;
        private float bmi;
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
        public string State
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
        public string BloodGroup
        {
            set;
            get;
        }
        public string Disease
        {
            set;
            get;
        }
        public string OtherDisease
        {
            set;
            get;
        }
        public int Contact
        {
            set;
            get;
        }
        public int Age
        {
            set;
            get;
        }
        public float Bmi
        {
            set;
            get;
        }
    }
}
