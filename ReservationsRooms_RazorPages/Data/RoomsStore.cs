using Reservations.Models;

namespace Reservations.Data
{
    public static class RoomsStore
    {
        public static readonly List<Room> ListRooms;

        static RoomsStore()
        {
            for (var i = 1; i <= 20; i++)
            {
                var room = new Room();
                room.Id = i;
                room.State = SD.Renovation;
                ListRooms.Add(room);
            }
        }
    }
}
