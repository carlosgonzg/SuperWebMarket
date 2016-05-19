using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace super.web.market.dal
{
    [DataContract]
    public class ItemTax : Model
    {
        private int _taxId;
        private int _itemId;
        public ItemTax()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public override int Id
        {
            get; set;
        }
        [DataMember]
        public int TaxId
        {
            get { return _taxId; }
            set { _taxId = value; }
        }
        [DataMember]
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        [ForeignKey("TaxId")]
        public virtual Tax Tax { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
