using Car_Wash.Database;
using Car_Wash.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Wash.Services
{
    public class ClientService
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context)
        {
            _context = context;
        }

  
        public async Task<List<Client>> GetAllAsync()
        {
            return await _context.Clients
                .OrderBy(c => c.ClientId)
                .ToListAsync();
        }

    
        public async Task<Client> FindByIdAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        // ✅ Add New Client
        public async Task AddAsync(Client client)
        {
            try
            {
                client.CreatedAt = DateTime.UtcNow;
                await _context.Clients.AddAsync(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan data klien.", ex);
            }
        }


        public async Task UpdateAsync(Client client)
        {
            try
            {
                client.UpdatedAt = DateTime.UtcNow;
                _context.Clients.Update(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memperbarui data klien.", ex);
            }
        }


        public async Task DeleteAsync(int id)
        {
            try
            {
                var client = await _context.Clients.FindAsync(id);
                if (client == null)
                    throw new Exception("Data klien tidak ditemukan.");

                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data klien.", ex);
            }
        }
    }
}
