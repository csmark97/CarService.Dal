using CarService.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Dal.Manager
{
    public class ApplicationUserManager
    {
        private static CarServiceDbContext _context;

        private const string _nameIdentifierString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";

        public ApplicationUserManager(CarServiceDbContext context)
        {
            _context = context;
        }

        public static async Task<ClientUser> GetUserAsync(string userId)
        {
            return await _context.ClientUsers.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public static async Task<WorkerUser> GetWorkerUserAsync(string userId)
        {
            return await _context.WorkerUsers.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public static async Task<CompanyUser> GetCompanyUserAsync(string userId)
        {
            return await _context.CompanyUsers.FirstOrDefaultAsync(u => u.Id == userId);
        }
    }
}
