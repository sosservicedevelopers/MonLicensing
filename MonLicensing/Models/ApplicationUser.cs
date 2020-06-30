using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonLicensing.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string CompanyName { get; set; }
        public string INN { get; set; }
        public string Address { get; set; }
    }
}
