using CarService.Dal.SeedInterfaces;
using CarService.Dal.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Dal.SeedService
{
    public class RoleSeedService : IRoleSeedService
    {
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        public RoleSeedService(RoleManager<IdentityRole<int>> roleManager) =>
        _roleManager = roleManager;
        public async Task SeedRoleAsync()
        {
            if (!await _roleManager.RoleExistsAsync(Roles.Clients))
            {
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Companies });
            }

            if (!await _roleManager.RoleExistsAsync(Roles.Companies))
            {
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Companies });
            }

            if (!await _roleManager.RoleExistsAsync(Roles.Workers))
            {
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Companies });
            }
        }
    }
}
