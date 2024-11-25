namespace EZReserve
{
    public class ExportDto
    {

        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public int ReservationId { get; set; }
        public string ReservationRoom { get; set; }
        public DateTime ReservationDateFrom { get; set; }
        public DateTime ReservationDateTo { get; set; }
        public ExportDto(int customerId, string customerFirstName, string customerLastName, string customerEmail, int reservationId,
                                    string reservationRoom, DateTime reservationDateFrom, DateTime reservationDateTo)
        {
            CustomerId = customerId;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            CustomerEmail = customerEmail;
            ReservationId = reservationId;
            ReservationRoom = reservationRoom;
            ReservationDateFrom = reservationDateFrom;
            ReservationDateTo = reservationDateTo;
        }
        public string GetCsvLine()
        {
            return $"{CustomerId};{CustomerFirstName};{CustomerLastName};{CustomerEmail};{ReservationId};{ReservationRoom};{ReservationDateFrom};{ReservationDateTo}"; ;
        }
    }
}