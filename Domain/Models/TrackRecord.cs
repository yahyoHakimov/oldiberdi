namespace Domain.Models
{
    public class TrackRecord
    {
        public int Id { get; set; }
        public int AuthorId { get; set; } // FK to Users
        public User Author { get; set; } // Navigation property
        public int OperationId { get; set; } // FK to Operations
        public Operation Operation { get; set; } // Navigation property
        public bool NeedConfirmation { get; set; } = false;
        public int? ConfirmationId { get; set; } // FK to Confirmations (optional)
        public Confirmation Confirmation { get; set; } // Navigation property
        public int? PaymentId { get; set; } // FK to Payments (optional)
        public Payment Payment { get; set; } // Navigation property
        public TrackRecordTypeEnum Type { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public enum TrackRecordTypeEnum
    {
        Cash,
        Card
    }
}
