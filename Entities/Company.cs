using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string PrivateKey { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }

    }
}