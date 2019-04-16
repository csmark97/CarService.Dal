using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class WorkerUser : User
    {
        public string PrivateKey { get; set; }
    }
}
