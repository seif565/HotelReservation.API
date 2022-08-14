using System.Web.Http;
using System.Linq;
namespace HotelReservation.API.Models
{
    public class Reservation
    {
        private Guid id;
        private int days;
        public Guid Id { get { return id; } private set { id = Guid.NewGuid(); } }
        public string Name { get; set; }        

        public Room Room { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }        
        // Days Are accurately calculated but can still be edited by end user.
        public double Days {  set { days = ReservationEnd.Subtract(ReservationStart).Days; } get { return days; } }
        private double price;
        public double Price { get { return price; } set { price = Days * Room.RoomType.PricePerDay; } }

        public double SetPrice(RoomType roomType)
        {
            if(!roomType.roomPrice.ContainsKey(roomType.RoomKind))
            {
                throw new ArgumentException("value not found in dictionary");
            }
            return price * roomType.roomPrice[roomType.RoomKind];
        }
        
        //private void SetDays()
        //{

        //}
        //public int SetDays()
        //{
        //    return (ReservationEnd - ReservationStart).Days;
        //}
        
    }
}
