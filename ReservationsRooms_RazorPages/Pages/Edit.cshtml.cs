using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Models;

namespace Reservations.Pages
{
    public class EditModel : PageModel
    {
        public Room Room { get; set; }

        
        public void OnGet(int id)
        {
            if (Room != null) 
            { 
                Room    = SD.Rooms[id];
            }
        }

        public IActionResult OnPost()
        { 
            if (Room != null) 
            {
                SD.Rooms.Room[id]
            }
        }
    }
}
