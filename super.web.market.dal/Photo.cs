using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace super.web.market.dal
{
    [DataContract]
    public class Photo : Model
    {
        private int _itemId;
        private string _image;
        public Photo()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public override int Id
        {
            get; set;
        }
        [DataMember]
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        [DataMember]
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
