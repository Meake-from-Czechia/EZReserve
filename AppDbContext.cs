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
        public List<ExportDto> GetExportDtos(DateTime dateFrom, DateTime dateTo)
        {
            return Reservations.Include(r => r.Customer)
                .Where(r => r.From >= dateFrom && r.From <= dateTo)
                .Select(r => new ExportDto
                (
                   r.Customer.CustomerId,
                   r.Customer.FirstName,
                   r.Customer.LastName,
                   r.Customer.Email,
                   r.ReservationId,
                   r.Room,
                   r.From,
                   r.To
                ))
                .ToList();
        }
    }
}