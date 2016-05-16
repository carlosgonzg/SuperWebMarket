using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super.web.market.dal
{
    public class User
    {
        private string _username;
        private string _password;
        //constructor
        public User()
        {
            this._username = "";
            this._password = "";
        }
        //property Username
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        //property Password
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
    }
}
