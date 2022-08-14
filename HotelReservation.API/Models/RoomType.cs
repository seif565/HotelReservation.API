using System.ComponentModel.DataAnnotations;

namespace HotelReservation.API.Models
{
    public class RoomType
    {
        [Key]
        public int TypeId{ get; set; }
        public double PricePerDay { get; set; }
        public string RoomKind{ get; set; }
        public int RoomNumber { get; set; }
        public readonly Dictionary<string, double> roomPrice = new() 
        { 
            { "Superior Room", 100},
            { "Suite",200},
            { "Family Room", 300},
            {"villa", 400} 
        };        
    }
}
