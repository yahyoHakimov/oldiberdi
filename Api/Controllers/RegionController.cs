using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly RegionService _regionService;

        public RegionController(RegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateRegion([FromBody] Region region)
        {
            var result = await _regionService.CreateRegionAsync(region);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Region>> GetAllRegions()
        {
            return await _regionService.GetAllRegionsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Region> GetRegionById(int id)
        {
            return await _regionService.GetRegionByIdAsync(id);
        }
    }
}
