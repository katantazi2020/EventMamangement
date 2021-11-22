using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMamangement
{
    class Participant
    {
        /// <summary>
        /// Fields 
        /// Instance variables 
        /// Initialize the string 
        /// </summary>
      
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        
        //Aggregation "has a " relationship
        private Address address;

        // create address object in the constructor
        #region CONSTRUCTORS
        public Participant()
        {
            address = new Address();
        }
        /// <summary>
        /// Constructor with three parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="addr"></param>
        public Participant(string firstName,string lastName, Address addr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
           if (addr != null)
                address = addr;
             else
            address = new Address();
        }
        /// <summary>
        /// copy constructor 
        /// it is useful if you want to create an object  of participant (Me) and initiate it
        /// information  from another existing participant (theother).if you to 
        /// create a participants2 and copy the first and last name and the address from
        /// participant 1 , you can write code as below:
        /// participant2 As participant = New participant(participant1)
        /// The object participant2 will be created as a copy of participant1.
        /// you can then change participant2 as you wish.
        /// </summary>
        /// <param name="theother"></param>
        public Participant(Participant theother)
        {
            this.firstName = theother.firstName;
            this.lastName = theother.lastName;
            this.address = new Address(theother.address);
        }
        #endregion
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
            bool namesOK = (!string.IsNullOrEmpty(firstName)) && (!string.IsNullOrEmpty(lastName));
            return addrok && namesOK; // true if both are tru
        }
        public override string ToString()
        {
            string strout = string.Format("{0, -20} {1}", firstName, lastName, address.ToString());
            return strout;
        }
        #endregion


    }
}
