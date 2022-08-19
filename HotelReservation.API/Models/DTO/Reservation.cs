namespace HotelReservation.API.Models.DTO
{
    public class Reservation
    {
        private Guid id;
        private int days;
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Room Room { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        // Days Are accurately calculated but can still be edited by end user.
        public double Days { get; internal set; }
        public double Price { get; internal set; }
    }
}
