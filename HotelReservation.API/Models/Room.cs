using Microsoft.EntityFrameworkCore;

namespace HotelReservation.API.Models
{
    public class Room
    {        
        public int RoomId { get; private set; }  
        private RoomType roomType;
        public RoomType RoomType { get; set; }
        public int RoomNumber { get; set; }
        public bool Reserved { get; set; }           
    }
}
