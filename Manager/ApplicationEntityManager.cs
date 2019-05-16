using CarService.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Dal.Manager
{
    public class ApplicationEntityManager
    {

        private static CarServiceDbContext _context;

        public ApplicationEntityManager(CarServiceDbContext context)
        {
            _context = context;
        }

        public static async Task<SubTask> GetSubTaskByIdAsync(int id)
        {
            return await _context.SubTasks.Where(s => s.Id == id).FirstOrDefaultAsync();
        }

        public static void GetEmailByUserIdAsync(string v, object userId)
        {
            throw new NotImplementedException();
        }

        public static async Task<IList<Service>> GetServicesByCompanyIdAsync(CompanyUser user)
        {
            return await _context.Services
                .Where(s => s.Works.Any(w => w.SubTask.CompanyUserId == user.Id))
                .OrderBy(w => w.EndTime).Include(i => i.Works).ToListAsync();
        }

        public static async Task<Service> GetServiceByIdAsync(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public static async Task<IList<Work>> GetRemainingWorksByWorkerIdAsync(string workerId)
        {
            return await _context.Works
                .Where(work => work.WorkerUserId == workerId && work.StartingTime > DateTime.Today)
                .OrderBy(work => work.StartingTime)
                .ToArrayAsync();
        }

        public static async Task<IList<Service>> GetServiceByUserIdAsync(string id)
        {
            return await _context.Services
                .Where(w => w.Car.ClientUserId == id)
                .Include(s => s.Car).ToListAsync();
        }

        public static async Task<Work> GetWorkByIdAsync(int id)
        {
            return await _context.Works
               .Include(w => w.Service)
               .Include(w => w.State)
               .Include(w => w.SubTask)
               .Include(w => w.WorkerUser)
               .Include(w => w.Messages)
               .FirstOrDefaultAsync(m => m.Id == id);
        }

        public static async Task ModifyWorkAsync(Work work)
        {
            _context.Attach(work).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public static async Task<IList<Car>> GetCarsByUserIdAsync(string userId)
        {
            return await _context.Cars.Where(w => w.ClientUserId == userId).ToListAsync();
        }        

        public static async Task<IList<WorkerUser>> GetWorkerUsersAsync()
        {
            return await _context.WorkerUsers.ToArrayAsync();
        }

        public static async Task<IList<Work>> GetWorksByServiceIdAsync(int id)
        {
            return await _context.Works
                .Where(w => w.ServiceId == id)
                .Include(w => w.Service)
                .Include(w => w.State)
                .Include(w => w.SubTask)
                .Include(w => w.WorkerUser)
                .ToListAsync();
        }

        public static async Task SaveServiceAsync(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
        }

        public static bool CarHasService(int carId)
        {
            return _context.Services.Any(e => e.Id == carId);
        }

        public static async Task<IList<Service>> GetServicesByCarIdAsync(int carId)
        {
            return await _context.Services
                   .Where(e => e.CarId == carId)
                   .Include(w => w.Works)
                   .ToListAsync();
        }

        public static async Task<Service> GetServcieByIdAsync(int id)
        {
            return await _context.Services.Where(w => w.Id == id).Include(service => service.Works).FirstOrDefaultAsync();
        }

        public static async Task<IList<WorkerUser>> GetWorkerUsersByCompanyIdAsync(string companyId)
        {
            return await _context.WorkerUsers.Where(user => user.CompanyUserId == companyId).ToArrayAsync();
        }

        public static void ModifyService(Service service)
        {
            _context.Services.Add(service);
            _context.Attach(service).State = EntityState.Modified;
        }

        public static async Task SaveWorkAsync(Work work)
        {
            _context.Works.Add(work);
            await _context.SaveChangesAsync();
        }

        public static async Task<Car> GetCarByIdAsync(int carId)
        {
            return await _context.Cars.FindAsync(carId);
        }

        public static async Task SaveMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
        }
    }
}
