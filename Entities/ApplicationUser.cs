using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Picture { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public UserType UserType { get; set; }
    }
}

namespace CarService.Dal.Entities
{
    public enum UserType
    {
        CLIENT, WORKER
    }
}