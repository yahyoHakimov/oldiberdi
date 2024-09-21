using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionPlanController : ControllerBase
    {
        private readonly SubscriptionPlanService _subscriptionPlanService;

        public SubscriptionPlanController(SubscriptionPlanService subscriptionPlanService)
        {
            _subscriptionPlanService = subscriptionPlanService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateSubscriptionPlan([FromBody] SubscriptionPlan subscriptionPlan)
        {
            var result = await _subscriptionPlanService.CreateSubscriptionPlanAsync(subscriptionPlan);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<SubscriptionPlan>> GetAllSubscriptionPlans()
        {
            return await _subscriptionPlanService.GetAllSubscriptionPlansAsync();
        }

        [HttpGet("{id}")]
        public async Task<SubscriptionPlan> GetSubscriptionPlanById(int id)
        {
            return await _subscriptionPlanService.GetSubscriptionPlanByIdAsync(id);
        }
    }
}
