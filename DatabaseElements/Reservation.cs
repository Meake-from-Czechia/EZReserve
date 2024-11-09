using System.ComponentModel.DataAnnotations.Schema;

namespace EZReserve
{
    [Table("Reservations")]
    internal class Reservation
    {
        [Column("ReservationId")]
        public int ReservationId { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("Room")]
        public string Room { get; set; }
        [Column("Reservation_From")]
        public DateTime From { get; set; }
        [Column("Reservation_To")]
        public DateTime To { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}