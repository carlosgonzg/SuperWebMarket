namespace super.web.market.dal
{
    public class Model
    {
        protected int _id;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual void Validate()
        {
        }
    }
}