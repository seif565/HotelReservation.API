namespace HotelReservation.API.Models
{
    public class Room
    {        
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }
        public string RoomNumber { get; set; }                
        public bool Reserved { get; set; }
    }
}
