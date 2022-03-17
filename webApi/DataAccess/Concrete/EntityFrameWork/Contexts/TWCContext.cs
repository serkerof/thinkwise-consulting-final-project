using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameWork.Contexts
{
    public class TwcContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Admin>? Admins { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Email>? Emails { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Employee>? Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K4GQOET\SQLEXPRESS;Initial Catalog=TWC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}