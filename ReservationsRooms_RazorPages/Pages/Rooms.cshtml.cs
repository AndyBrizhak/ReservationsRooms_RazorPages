using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Models;

namespace Reservations.Pages
{
    [BindProperties]
    public class RoomsModel : PageModel
    {
        public List<Room> Rooms { get; set; }
		//public  Room Room { get; set; }
		public int? Id { get; /*private*/ set; }
        public string? Status { get; /*private*/ set; }

		public void OnGet()
        {
            Rooms = SD.Rooms;
        }

        //public  IActionResult OnPut(int roomId)
        //{
        //    if (roomId<1) return BadRequest("Invalid Id");
        //    var room= SD.Rooms[roomId];
        //    return RedirectToAction("Rooms");
        //}
       
        public IActionResult OnPost(int id, string status) 
        {
            Status = status;
            Id = id;
           Rooms[id].Status = status;
			return RedirectToAction("Rooms");
		}
    }
}
