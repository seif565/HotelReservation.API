using System.Web.Http;
using System.Linq;
namespace HotelReservation.API.Models
{
    public class Reservation
    {
        private Guid id;
        private int days;
        public Guid Id { get { return id; } internal set { id = Guid.NewGuid(); } }
        public string Name { get; set; }        

        public int RoomId { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }        
        // Days Are accurately calculated but can still be edited by end user.
        public double Days { get; internal set; }        
        public double Price { get; internal set; }        
        //private void SetDays()
        //{

        //}
        //public int SetDays()
        //{
        //    return (ReservationEnd - ReservationStart).Days;
        //}
        
    }
}
