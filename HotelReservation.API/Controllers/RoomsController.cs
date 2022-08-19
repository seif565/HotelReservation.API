using HotelReservation.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly HotelDBContext _context;

        public RoomsController(HotelDBContext context)
        {
            _context = context;
        }

        //GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            if (_context.Rooms == null)
            {
                return NotFound();
            }
            return await _context.Rooms.ToListAsync();
        }
        [HttpGet("Date")]
        public async Task<ActionResult<IEnumerable<Room>>> GetRosoms(DateTime date)
        {
            if (_context.Rooms == null)
            {
                return NotFound();
            }
            var rooms = _context.Reservations.Where(x=>x.ReservationEnd> date && x.ReservationStart < date).ToList();            
            return Ok(rooms);
        }
        [HttpGet("Available")]
        public async Task<ActionResult<IEnumerable<Room>>> GetAvailableRooms()
        {
            if (_context.Rooms == null)
            {
                return NotFound();
            }
            return await _context.Rooms.Where(x => x.Reserved == false).ToListAsync();
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            if (_context.Rooms == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms.FindAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }


        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.RoomId)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            if (_context.Rooms == null)
            {
                return Problem("Entity set 'HotelDBContext.Rooms'  is null.");
            }
            RoomType designatedRoomType = _context.RoomType.Find(room.RoomTypeID);
            room.RoomType = designatedRoomType;
            room.RoomType.PricePerDay = room.RoomType.roomPrice[room.RoomType.RoomKind.ToUpper()];
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoom", new { id = room.RoomId }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            if (_context.Rooms == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoomExists(int id)
        {
            return (_context.Rooms?.Any(e => e.RoomId == id)).GetValueOrDefault();
        }
    }
}
