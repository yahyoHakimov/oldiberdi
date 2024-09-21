using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RegionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Region> CreateRegionAsync(Region region)
        {
            region.AddedOn = DateTime.Now;
            region.UpdatedOn = DateTime.Now;

            var createdRegion = await _unitOfWork.RegionRepository.CreateRegionAsync(region);
            await _unitOfWork.CompleteAsync();

            return createdRegion;
        }

        public async Task<IEnumerable<Region>> GetAllRegionsAsync()
        {
            return await _unitOfWork.RegionRepository.GetAllRegionsAsync();
        }

        public async Task<Region> GetRegionByIdAsync(int id)
        {
            return await _unitOfWork.RegionRepository.GetRegionByIdAsync(id);
        }
    }
}
