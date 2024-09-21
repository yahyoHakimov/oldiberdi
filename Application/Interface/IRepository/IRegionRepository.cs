using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IRegionRepository
    {
        Task<Region> CreateRegionAsync(Region region);
        Task<Region> GetRegionByIdAsync(int id);
        Task<IEnumerable<Region>> GetAllRegionsAsync();
    }
}
