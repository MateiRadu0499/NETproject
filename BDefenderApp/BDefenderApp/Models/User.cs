using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BDefenderApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Affiliation { get; set; } = "None";
        public bool IsDeleted { get; set; }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }

        public static implicit operator User(ActionResult<IEnumerable<User>> v)
        {
            throw new NotImplementedException();
        }

    }
}
