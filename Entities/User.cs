using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public abstract class User : IdentityUser<string>
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Picture { get; set; }
    }
}