using System.ComponentModel.DataAnnotations;

namespace HotelReservation.API.Models
{
    public class Room
    {                
        [Key]
        public int RoomId { get; private set; }
        public int RoomTypeID { get; set; }
        internal RoomType RoomType { get; set; }
        public int RoomNumber { get; set; }
        public bool Reserved { get; set; }
    }
}
