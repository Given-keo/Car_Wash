using Car_Wash.Database;
using Car_Wash.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Car_Wash.Services
{
    public class PackageService
    {
        private readonly AppDbContext _db;

        public PackageService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Package>> GetAllAsync()
        {
            return await _db.Packages.OrderBy(p => p.PackageId).ToListAsync();
        }

        public async Task<Package?> FindByIdAsync(int id)
        {
            return await _db.Packages.FindAsync(id);
        }

        public async Task AddAsync(Package package)
        {
            await _db.Packages.AddAsync(package);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Package package)
        {
            _db.Packages.Update(package);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var package = await _db.Packages.FindAsync(id);
            if (package != null)
            {
                _db.Packages.Remove(package);
                await _db.SaveChangesAsync();
            }
        }
    }
}
