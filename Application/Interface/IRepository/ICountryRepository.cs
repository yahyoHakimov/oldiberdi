using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface ICountryRepository
    {
        Task<Country> CreateCountryAsync(Country country);
        Task<Country> GetCountryByIdAsync(int id);
        Task<IEnumerable<Country>> GetAllCountriesAsync();
    }
}
