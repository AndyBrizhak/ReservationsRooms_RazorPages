using Reservations.Models;

namespace Reservations.Data
{
    public static class InitStatus
    {
        public static readonly List <Room> RoomsStatic;
        static InitStatus()
        {
            RoomsStatic = new List <Room> ();
            for (var i = 1; i <= 20; i++)
            {
                var room = new Room ();
                room.Id = i;
                room.Name = i.ToString ();
                room.Status = SD.Renovation;
            }
          }

    }
}
