using Microsoft.AspNetCore.SignalR;

namespace Reservations.Hubs
{
	public class StatusHub: Hub
	{
		public int RoomId { get; set; }
		public string StatusRoom { get; set; }

		public async Task NewStatus(int idRoom, string newStatus)
        {
			SD.Rooms[(idRoom-1)].Status = newStatus;
			RoomId = idRoom;
			StatusRoom = newStatus;

			//send update all client, that status room have been updated
			await Clients.All.SendAsync("changeStatus", StatusRoom, RoomId);
		}
    }
}
