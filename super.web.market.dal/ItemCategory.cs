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
    public class ItemCategory : Model
    {
        private int _categoryId;
        private int _itemId;
        public ItemCategory()
        {
            
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public override int Id
        {
            get; set;
        }
        [DataMember]
        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
        [DataMember]
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
