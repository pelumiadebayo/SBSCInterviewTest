using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sbsc.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
   
}