using Microsoft.AspNet.Identity;
using MongoDB.AspNet.Identity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UtahPlanners.Application.Domain.Identity;


namespace UtahPlanners.Application.Infrastructure
{
    public class AuthRepository : IAuthRepository
    {
        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            var db = new MongoClient()
                .GetServer()
                .GetDatabase("AuthTest");
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(db));
        }

        public async Task<IdentityResult> RegisterUser(User user)
        {
            return await _userManager.CreateAsync(new IdentityUser { UserName = user.Username }, user.Password);
        }

        public async Task<IdentityUser> FindUser(string username, string password)
        {
            return await _userManager.FindAsync(username, password);
        }
    }
}