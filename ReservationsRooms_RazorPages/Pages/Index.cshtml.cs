using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations;
using Reservations.Data;
using Reservations.Models;
using System.Dynamic;

namespace ReservationsRooms_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public List<Room> Rooms { get; set; } = new List<Room>();
              
        public  IActionResult OnGet()
        {
            Rooms=SD.Rooms;
            return Content("Test"); 

        }

        public void OnPut(int id, string status)
        {
            try
            {
                var room = Rooms.FirstOrDefault(r => r.Id == id);
                room.Status = status;
            }
            catch
            {
                //Exception ex;
                _logger.Log(
                    LogLevel.Warning,
                    "Not valid Id");

            }



        }
    }



}