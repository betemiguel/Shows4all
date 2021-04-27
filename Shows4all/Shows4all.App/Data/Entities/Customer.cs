using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Data.Entities
{
    public class Customer : User
    {

        protected Customer(int id, string firstname, string lastname, string email) : base(id, firstname, lastname, email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }
    }
}
