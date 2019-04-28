using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class WorkerUser : User
    {
        public ICollection<Work> Works { get; set; }
        public string CompanyUserId { get; set; }
        public CompanyUser CompanyUser { get; set; }
    }
}
