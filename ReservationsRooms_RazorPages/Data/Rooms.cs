using Reservations.Models;

namespace Reservations.Data
{
    public static class Rooms
    {
        public static readonly Dictionary <Room, string> State;

        static Rooms()
        {
            State = new Dictionary <Room, string>();
            for (int i = 1; i <= 20; i++) 
            {
                var room = new Room();  
                room.Id = i;
                  State.Add(room,"renovation");
            }
        }
    }  
        
    
}
