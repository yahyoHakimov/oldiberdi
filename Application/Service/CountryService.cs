using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CountryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Country> CreateCountryAsync(Country country)
        {
            country.AddedOn = DateTime.Now;
            country.UpdatedOn = DateTime.Now;

            var createdCountry = await _unitOfWork.CountryRepository.CreateCountryAsync(country);
            await _unitOfWork.CompleteAsync();

            return createdCountry;
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await _unitOfWork.CountryRepository.GetAllCountriesAsync();
        }

        public async Task<Country> GetCountryByIdAsync(int id)
        {
            return await _unitOfWork.CountryRepository.GetCountryByIdAsync(id);
        }
    }
}
