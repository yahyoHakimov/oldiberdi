using Domain.Models.Enums;

namespace Domain.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public OperationTypeEnum Type { get; set; }
        public int OwnerId { get; set; } // FK to Users
        public User Owner { get; set; } // Navigation property
        public int Amount { get; set; }
        public int PayedAmount { get; set; } = 0;
        public int PayedPercent { get; set; } = 0;
        public DealTypeEnum DealType { get; set; }
        public ReturnTypeEnum ReturnType { get; set; }
        public DateTime? CloseDate { get; set; }
        public int CounterpartyId { get; set; } // FK to Counterparties
        public Counterparty Counterparty { get; set; } // Navigation property
        public int? ConfirmationId { get; set; } // FK to Confirmations (optional)
        public StatusEnum Status { get; set; } = StatusEnum.Draft;
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public ICollection<TrackRecord> TrackRecords { get; set; } // Operation can have multiple TrackRecords
        public ICollection<Reminder> Reminders { get; set; } // Operation can have multiple Reminders
        public ICollection<Payment> Payments { get; set; } // Operation can have multiple Payments
        public ICollection<Notification> Notifications { get; set; } // Operation can have multiple Notifications

    }

    public enum OperationTypeEnum
    {
        Loan,
        Debt
    }

    public enum DealTypeEnum
    {
        Soft,
        Hard
    }

    public enum ReturnTypeEnum
    {
        Full,
        Scheduled,
        Recurring
    }

}
