using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SubscriptionPlanService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubscriptionPlanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<SubscriptionPlan> CreateSubscriptionPlanAsync(SubscriptionPlan subscriptionPlan)
        {
            subscriptionPlan.AddedOn = DateTime.Now;
            subscriptionPlan.UpdatedOn = DateTime.Now;

            var createdPlan = await _unitOfWork.SubscriptionPlanRepository.CreateSubscriptionPlanAsync(subscriptionPlan);
            await _unitOfWork.CompleteAsync();

            return createdPlan;
        }

        public async Task<IEnumerable<SubscriptionPlan>> GetAllSubscriptionPlansAsync()
        {
            return await _unitOfWork.SubscriptionPlanRepository.GetAllSubscriptionPlansAsync();
        }

        public async Task<SubscriptionPlan> GetSubscriptionPlanByIdAsync(int id)
        {
            return await _unitOfWork.SubscriptionPlanRepository.GetSubscriptionPlanByIdAsync(id);
        }
    }
}
