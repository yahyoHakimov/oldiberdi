namespace Domain.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public int AuthorId { get; set; } // FK to Users
        public User Author { get; set; } // Navigation property
        public int ReceiverId { get; set; } // FK to Counterparties
        public Counterparty Receiver { get; set; } // Navigation property
        public int OperationId { get; set; } // FK to Operations
        public Operation Operation { get; set; } // Navigation property
        public string Text { get; set; }
        public ReminderStatusEnum Status { get; set; } = ReminderStatusEnum.New;
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public enum ReminderStatusEnum
    {
        New,
        Sent,
        Received,
        Replied
    }
}
