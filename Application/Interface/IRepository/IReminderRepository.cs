using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReminderRepository
    {
        Task<Reminder> CreateReminderAsync(Reminder reminder);
        Task<Reminder> GetReminderByIdAsync(int id);
        Task<IEnumerable<Reminder>> GetAllRemindersAsync();
    }
}
