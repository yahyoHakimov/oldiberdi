using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICounterpartyRepository
    {
        Task<Counterparty> CreateCounterpartyAsync(Counterparty counterparty);
        Task<Counterparty> GetCounterpartyByIdAsync(int id);
        Task<IEnumerable<Counterparty>> GetAllCounterpartiesAsync();
    }
}
