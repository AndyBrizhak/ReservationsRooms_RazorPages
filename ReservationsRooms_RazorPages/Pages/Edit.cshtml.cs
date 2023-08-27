using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Models;

namespace Reservations.Pages
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public Room Room { get; set; }

        
        public void OnGet(int id)
        {
            
                Room = SD.Rooms[id];
            
        }

        public IActionResult OnPost(int id, string status )
        {
            
            SD.Rooms[id-1].Status = status;
            return RedirectToPage("Index");
        }
    }
}
