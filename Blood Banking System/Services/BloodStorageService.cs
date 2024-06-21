using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankingSystem.Services
{
    public class BloodStorageService
    {
        private readonly ApplicationDbContext _context;

        public BloodStorageService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BloodStorage>> GetAllBloodStorageAsync()
        {
            return await _context.BloodStorages.ToListAsync();
        }

        public async Task<BloodStorage?> GetBloodStorageByIdAsync(int id)
        {
            return await _context.BloodStorages.FindAsync(id);
        }

        public async Task<BloodStorage> AddBloodStorageAsync(BloodStorage bloodStorage)
        {
            _context.BloodStorages.Add(bloodStorage);
            await _context.SaveChangesAsync();
            return bloodStorage;
        }

        public async Task<BloodStorage?> UpdateBloodStorageAsync(BloodStorage bloodStorage)
        {
            _context.Entry(bloodStorage).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return bloodStorage;
        }

        public async Task<bool> DeleteBloodStorageAsync(int id)
        {
            var bloodStorage = await _context.BloodStorages.FindAsync(id);
            if (bloodStorage == null)
            {
                return false;
            }

            _context.BloodStorages.Remove(bloodStorage);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

