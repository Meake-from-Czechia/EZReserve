using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EZReserve
{
    [Table("Customers")]
    internal class Customer
    {
        [Key]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("StreetAddress")]
        public string StreetAddress { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("PostalCode")]
        public string PostalCode { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}