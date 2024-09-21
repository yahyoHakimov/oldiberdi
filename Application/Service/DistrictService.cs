using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DistrictService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DistrictService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<District> CreateDistrictAsync(District district)
        {
            district.AddedOn = DateTime.Now;
            district.UpdatedOn = DateTime.Now;

            var createdDistrict = await _unitOfWork.DistrictRepository.CreateDistrictAsync(district);
            await _unitOfWork.CompleteAsync();

            return createdDistrict;
        }

        public async Task<IEnumerable<District>> GetAllDistrictsAsync()
        {
            return await _unitOfWork.DistrictRepository.GetAllDistrictsAsync();
        }

        public async Task<District> GetDistrictByIdAsync(int id)
        {
            return await _unitOfWork.DistrictRepository.GetDistrictByIdAsync(id);
        }
    }
}
