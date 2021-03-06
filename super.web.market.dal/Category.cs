﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace super.web.market.dal
{
    [DataContract]
    public class Category : Model
    {
        private string _description;

        public Category()
        {
            _description = "";
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public override int Id
        {
            get; set;
        }
        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}