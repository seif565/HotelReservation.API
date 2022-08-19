namespace HotelReservation.API.Models.DTO
{
    public class GetRoomsDTO
    {
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }

        public bool? avaliable { get; set; }
    }
}
