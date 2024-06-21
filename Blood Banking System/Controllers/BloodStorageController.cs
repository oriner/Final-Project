using Microsoft.AspNetCore.Mvc;
using BloodBankingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace BloodBankingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodStorageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BloodStorageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BloodStorage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BloodStorage>>> GetBloodStorage()
        {
            return await _context.BloodStorages.ToListAsync();
        }

        // GET: api/BloodStorage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BloodStorage>> GetBloodStorage(int id)
        {
            var bloodStorage = await _context.BloodStorages.FindAsync(id);

            if (bloodStorage == null)
            {
                return NotFound();
            }

            return bloodStorage;
        }

        // POST: api/BloodStorage
        [HttpPost]
        public async Task<ActionResult<BloodStorage>> PostBloodStorage(BloodStorage bloodStorage)
        {
            _context.BloodStorages.Add(bloodStorage);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBloodStorage), new { id = bloodStorage.BloodId }, bloodStorage);
        }

        // PUT: api/BloodStorage/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodStorage(int id, BloodStorage bloodStorage)
        {
            if (id != bloodStorage.BloodId)
            {
                return BadRequest();
            }

            _context.Entry(bloodStorage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodStorageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/BloodStorage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodStorage(int id)
        {
            var bloodStorage = await _context.BloodStorages.FindAsync(id);
            if (bloodStorage == null)
            {
                return NotFound();
            }

            _context.BloodStorages.Remove(bloodStorage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BloodStorageExists(int id)
        {
            return _context.BloodStorages.Any(e => e.BloodId == id);
        }
    }
}
