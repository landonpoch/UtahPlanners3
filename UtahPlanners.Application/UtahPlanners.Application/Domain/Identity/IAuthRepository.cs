using Microsoft.AspNet.Identity;
using MongoDB.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtahPlanners.Application.Domain.Identity
{
    public interface IAuthRepository
    {
        // TODO: Get rid of the IdentityResult from the interface!
        Task<IdentityResult> RegisterUser(User user);

        // TODO: Get rid of the IdentityUser from the interface!
        Task<IdentityUser> FindUser(string username, string password);
    }
}
