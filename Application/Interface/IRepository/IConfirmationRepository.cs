using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IConfirmationRepository
    {
        Task<Confirmation> CreateConfirmationAsync(Confirmation confirmation);
        Task<Confirmation> GetConfirmationByIdAsync(int id);
        Task<IEnumerable<Confirmation>> GetAllConfirmationsAsync();
    }
}
