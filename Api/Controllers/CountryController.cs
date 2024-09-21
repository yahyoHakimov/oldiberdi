using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly CountryService _countryService;

        public CountryController(CountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCountry([FromBody] Country country)
        {
            var result = await _countryService.CreateCountryAsync(country);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await _countryService.GetAllCountriesAsync();
        }

        [HttpGet("{id}")]
        public async Task<Country> GetCountryById(int id)
        {
            return await _countryService.GetCountryByIdAsync(id);
        }
    }
}
