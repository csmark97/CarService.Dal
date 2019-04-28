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
        private readonly RoleManager<IdentityRole<string>> _roleManager;

        public RoleSeedService(RoleManager<IdentityRole<string>> roleManager) =>
        _roleManager = roleManager;

        public async Task SeedRoleAsync()
        {
            if (!await _roleManager.RoleExistsAsync(Roles.Clients))
            {
                await _roleManager.CreateAsync(new IdentityRole<string> { Name = Roles.Clients });
            }

            if (!await _roleManager.RoleExistsAsync(Roles.Companies))
            {
                await _roleManager.CreateAsync(new IdentityRole<string> { Name = Roles.Companies });
            }

            if (!await _roleManager.RoleExistsAsync(Roles.Workers))
            {
                await _roleManager.CreateAsync(new IdentityRole<string> { Name = Roles.Workers });
            }
        }
    }
}
