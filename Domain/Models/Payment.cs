namespace Domain.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; } // FK to Users
        public User Author { get; set; } // Navigation property
        public int OperationId { get; set; } // FK to Operations
        public Operation Operation { get; set; } // Navigation property
        public int ReceiverId { get; set; } // FK to Counterparties
        public Counterparty Receiver { get; set; } // Navigation property
        public int Amount { get; set; }
        public PaymentStatusEnum Status { get; set; } = PaymentStatusEnum.New;
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ICollection<TrackRecord> TrackRecords { get; set; } // Payment can be associated with multiple TrackRecords

    }

    public enum PaymentStatusEnum
    {
        New,
        Sent,
        Finished
    }
}
