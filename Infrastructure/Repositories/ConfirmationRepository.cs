using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ConfirmationRepository : IConfirmationRepository
    {
        private readonly ApplicationDbContext _context;

        public ConfirmationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Confirmation> CreateConfirmationAsync(Confirmation confirmation)
        {
            _context.Confirmations.Add(confirmation);
            await _context.SaveChangesAsync();
            return confirmation;
        }

        public async Task<Confirmation> GetConfirmationByIdAsync(int id)
        {
            return await _context.Confirmations
                /*.Include(c => c.Counterparty)*/
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Confirmation>> GetAllConfirmationsAsync()
        {
            return await _context.Confirmations
                /*.Include(c => c.Counterparty)*/
                .ToListAsync();
        }
    }
}
