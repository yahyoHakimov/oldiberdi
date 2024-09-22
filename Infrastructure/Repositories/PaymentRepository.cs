using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create a new payment
        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            payment.AddedOn = DateTime.Now;
            payment.UpdatedOn = DateTime.Now;

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        // Get a payment by ID
        public async Task<Payment> GetPaymentByIdAsync(int id)
        {
            return await _context.Payments
                .Include(p => p.Author) // Include related Author (User)
                .Include(p => p.Operation) // Include related Operation
                .Include(p => p.Receiver) // Include related Counterparty
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        // Get all payments
        public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
        {
            return await _context.Payments
                .Include(p => p.Author) // Include related Author (User)
                .Include(p => p.Operation) // Include related Operation
                .Include(p => p.Receiver) // Include related Counterparty
                .ToListAsync();
        }
    }
}
