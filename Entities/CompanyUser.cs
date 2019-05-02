using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class CompanyUser : User
    {
        public string PrivateKey { get; set; }
        //public bool Approved { get; set; }
        public virtual ICollection<WorkerUser> WorkerUsers { get; set; }
        public virtual ICollection<SubTask> SubTasks { get; set; }
        public int OpeningId { get; set; }
        public virtual Opening Opening { get; set; }
    }
}