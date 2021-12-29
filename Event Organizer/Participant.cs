using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Organizer
{
    class Participant
    {
        private string firstName = string.Empty;
        private string lastName = "";
        private Address address;

        #region CONSTRUCTORS

        public Participant()
        {
            address = new Address();
        }

        public Participant(string firstName, string lastName, Address adr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (adr != null)
                address = adr;
            else
                address = new Address();
        }

        public Participant(Participant theOther)
        {
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.address = new Address(theOther.address);
        }

        #endregion


        #region PROPERTIES


        public Address Address
        {
            get { return address;  }
            set { address = value;  }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        #endregion

        #region METHODS

        public bool Validate()
        {
            bool addrOK = address.Validate();
            bool namesOk = (!string.IsNullOrEmpty(firstName) && (!string.IsNullOrEmpty(lastName)));
            return addrOK && namesOk;
        }

        public override string ToString()
        {
            string fullName = firstName + " "+ lastName;
            string strOut = string.Format("{0, -20} {1}", fullName, address.ToString());
            return strOut;
        }

        #endregion



    }
}
