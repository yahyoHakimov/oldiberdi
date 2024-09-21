using Application.Interface.IRepository;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DistrictRepository : IDistrictRepository
    {
        private readonly ApplicationDbContext _context;

        public DistrictRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<District> CreateDistrictAsync(District district)
        {
            _context.Districts.Add(district);
            await _context.SaveChangesAsync();
            return district;
        }

        public async Task<District> GetDistrictByIdAsync(int id)
        {
            return await _context.Districts.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<District>> GetAllDistrictsAsync()
        {
            return await _context.Districts.ToListAsync();
        }
    }
}
