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

        public static async Task<IList<Service>> GetServcieByUserIdAsync(string id)
        {
            return await _context.Services
                .Where(w => w.Car.ClientUserId == id)
                .Include(s => s.Car).ToListAsync();
        }

        public static async Task<IList<Car>> GetCarsByUserIdAsync(string userId)
        {
            return await _context.Cars.Where(w => w.ClientUserId == userId).ToListAsync();
        }        

        public static async Task<IList<WorkerUser>> GetWorkerUsersAsync()
        {
            return await _context.WorkerUsers.ToArrayAsync();
        }

        public static async Task<IList<Work>> GetWorkByServiceIdAsync(int id)
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

        public static IList<Service> GetServicesByCarId(int carId)
        {
            return _context.Services
                   .Where(e => e.Id == carId)
                   .Include(w => w.Works)
                   .ToList();
        }

        public static async Task<Service> GetServcieByIdAsync(int id)
        {
            return await _context.Services.Where(w => w.Id == id).FirstOrDefaultAsync();
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
    }
}
