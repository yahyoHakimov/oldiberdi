using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationController : ControllerBase
    {
        private readonly OperationService _operationService;

        public OperationController(OperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateOperation([FromBody] Operation operation)
        {
            var result = await _operationService.CreateOperationAsync(operation);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Operation>> GetAllOperations()
        {
            return await _operationService.GetAllOperationsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Operation> GetOperationById(int id)
        {
            return await _operationService.GetOperationByIdAsync(id);
        }
    }
}
