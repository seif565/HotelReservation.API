using System.ComponentModel.DataAnnotations;

namespace HotelReservation.API.Models
{
    public class RoomType
    {
        [Key]
        public int TypeId { get; private set; }        
        public double PricePerDay { get; internal set; }
        public string RoomKind { get; set; }
        public readonly Dictionary<string, double> roomPrice = new()
        {
            { "Superior Room", 100 },
            { "Suite", 200 },
            { "Family Room", 300 },
            { "villa", 400 }
        };
    }
}
