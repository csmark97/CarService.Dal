using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class WorkerUser : User
    {
        public virtual ICollection<Work> Works { get; set; }
        public string CompanyUserId { get; set; }
        public virtual CompanyUser CompanyUser { get; set; }
    }
}
