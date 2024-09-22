using Application.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TrackRecordRepository : ITrackRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public TrackRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TrackRecord> CreateTrackRecordAsync(TrackRecord trackRecord)
        {
            _context.TrackRecords.Add(trackRecord);
            await _context.SaveChangesAsync();
            return trackRecord;
        }

        public async Task<TrackRecord> GetTrackRecordByIdAsync(int id)
        {
            return await _context.TrackRecords
                .Include(t => t.Author)
                .Include(t => t.Operation)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<TrackRecord>> GetAllTrackRecordsAsync()
        {
            return await _context.TrackRecords
                .Include(t => t.Author)
                .Include(t => t.Operation)
                .ToListAsync();
        }
    }
}
