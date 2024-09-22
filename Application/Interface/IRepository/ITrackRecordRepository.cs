using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITrackRecordRepository
    {
        Task<TrackRecord> CreateTrackRecordAsync(TrackRecord trackRecord);
        Task<TrackRecord> GetTrackRecordByIdAsync(int id);
        Task<IEnumerable<TrackRecord>> GetAllTrackRecordsAsync();
    }
}
