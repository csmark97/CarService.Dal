using CarService.Dal.Entities;
using CarService.Dal.SeedInterfaces;
using CarService.Dal.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Dal.SeedService
{
    public class CompanySeedService : IIdentityUserSeedService
    {
        private readonly UserManager<Company> _userManager;
        public CompanySeedService(UserManager<Company> userManager) =>
        _userManager = userManager;
        public async Task SeedIdentityUserAsync()
        {
            if (!(await _userManager.GetUsersInRoleAsync(Roles.Companies)).Any())
            {
                var company = new Company
                {
                    Name = "Autós Szervíz Kft.",
                    Email = "autosszerviz@bookshop.hu",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "autosszerviz",
                    PrivateKey = "RhN789!t1",
                    Address = new Address
                    {
                        Zip = 3820,
                        City = "Hidegkút",
                        Street = "Fő út",
                        HouseNumber = 150,
                    }
                };
                var createResult = await _userManager.CreateAsync(company, "$AutoSzerviz123");
                var addToRoleResult = await _userManager.AddToRoleAsync(company, Roles.Administrators);
                if (!createResult.Succeeded || !addToRoleResult.Succeeded)
                    throw new ApplicationException($"Administrator could not be created: " +
                    $"{string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description))}");

            }
        }
    }
}
