using Cypherlead.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cypherlead.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AuditHistory> AuditHistories { get; set; }
        public DbSet<BalanceClearance> BalanceClearances { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

    }

}
