using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super.web.market.dal
{
    public class Address
    {
        private string _fullName;
        private string _address1;
        private string _address2;
        private City _city;
        private Province _province;
        private string _zipCode;
        private Country _country;
        private Location _location
        //constructor
        public Address()
        {
            this._fullName = "";
            this._address1 = "";
            this._address2 = "";
            this._city = new City();
            this._province = new Province();
            this._zipCode = "";
            this._country = new Country();
            this._location = new Location();
        }
        //Property fullname
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        //Property fullname
        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        //Property fullname
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        //Property fullname
        public City City
        {
            get { return _city; }
            set { _city = value; }
        }
        //Property fullname
        public Province Province
        {
            get { return _province; }
            set { _province = value; }
        }
        //Property fullname
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        //Property fullname
        public Country Country
        {
            get { return _country; }
            set { _country = value; }
        }
        //Property fullname
        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
