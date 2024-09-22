using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets for all entities
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Counterparty> Counterparties { get; set; }
        public DbSet<TrackRecord> TrackRecords { get; set; }
        public DbSet<Confirmation> Confirmations { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships

            // User and Operations (One-to-Many)
            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Owner)
                .WithMany(u => u.Operations) // Assuming User has a collection of operations
                .HasForeignKey(o => o.OwnerId);

            // User and Counterparty (One-to-Many)
            modelBuilder.Entity<Counterparty>()
                .HasOne(c => c.Author)
                .WithMany(u => u.Counterparties) // Assuming User has a collection of counterparties
                .HasForeignKey(c => c.AuthorId);

            // Operation and Counterparty (One-to-One or Many-to-One)
            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Counterparty)
                .WithMany(c => c.Operations) // Assuming Counterparty has a collection of operations
                .HasForeignKey(o => o.CounterpartyId);

            // TrackRecord and Operation (Many-to-One)
            modelBuilder.Entity<TrackRecord>()
                .HasOne(tr => tr.Operation)
                .WithMany(o => o.TrackRecords) // Assuming Operation has a collection of track records
                .HasForeignKey(tr => tr.OperationId);

            // TrackRecord and Confirmation (Optional Many-to-One)
            modelBuilder.Entity<TrackRecord>()
                .HasOne(tr => tr.Confirmation)
                .WithMany(c => c.TrackRecords) // Assuming Confirmation has a collection of track records
                .HasForeignKey(tr => tr.ConfirmationId)
                .OnDelete(DeleteBehavior.SetNull); // Optional relationship

            // TrackRecord and Payment (Optional Many-to-One)
            modelBuilder.Entity<TrackRecord>()
                .HasOne(tr => tr.Payment)
                .WithMany(p => p.TrackRecords) // Assuming Payment has a collection of track records
                .HasForeignKey(tr => tr.PaymentId)
                .OnDelete(DeleteBehavior.SetNull); // Optional relationship

            // Reminder and Operation (Many-to-One)
            modelBuilder.Entity<Reminder>()
                .HasOne(r => r.Operation)
                .WithMany(o => o.Reminders) // Assuming Operation has a collection of reminders
                .HasForeignKey(r => r.OperationId);

            // Reminder and Counterparty (Many-to-One)
            modelBuilder.Entity<Reminder>()
                .HasOne(r => r.Receiver)
                .WithMany(c => c.Reminders) // Assuming Counterparty has a collection of reminders
                .HasForeignKey(r => r.ReceiverId);

            // Payment and Operation (Many-to-One)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Operation)
                .WithMany(o => o.Payments) // Assuming Operation has a collection of payments
                .HasForeignKey(p => p.OperationId);

            // Payment and Counterparty (Many-to-One)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Receiver)
                .WithMany(c => c.Payments) // Assuming Counterparty has a collection of payments
                .HasForeignKey(p => p.ReceiverId);

            // Notification and Operation (Many-to-One)
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Operation)
                .WithMany(o => o.Notifications) // Assuming Operation has a collection of notifications
                .HasForeignKey(n => n.OperationId);

            // Notification and User (Many-to-One)
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Receiver)
                .WithMany(u => u.Notifications) // Assuming User has a collection of notifications
                .HasForeignKey(n => n.ReceiverId);

            // Country, Region, District relationships
            modelBuilder.Entity<Region>()
                .HasOne(r => r.Country)
                .WithMany(c => c.Regions)
                .HasForeignKey(r => r.CountryCode);

            modelBuilder.Entity<District>()
                .HasOne(d => d.Region)
                .WithMany(r => r.Districts)
                .HasForeignKey(d => d.RegionCode);
        }
    }
}
