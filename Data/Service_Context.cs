using WebApplication6.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Data
{
    public class Service_Context : DbContext
    {
        public Service_Context(DbContextOptions<Service_Context> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Server>().ToTable("Server");
            modelBuilder.Entity<Question>().ToTable("Question");
            modelBuilder.Entity<Admin>().ToTable("Admin");
        }
    }
}
