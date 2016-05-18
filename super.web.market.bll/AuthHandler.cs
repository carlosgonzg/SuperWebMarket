using super.web.market.dal;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace super.web.market.bll
{
    public class AuthHandler : IDisposable
    {
        private DataContext _authContext;
        private DbSet<User> _userManager;

        public AuthHandler()
        {
            _authContext = new DataContext();
            _userManager = _authContext.Set<User>();
        }

        //RegisterUser
        public async Task<User> Create(dal.User userModel)
        {
            _userManager.Add(userModel);
            var userId = await _authContext.SaveChangesAsync();
            userModel.Id = userId;
            return userModel;
        }

        //Find User
        public async Task<User> Login(string username, string password)
        {
            return await (from b in _userManager where b.Username == username && b.Password == password select b).FirstAsync();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}