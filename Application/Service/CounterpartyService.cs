using Application.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CounterpartyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CounterpartyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Counterparty> CreateCounterpartyAsync(Counterparty counterparty)
        {
            counterparty.AddedOn = DateTime.Now;
            counterparty.UpdatedOn = DateTime.Now;

            var createdCounterparty = await _unitOfWork.CounterpartyRepository.CreateCounterpartyAsync(counterparty);
            await _unitOfWork.CompleteAsync();

            return createdCounterparty;
        }

        public async Task<IEnumerable<Counterparty>> GetAllCounterpartiesAsync()
        {
            return await _unitOfWork.CounterpartyRepository.GetAllCounterpartiesAsync();
        }

        public async Task<Counterparty> GetCounterpartyByIdAsync(int id)
        {
            return await _unitOfWork.CounterpartyRepository.GetCounterpartyByIdAsync(id);
        }
    }
}
