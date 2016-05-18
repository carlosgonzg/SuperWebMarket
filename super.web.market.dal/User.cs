using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace super.web.market.dal
{
    public class User : Model
    {
        private string _username;
        private string _password;

        //constructor
        public User()
        {
            //this.Id = ;
            this._username = "";
            this._password = "";
        }

        //property Username
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        [DataType(DataType.Password)]
        //property Password
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
    }
}