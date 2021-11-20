using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMamangement
{
    public class Address
    {
        private string street;
        private string zipcode;
        private string city;
        private Countries country;



        public Address(string street, string Zip, string City, Countries Country)
        {
            this.street = street;
            this.zipcode = Zip;
            this.City = City;
            this.country = Country;
        }
        public Address(string street, string Zip, string City) :

            this(street, Zip, City, Countries.Sverige)
        {

        }
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {

        }
        public Address(Address theother)
        {
            this.street = theother.street;
            this.zipcode = theother.zipcode;
            this.city = theother.City;

        }

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





    }
}
