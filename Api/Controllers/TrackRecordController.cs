using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackRecordController : ControllerBase
    {
        private readonly TrackRecordService _trackRecordService;

        public TrackRecordController(TrackRecordService trackRecordService)
        {
            _trackRecordService = trackRecordService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTrackRecord([FromBody] TrackRecord trackRecord)
        {
            var result = await _trackRecordService.CreateTrackRecordAsync(trackRecord);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<TrackRecord>> GetAllTrackRecords()
        {
            return await _trackRecordService.GetAllTrackRecordsAsync();
        }

        [HttpGet("{id}")]
        public async Task<TrackRecord> GetTrackRecordById(int id)
        {
            return await _trackRecordService.GetTrackRecordByIdAsync(id);
        }
    }
}
