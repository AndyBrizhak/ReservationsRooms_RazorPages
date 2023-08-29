using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Models;

namespace Reservations.Pages
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public Room Room { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }


        public void OnGet(int Id)
        {
            var roomIndex=Id-1;
                Room = SD.Rooms[roomIndex];
            
        }

        public IActionResult OnPost()
        {
            var roomIndex = Id - 1;
            SD.Rooms[roomIndex].Status = Status;
            return RedirectToPage("Rooms");
        }
    }
}
