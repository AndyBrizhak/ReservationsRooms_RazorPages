using Microsoft.AspNetCore.SignalR;
using Reservations.Models;

namespace Reservations.Hubs
{
	public class StatusHub: Hub
	{
		//public int RoomId { get; set; }
		//public string? StatusRoom { get; set; }
		//public string? BtnStatusId { get; set; }

		//public async Task NewStatusRoom(int idRoom, string newStatus)
		//      {
		//	//SD.Rooms[(idRoom-1)].Status = newStatus;
		//	//SD.Rooms[(idRoom-1)].BtnStatusId = newStatus;
		//	//RoomId = idRoom;
		//	//StatusRoom = newStatus;
		//	//BtnStatusId = $"{newStatus}{idRoom}";

		//	//send update all client, that status room have been updated
		//	//await Clients.All.SendAsync("changeStatus", /*StatusRoom, RoomId,*/ BtnStatusId);
		//          await Clients.All.SendAsync("updateRoomOnIndex", newStatus, idRoom);

		//      }

		public async Task<bool> StatusRoom(int id, string status)
		{
			await Clients.All.SendAsync("updateRoomOnIndex", status, id);
			return true;
		}
	}
}
