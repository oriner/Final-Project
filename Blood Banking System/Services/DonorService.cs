using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankingSystem.Services
{
    public class DonorService
    {
        private readonly ApplicationDbContext _context;

        public DonorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Donor>> GetAllDonorsAsync()
        {
            return await _context.Donors.ToListAsync();
        }

        public async Task<Donor?> GetDonorByIdAsync(int id)
        {
            return await _context.Donors.FindAsync(id);
        }

        public async Task<Donor> AddDonorAsync(Donor donor)
        {
            _context.Donors.Add(donor);
            await _context.SaveChangesAsync();
            return donor;
        }

        public async Task<Donor?> UpdateDonorAsync(Donor donor)
        {
            _context.Entry(donor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return donor;
        }

        public async Task<bool> DeleteDonorAsync(int id)
        {
            var donor = await _context.Donors.FindAsync(id);
            if (donor == null)
            {
                return false;
            }

            _context.Donors.Remove(donor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

