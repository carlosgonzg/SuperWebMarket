using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super.web.market.dal
{
    public class City
    {
        private int _code;
        private string _description;
        private int _provinceId;
        //constructor
        public City()
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
        public int ProvinceId
        {
            get { return this._provinceId; }
            set { this._provinceId = value; }
        }

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }
    }
}
