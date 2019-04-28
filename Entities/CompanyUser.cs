using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class CompanyUser : User
    {
        public string PrivateKey { get; set; }
        //public bool Approved { get; set; }
        public ICollection<WorkerUser> WorkerUsers { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
        public int OpeningId { get; set; }
        public Opening Opening { get; set; }
    }
}