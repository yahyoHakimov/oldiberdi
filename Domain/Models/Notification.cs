namespace Domain.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int ReceiverId { get; set; } // FK to Users
        public User Receiver { get; set; } // Navigation property
        public NotificationChannelEnum Channel { get; set; }
        public int OperationId { get; set; } // FK to Operations
        public Operation Operation { get; set; } // Navigation property
        public string Text { get; set; }
        public NotificationStatusEnum Status { get; set; } = NotificationStatusEnum.Draft;
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public enum NotificationChannelEnum
    {
        App,
        Sms,
        Email
    }

    public enum NotificationStatusEnum
    {
        Draft,
        Sent
    }
}
