using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion32.Models.Entities;
using Lektion32.Models.Repositories.Abstract;

namespace Lektion32.Models.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public User FindUserByEmail(string Email)
        {
            return FindAll(u => u.Email == Email).FirstOrDefault();
        }
    }
}