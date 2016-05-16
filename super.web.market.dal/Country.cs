using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super.web.market.dal
{
    public class Country
    {
        private int _code;
        private string _description;
        //constructor
        public Country()
        {
            this._code = 0;
            this._description = "";
        }
        //property Code
        public int Code
        {
            get { return this._code; }
            set { this._code = value; }
        }
        //property Description
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        //property Provinces
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
