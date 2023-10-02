using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Hubs;
using Reservations.Models;
using Microsoft.AspNetCore.SignalR;

namespace Reservations.Pages
{
    [BindProperties]
    public class RoomsModel : PageModel
    {
        public List<Room> Rooms { get; set; }
        public StatusHub Hub { get; set;}        
        public void OnGet()
        {
            Rooms = SD.Rooms;
        }

		public IActionResult OnPost(int id, string status)
		{
            
            //var roomIndex = CurrentId - 1;
            SD.Rooms[(id-1)].Status = status;
			//var result = Hub.StatusRoom(id, status).GetAwaiter().GetResult();
   //         if (!result)
   //         {
   //             return BadRequest("Can`t change status room");
   //         }
		    return RedirectToPage("Rooms");
        }
	}
}
