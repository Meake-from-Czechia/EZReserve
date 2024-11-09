using Microsoft.EntityFrameworkCore;

namespace EZReserve
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        }
    }
}