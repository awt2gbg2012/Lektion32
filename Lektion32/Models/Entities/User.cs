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

        public void NotifyByEmail(string Subject, string Message)
        {
            // Not implemented: This method should send an email to the user with subject and message
        }

        public void Save()
        {
            var repo = new Repository<User>();
            repo.Save(this);
        }

        public void Update()
        {
            var repo = new Repository<User>();
            repo.Save(this);
        }

        public void Delete()
        {
            var repo = new Repository<User>();
            repo.Delete(this);
        }
    }
}