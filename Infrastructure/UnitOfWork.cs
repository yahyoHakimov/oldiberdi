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
        private IOperationRepository _operationRepository;
        private ICounterpartyRepository _counterpartyRepository;
        private ITrackRecordRepository _trackRecordRepository;
        private IConfirmationRepository _confirmationRepository;
        private IReminderRepository _reminderRepository;
        private IPaymentRepository _paymentRepository;
        private INotificationRepository _notificationRepository;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
        public IDistrictRepository DistrictRepository => _districtRepository ??= new DistrictRepository(_context);  // Add this line
        public ISubscriptionPlanRepository SubscriptionPlanRepository => _subscriptionPlanRepository ??= new SubscriptionPlanRepository(_context);  // Add this line
        public ICountryRepository CountryRepository => _countryRepository ??= new CountryRepository(_context);
        public IRegionRepository RegionRepository => _regionRepository ??= new RegionRepository(_context);
        public IOperationRepository OperationRepository => _operationRepository ??= new OperationRepository(_context);  // Add this line
        public ICounterpartyRepository CounterpartyRepository => _counterpartyRepository ??= new CounterpartyRepository(_context);  // Add this line
        public ITrackRecordRepository TrackRecordRepository => _trackRecordRepository ??= new TrackRecordRepository(_context);
        public IConfirmationRepository ConfirmationRepository => _confirmationRepository ??= new ConfirmationRepository(_context);
        public IReminderRepository ReminderRepository => _reminderRepository ??= new ReminderRepository(_context);
        public IPaymentRepository PaymentRepository => _paymentRepository ??= new PaymentRepository(_context);
        public INotificationRepository NotificationRepository => _notificationRepository ??= new NotificationRepository(_context);



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
