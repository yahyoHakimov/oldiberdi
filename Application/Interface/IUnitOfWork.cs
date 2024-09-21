using Application.Interface.IRepository;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        ICountryRepository CountryRepository { get; }
        IRegionRepository RegionRepository { get; }
        Task CompleteAsync();
    }
}
