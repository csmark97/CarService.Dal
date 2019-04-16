using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Dal.SeedInterfaces
{
    public interface IIdentityUserSeedService
    {
        Task SeedIdentityUserAsync();
    }
}
