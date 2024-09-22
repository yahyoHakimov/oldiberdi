using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TrackRecordService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TrackRecordService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TrackRecord> CreateTrackRecordAsync(TrackRecord trackRecord)
        {
            trackRecord.AddedOn = DateTime.Now;
            trackRecord.UpdatedOn = DateTime.Now;

            var createdRecord = await _unitOfWork.TrackRecordRepository.CreateTrackRecordAsync(trackRecord);
            await _unitOfWork.CompleteAsync();

            return createdRecord;
        }

        public async Task<IEnumerable<TrackRecord>> GetAllTrackRecordsAsync()
        {
            return await _unitOfWork.TrackRecordRepository.GetAllTrackRecordsAsync();
        }

        public async Task<TrackRecord> GetTrackRecordByIdAsync(int id)
        {
            return await _unitOfWork.TrackRecordRepository.GetTrackRecordByIdAsync(id);
        }
    }
}
