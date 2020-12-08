using Microsoft.EntityFrameworkCore;
using SpoRT.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpoRT.Persistence.Managers
{
    public class SportPersistenceManager : ISportPersistenceManager
    {
        private readonly ApplicationDbContext _context;

        public SportPersistenceManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Save(SportEntity sport)
        {
            _context.Sports.Add(sport);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SportEntity>> GetAll()
        {
            return await _context.Sports.ToListAsync();
        }
    }
}