using Microsoft.AspNetCore.SignalR;

namespace Reservations.Hubs
{
	public class StatusHub: Hub
	{
		//public int RoomId { get; set; }
		//      public string StatusRoom { get; set; }

		public async Task NewStatusRoomLoaded(/*int id,*/ /*string currentStatus,*/
											  /*string newStatus*/ string idstatus)
		{
			//string[] subs = idstatus.Split(":");
			int id = Convert.ToInt32(idstatus.Split(":")[0]);
			string status = idstatus.Split(":")[1];
			SD.Rooms[id].Status = status;

			//send update client, that status room have been updated
			await Clients.Caller.SendAsync("changeStatus", idstatus);
		}
    }
}
