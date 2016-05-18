namespace super.web.market.dal
{
    public class PhoneType
    {
        private int _code;
        private string _description;

        //constructor
        public PhoneType(int code = 0, string description = "")
        {
            this._code = code;
            this._description = description;
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
    }
}