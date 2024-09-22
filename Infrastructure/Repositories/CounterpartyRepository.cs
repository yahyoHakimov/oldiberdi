using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CounterpartyRepository : ICounterpartyRepository
    {
        private readonly ApplicationDbContext _context;

        public CounterpartyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Counterparty> CreateCounterpartyAsync(Counterparty counterparty)
        {
            _context.Counterparties.Add(counterparty);
            await _context.SaveChangesAsync();
            return counterparty;
        }

        public async Task<Counterparty> GetCounterpartyByIdAsync(int id)
        {
            return await _context.Counterparties
                .Include(c => c.Author)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Counterparty>> GetAllCounterpartiesAsync()
        {
            return await _context.Counterparties
                .Include(c => c.Author)
                .ToListAsync();
        }
    }
}
