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
            // User relationships
            modelBuilder.Entity<User>()
                .HasMany(u => u.Operations)
                .WithOne(o => o.Owner)
                .HasForeignKey(o => o.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Counterparties)
                .WithOne(c => c.Author)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Notifications)
                .WithOne(n => n.Receiver)
                .HasForeignKey(n => n.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            // Operation relationships
            modelBuilder.Entity<Operation>()
                .HasOne(o => o.Counterparty)
                .WithMany(c => c.Operations)
                .HasForeignKey(o => o.CounterpartyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasMany(o => o.TrackRecords)
                .WithOne(tr => tr.Operation)
                .HasForeignKey(tr => tr.OperationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasMany(o => o.Reminders)
                .WithOne(r => r.Operation)
                .HasForeignKey(r => r.OperationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasMany(o => o.Payments)
                .WithOne(p => p.Operation)
                .HasForeignKey(p => p.OperationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Operation>()
                .HasMany(o => o.Notifications)
                .WithOne(n => n.Operation)
                .HasForeignKey(n => n.OperationId)
                .OnDelete(DeleteBehavior.Restrict);

            // TrackRecord relationships
            modelBuilder.Entity<TrackRecord>()
                .HasOne(tr => tr.Author)
                .WithMany()
                .HasForeignKey(tr => tr.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TrackRecord>()
                .HasOne(tr => tr.Confirmation)
                .WithMany(c => c.TrackRecords)
                .HasForeignKey(tr => tr.ConfirmationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TrackRecord>()
                .HasOne(tr => tr.Payment)
                .WithMany(p => p.TrackRecords)
                .HasForeignKey(tr => tr.PaymentId)
                .OnDelete(DeleteBehavior.NoAction);

            // Reminder relationships
            modelBuilder.Entity<Reminder>()
                .HasOne(r => r.Receiver)
                .WithMany(c => c.Reminders)
                .HasForeignKey(r => r.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            // Payment relationships
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Receiver)
                .WithMany(c => c.Payments)
                .HasForeignKey(p => p.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            // Country, Region, District relationships
            modelBuilder.Entity<Region>()
                .HasOne(r => r.Country)
                .WithMany(c => c.Regions)
                .HasForeignKey(r => r.CountryCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<District>()
                .HasOne(d => d.Region)
                .WithMany(r => r.Districts)
                .HasForeignKey(d => d.RegionCode)
                .OnDelete(DeleteBehavior.Restrict);

            // SubscriptionPlan relationships (if any)
            // Add any specific configurations for SubscriptionPlan if needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
