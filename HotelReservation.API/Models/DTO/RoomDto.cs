namespace HotelReservation.API.Models.DTO
{
    public class RoomDto
    {
        public int RoomId { get; private set; }
        public int RoomTypeID { get; set; }
        internal RoomTypeDto RoomType { get; set; }
        public int RoomNumber { get; set; }
        public bool Reserved { get; set; }
    }
}
