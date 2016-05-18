namespace super.web.market.dal
{
    public class Category
    {
        private int _id;
        private string _description;

        public Category()
        {
            _id = 0;
            _description = "";
        }

        //properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}