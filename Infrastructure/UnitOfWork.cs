using Application.Interface.IRepository;
using Application.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IUserRepository _userRepository;
        private IDistrictRepository _districtRepository;
        private ISubscriptionPlanRepository _subscriptionPlanRepository;
        private ICountryRepository _countryRepository;
        private IRegionRepository _regionRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
        public IDistrictRepository DistrictRepository => _districtRepository ??= new DistrictRepository(_context);  // Add this line
        public ISubscriptionPlanRepository SubscriptionPlanRepository => _subscriptionPlanRepository ??= new SubscriptionPlanRepository(_context);  // Add this line

        public ICountryRepository CountryRepository => _countryRepository ??= new CountryRepository(_context);

        public IRegionRepository RegionRepository => _regionRepository ??= new RegionRepository(_context);

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
