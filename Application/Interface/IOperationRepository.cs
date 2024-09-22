using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOperationRepository
    {
        Task<Operation> CreateOperationAsync(Operation operation);
        Task<Operation> GetOperationByIdAsync(int id);
        Task<IEnumerable<Operation>> GetAllOperationsAsync();
    }
}
