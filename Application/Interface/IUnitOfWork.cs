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
        IDistrictRepository DistrictRepository { get; }
        ISubscriptionPlanRepository SubscriptionPlanRepository { get; }  // Add this line
        IOperationRepository OperationRepository { get; }  // Add this line
        ICounterpartyRepository CounterpartyRepository { get; }  // Add this line
        ITrackRecordRepository TrackRecordRepository { get; }
        IConfirmationRepository ConfirmationRepository { get; }
        IReminderRepository ReminderRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        INotificationRepository NotificationRepository { get; }


        Task CompleteAsync();
    }
}
