using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IDistrictRepository
    {
        Task<District> CreateDistrictAsync(District district);
        Task<District> GetDistrictByIdAsync(int id);
        Task<IEnumerable<District>> GetAllDistrictsAsync();
    }
}
