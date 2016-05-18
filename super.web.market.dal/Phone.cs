using System.ComponentModel.DataAnnotations.Schema;

namespace super.web.market.dal
{
    public class Phone
    {
        private int _type;
        private string _number;

        //constructor
        public Phone()
        {
            this._type = 0;
            this._number = "";
        }

        //Property Type
        public int Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        //Property Number
        public string Number
        {
            get { return this._number; }
            set { this._number = value; }
        }

        [ForeignKey("Type")]
        public virtual PhoneType phoneType { get; set; }
    }
}