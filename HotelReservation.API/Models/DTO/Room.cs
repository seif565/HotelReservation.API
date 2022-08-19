namespace HotelReservation.API.Models.DTO
{
    public class Room
    {
        public int RoomId { get; private set; }
        public int RoomTypeID { get; set; }
        internal RoomType RoomType { get; set; }
        public int RoomNumber { get; set; }
        public bool Reserved { get; set; }
    }
}
