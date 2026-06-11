using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SomaShare.Models;

namespace SomaShare.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        { 
        }

        public DbSet<Textbook> Textbooks { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<WantedAd> WantedAds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Offer>()
                .HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Offer>()
                .HasOne(o => o.Textbook)
                .WithMany()
                .HasForeignKey(o => o.TextbookID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Textbook)
                .WithMany()
                .HasForeignKey(t => t.TextbookID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
