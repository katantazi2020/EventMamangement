using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMamangement
{
     class Address
    {
        private string street;
        private string zipcode;
        private string city;
        private Countries country;


        #region CONSTRUCTORS
        /// <summary>
        /// Constructor with four parameters - used by other constructors too
        /// strings are initiated  to null by the compiler.
        /// That is why it is better to assign them as Empty so that nolonger null
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="City"></param>
        /// <param name="Country"></param>
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipcode = zip;
            this.city = city;
            this.country = country;
        }
        // Call the next constructor for Reuse
        public Address(string street, string zip, string city) :

            this(street, zip, city, Countries.Sverige)
        {

        }
        /// <summary>
        /// Dafault constructor calling another constructor in this class.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {

        }
        /// <summary>
        /// copy constructor, no need  to copy all members
        /// </summary>
        /// <param name="theother"></param>
        public Address(Address theother)
        {
            this.street = theother.street;
            this.zipcode = theother.zipcode;
            this.city = theother.city;
            this.country = theother.country;

        }
        #endregion 

        #region PROPERTIES
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }
        public string ZipCode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion
        #region OTHERMETHODS
        /// <summary>
        /// Do some checking of data.
        /// Address must have city and country as an enum
        /// and should always have a default value
        /// city is initiated to null  so it should get validates
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            bool cityok = !string.IsNullOrEmpty(City);
            return cityok;
        }
        public string GetAddressLabel()
        {
            string strout = street + Environment.NewLine;
            strout += zipcode + " " + city;
            return strout;
        }
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        public override string ToString()
        {
            string strout = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, zipcode, city, GetCountryString());
            return strout;
        }
        #endregion





    }
}
