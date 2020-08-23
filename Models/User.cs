using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Web;

namespace BlogApplication.Models
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string password { get; set; }

    }
}