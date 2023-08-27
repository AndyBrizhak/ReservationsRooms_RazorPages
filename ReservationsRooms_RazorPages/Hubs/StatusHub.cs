using Microsoft.AspNetCore.SignalR;

namespace Reservations.Hubs
{
	public class StatusHub: Hub
	{
		public int RoomId { get; set; }
        public string StatusRoom { get; set; }

		public async	Task	NewStatusRoomLoaded(int id,	string status)
		{
			SD.Rooms[id].Status=status;
			//send update client, that status room have been updated
			await Clients.Caller.SendAsync("updateStatusRoom", id, status);
		}
    }
}
