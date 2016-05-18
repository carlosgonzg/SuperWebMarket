using super.web.market.dal;

namespace super.web.market.bll
{
    public class UserHandler : BaseHandler<User>
    {
        //Private Variables
        private User _user;

        //Constructor
        public UserHandler()
        {
            this._user = new User();
        }
    }
}