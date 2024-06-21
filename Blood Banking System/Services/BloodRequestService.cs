using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankingSystem.Services
{
    public class BloodRequestService
    {
        private readonly ApplicationDbContext _context;

        public BloodRequestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BloodRequest>> GetAllBloodRequestsAsync()
        {
            return await _context.BloodRequests.ToListAsync();
        }

        public async Task<BloodRequest?> GetBloodRequestByIdAsync(int id)
        {
            return await _context.BloodRequests.FindAsync(id);
        }

        public async Task<BloodRequest> AddBloodRequestAsync(BloodRequest bloodRequest)
        {
            _context.BloodRequests.Add(bloodRequest);
            await _context.SaveChangesAsync();
            return bloodRequest;
        }

        public async Task<BloodRequest?> UpdateBloodRequestAsync(BloodRequest bloodRequest)
        {
            _context.Entry(bloodRequest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return bloodRequest;
        }

        public async Task<bool> DeleteBloodRequestAsync(int id)
        {
            var bloodRequest = await _context.BloodRequests.FindAsync(id);
            if (bloodRequest == null)
            {
                return false;
            }

            _context.BloodRequests.Remove(bloodRequest);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

