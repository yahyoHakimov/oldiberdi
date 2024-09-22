namespace Domain.Models
{
    public class Counterparty
    {
        public int Id { get; set; }
        public int AuthorId { get; set; } // FK to Users
        public User Author { get; set; } // Navigation property
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; } // FK to Users (optional)
        public User User { get; set; } // Navigation property
        public DateTime AddedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public ICollection<Operation> Operations { get; set; } // Counterparty can be part of multiple Operations
        public ICollection<Reminder> Reminders { get; set; } // Counterparty can receive multiple Reminders
        public ICollection<Payment> Payments { get; set; } // Counterparty can receive multiple Payments

    }
}
