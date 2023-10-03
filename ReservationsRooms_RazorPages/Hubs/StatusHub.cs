using Microsoft.AspNetCore.SignalR;
using Reservations.Models;

namespace Reservations.Hubs
{
	public class StatusHub: Hub
	{

		//send update all client, that status room have been updated
		public async Task<bool> StatusRoom(string name, string status)
		{
			await Clients.All.SendAsync("updateRoomOnIndex", name, status);
			return true;
		}
	}
}
