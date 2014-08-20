using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtahPlanners.Application.Domain.Identity
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}