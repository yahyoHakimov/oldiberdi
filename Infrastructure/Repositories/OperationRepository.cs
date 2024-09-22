using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly ApplicationDbContext _context;

        public OperationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Operation> CreateOperationAsync(Operation operation)
        {
            _context.Operations.Add(operation);
            await _context.SaveChangesAsync();
            return operation;
        }

        public async Task<Operation> GetOperationByIdAsync(int id)
        {
            return await _context.Operations
                .Include(o => o.Owner)
                .Include(o => o.Counterparty)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Operation>> GetAllOperationsAsync()
        {
            return await _context.Operations
                .Include(o => o.Owner)
                .Include(o => o.Counterparty)
                .ToListAsync();
        }
    }
}
