using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super.web.market.dal
{
    public class Province
    {
        private int _code;
        private string _description;
        private int _countryId;
        //constructor
        public Province()
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
        //property Country
        public int CountryId {
            get { return this._countryId; }
            set { this._countryId = value; }
        }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        //property Cities
        public virtual ICollection<City> Cities { get; set; }
    }
}
