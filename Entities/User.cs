using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public int Picture { get; set; }
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}