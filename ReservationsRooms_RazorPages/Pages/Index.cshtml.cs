using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations.Data;
using Reservations.Models;

namespace ReservationsRooms_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        
        public void OnGet()
        {
            var allState = InitStatus.RoomsStatic;
        }
    }
}