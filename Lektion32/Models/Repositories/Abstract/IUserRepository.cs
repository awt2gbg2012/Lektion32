using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion32.Models.Entities;

namespace Lektion32.Models.Repositories.Abstract
{
    public interface IUserRepository
    {
        User FindUserByEmail(string email);
    }
}
