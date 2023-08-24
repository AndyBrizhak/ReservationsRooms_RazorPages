using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Models;

namespace Reservations.Pages
{
    [BindProperties]
    public class RoomsModel : PageModel
    {
        public List<Room> Rooms { get; set; }

        public void OnGet()
        {
            Rooms = SD.Rooms;
        }
    }
}
