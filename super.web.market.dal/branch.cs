using System.Collections.Generic;

namespace super.web.market.dal
{
    public class Branch
    {
        private string _name;
        private Address _address;
        private List<Phone> _phones;

        //constructor
        public Branch(string name = "")
        {
            this._name = name;
            this._address = new Address();
            this._phones = new List<Phone>();
        }

        //property name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //property Address
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        //property Phones
        public List<Phone> Phones
        {
            get { return _phones; }
            set { _phones = value; }
        }
    }
}