using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBBMS.Entities
{
    public class ERecipient
    {
        private string name, address;
        private int contact;
        public string Name
        {
            set;
            get;
        }
        public string Address
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
