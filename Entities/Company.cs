using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class Company : IdentityUser
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string PrivateKey { get; set; }
        public ICollection<ClientUser> ClientUsers { get; set; }
        public ICollection<WorkerUser> WorkerUsers { get; set; }
    }
}