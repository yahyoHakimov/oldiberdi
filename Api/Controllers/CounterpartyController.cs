using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CounterpartyController : ControllerBase
    {
        private readonly CounterpartyService _counterpartyService;

        public CounterpartyController(CounterpartyService counterpartyService)
        {
            _counterpartyService = counterpartyService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCounterparty([FromBody] Counterparty counterparty)
        {
            var result = await _counterpartyService.CreateCounterpartyAsync(counterparty);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Counterparty>> GetAllCounterparties()
        {
            return await _counterpartyService.GetAllCounterpartiesAsync();
        }

        [HttpGet("{id}")]
        public async Task<Counterparty> GetCounterpartyById(int id)
        {
            return await _counterpartyService.GetCounterpartyByIdAsync(id);
        }
    }
}
