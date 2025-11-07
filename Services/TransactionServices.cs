using Car_Wash.Database;
using Car_Wash.Model;
using Microsoft.EntityFrameworkCore;
using System;
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
            bool clientExists = await _db.Clients.AnyAsync(c => c.ClientId == transaction.ClientId);
            bool packageExists = await _db.Packages.AnyAsync(p => p.PackageId == transaction.PackageId);

            if (!clientExists || !packageExists)
                throw new Exception("Client atau Package tidak valid.");

            try
            {
                _db.Transactions.Add(transaction);
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Database Error: {ex.InnerException?.Message ?? ex.Message}");
                throw new Exception($"Gagal menyimpan transaksi. Detail: {ex.InnerException?.Message ?? "Pelanggaran batasan."}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                throw;
            }
        }

        public async Task UpdateAsync(Transaction transaction)
        {
            var trx = await _db.Transactions.FindAsync(transaction.TransactionId);
            if (trx == null) throw new Exception("Transaksi tidak ditemukan.");

            trx.ClientId = transaction.ClientId;
            trx.PackageId = transaction.PackageId;
            trx.PaymentMethod = transaction.PaymentMethod;
            trx.TotalPrice = transaction.TotalPrice;
            trx.TransactionDate = transaction.TransactionDate;

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
