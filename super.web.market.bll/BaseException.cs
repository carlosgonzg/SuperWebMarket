using System;

namespace super.web.market.bll
{
    public class BaseException : Exception
    {
        private int _code;
        private string _message;

        public BaseException(CodeStatus code, string message)
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
    }
}