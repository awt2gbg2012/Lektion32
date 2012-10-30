using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion32.Models.Entities.Abstract;
using Lektion32.Models.Repositories;

namespace Lektion32.Models.Entities
{
    public class User : IEntity
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}