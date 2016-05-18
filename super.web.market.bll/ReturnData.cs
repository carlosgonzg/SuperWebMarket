using System;

namespace super.web.market.bll
{
    public class ReturnData
    {
        private int _code;
        private string _message;
        private Object _data;

        public ReturnData(CodeStatus code, string message)
        {
            this._code = (int)code;
            this._message = message;
        }

        //properties
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public Object Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}