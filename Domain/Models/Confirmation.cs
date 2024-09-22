namespace Domain.Models
{
    public class Confirmation
    {
        public int Id { get; set; }
        public int AuthorId { get; set; } // FK to Users
        public User Author { get; set; } // Navigation property
        public int CounterpartyId { get; set; } // FK to Counterparties
        public Counterparty Counterparty { get; set; } // Navigation property
        public ConfirmationChannelEnum Channel { get; set; }
        public ConfirmationStatusEnum Status { get; set; } = ConfirmationStatusEnum.Draft;
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public ICollection<TrackRecord> TrackRecords { get; set; } // Confirmation can be associated with multiple TrackRecords

    }

    public enum ConfirmationChannelEnum
    {
        Sms,
        Email
    }

    public enum ConfirmationStatusEnum
    {
        Draft,
        Sent,
        Received,
        Confirmed,
        Annulled
    }
}
