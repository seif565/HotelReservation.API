namespace HotelReservation.API.Models
{
    public class Reservation
    {
        private Guid id;
        private int days;
        public Guid Id { get { return id; } private set { id = Guid.NewGuid(); } }
        public string Name { get; set; }        
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }        
        // Days Are accurately calculated but can still be edited by end user.
        public int Days {  set { days = ReservationEnd.Subtract(ReservationStart).Days; } get { return days; } }
        private int price;
        public double Price { get { return price; } set { price = Days * 5; } }

        
        //private void SetDays()
        //{

        //}
        //public int SetDays()
        //{
        //    return (ReservationEnd - ReservationStart).Days;
        //}
        
    }
}
