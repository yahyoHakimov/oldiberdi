using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface ISubscriptionPlanRepository
    {
        Task<SubscriptionPlan> CreateSubscriptionPlanAsync(SubscriptionPlan subscriptionPlan);
        Task<SubscriptionPlan> GetSubscriptionPlanByIdAsync(int id);
        Task<IEnumerable<SubscriptionPlan>> GetAllSubscriptionPlansAsync();
    }
}
