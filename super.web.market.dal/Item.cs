using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace super.web.market.dal
{
    [DataContract]
    public class Item : Model
    {
        private string _name;
        private string _description;
        private float _amount;
        private List<Tax> _taxes;
        
        //constructor
        public Item()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public override int Id
        {
            get; set;
        }
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        [DataMember]
        public float Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        [DataMember]
        public float TaxAmount
        {
            get
            {
                var _taxAmount = (float)0;
                for(var i = 0; i < _taxes.Count; i++)
                {
                   _taxAmount += _amount * _taxes[i].Percentage;
                }
                return _taxAmount;
            }
        }
        [DataMember]
        public float TotalAmount
        {
            get { return _amount + TaxAmount; }
        }
        [DataMember]
        public virtual ICollection<Photo> Photos { get; set; }
        [DataMember]
        public virtual ICollection<ItemCategory> Categories { get; set; }
    }
}