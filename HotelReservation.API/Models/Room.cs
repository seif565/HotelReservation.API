namespace HotelReservation.API.Models
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string type { get; set; }
        public double PricePerDay { get; set; }
        public bool Reserved { get; set; }
    }
}
