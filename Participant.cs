using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMamangement
{
    class Participant
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        private Address address;

        public Participant()
        {
            address = new Address();
        }
        public Participant(string firstName,string lastName, Address addr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (addr != null)
                address = addr;
            address = new Address();
        }
        public Participant(Participant theother)
        {
            this.firstName = theother.firstName;
            this.lastName = theother.lastName;
            this.address = new Address(theother.address);
        }
        #region PROPERTIES
        public Address Address
        {
            get { return address; }
            set { address = value; }
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


        #region OTHER METHODS
        public bool Validate()
        {
            bool addrok = address.validate();
            bool namesOK = (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName));
            return addrok && namesOK;
        }
        public override string ToString()
        {
            string strout = string.Format("{0, -20} {1}", firstName, lastName, address.ToString());
            return strout;
        }
        #endregion


    }
}
