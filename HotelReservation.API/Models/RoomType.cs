using System.ComponentModel.DataAnnotations;

namespace HotelReservation.API.Models
{
    public class RoomType
    {
        [Key]
        public Guid TypeId{ get; set; }
        public double PricePerDay { get; set; }
        public int RoomNumber { get; set; }

        public readonly Dictionary<Guid, double> roomPrice = new();
    }
}
