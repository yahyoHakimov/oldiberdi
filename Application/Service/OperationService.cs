using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OperationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OperationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Operation> CreateOperationAsync(Operation operation)
        {
            operation.AddedOn = DateTime.Now;
            operation.UpdatedOn = DateTime.Now;

            var createdOperation = await _unitOfWork.OperationRepository.CreateOperationAsync(operation);
            await _unitOfWork.CompleteAsync();

            return createdOperation;
        }

        public async Task<IEnumerable<Operation>> GetAllOperationsAsync()
        {
            return await _unitOfWork.OperationRepository.GetAllOperationsAsync();
        }

        public async Task<Operation> GetOperationByIdAsync(int id)
        {
            return await _unitOfWork.OperationRepository.GetOperationByIdAsync(id);
        }
    }
}
