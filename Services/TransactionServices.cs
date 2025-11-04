using Car_Wash.Database;
using Car_Wash.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Wash.Services
{
    public class TransactionService
    {
        private readonly AppDbContext _db;
        public TransactionService(AppDbContext db) => _db = db;

        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _db.Transactions
                .Include(t => t.Client)
                .Include(t => t.Package)
                .OrderByDescending(t => t.TransactionDate)
                .ToListAsync();
        }

        public async Task AddAsync(Transaction transaction)
        {
            _db.Transactions.Add(transaction);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var trx = await _db.Transactions.FindAsync(id);
            if (trx != null)
            {
                _db.Transactions.Remove(trx);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<Transaction?> FindByIdAsync(int id)
        {
            return await _db.Transactions
                .Include(t => t.Client)
                .Include(t => t.Package)
                .FirstOrDefaultAsync(t => t.TransactionId == id);
        }
    }
}
