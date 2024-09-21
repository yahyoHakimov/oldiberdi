using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistrictController : ControllerBase
    {
        private readonly DistrictService _districtService;

        public DistrictController(DistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateDistrict([FromBody] District district)
        {
            var result = await _districtService.CreateDistrictAsync(district);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<District>> GetAllDistricts()
        {
            return await _districtService.GetAllDistrictsAsync();
        }

        [HttpGet("{id}")]
        public async Task<District> GetDistrictById(int id)
        {
            return await _districtService.GetDistrictByIdAsync(id);
        }
    }
}
