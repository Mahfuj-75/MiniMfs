using Microsoft.EntityFrameworkCore;
using MiniMfs.Models;

namespace MiniMfs.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base( options)
        {

        }
        public DbSet<User> Users => Set<User>();
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Transaction> Transactions => Set<Transaction>();

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
                e.Property(u => u.Phone).HasMaxLength(11).IsRequired();
                e.Property(u => u.Name).HasMaxLength(100).IsRequired();
                e.HasIndex(u => u.Phone).IsUnique();

                e.HasOne(U => U.Account)
                .WithOne(a => a.User)
                .HasForeignKey<Account>(a => a.UserId);
            });

            modelBuilder.Entity<Account>(e =>
            {
                e.Property(a => a.Balance).HasPrecision(18, 2);
            });

            modelBuilder.Entity<Transaction>(e =>
            {
                e.Property(t => t.Amount).HasPrecision(18, 2);
                e.Property(t => t.Type).HasConversion<string>();
            });
        }
    }
}