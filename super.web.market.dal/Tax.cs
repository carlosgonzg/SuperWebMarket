using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace super.web.market.dal
{
    [DataContract]
    public class Tax : Model
    {
        private float _percentage;
        private string _description;
        public Tax()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public override int Id
        {
            get; set;
        }
        [DataMember]
        public float Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }
        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
