using HotelReservation.API.Models;

namespace HotelReservation.API.Repositories
{
    public interface IRoomRepository
    {
        public IEnumerable<Room> GetAll();
    }
}
