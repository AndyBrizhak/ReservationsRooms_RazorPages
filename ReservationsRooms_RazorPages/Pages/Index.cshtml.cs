using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reservations;
using Reservations.Data;
using Reservations.Models;
using System.Dynamic;

namespace ReservationsRooms_RazorPages.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //[BindProperty]
        public List<Room> Rooms { get; set; }

        public IndexModel(ILogger<IndexModel> logger )
        {
            _logger = logger;

        }


        //public List<Room> Rooms { get; set; } = new List<Room>();

        public   void OnGet()
        {
            Rooms=SD.Rooms;
            //return RedirectToPage("Index"); 

        }

        //public IActionResult OnPost(Room room)
        //{
        //    Rooms.Add(room);
        //    return  RedirectToPage("Index");
        //}

        //public void OnPut(int id, string status)
        //{
        //    try
        //    {
        //        var room = Rooms.FirstOrDefault(r => r.Id == id);
        //        room.Status = status;
        //    }
        //    catch
        //    {
        //        //Exception ex;
        //        _logger.Log(
        //            LogLevel.Warning,
        //            "Not valid Id");

        //    }



        //}
    }



}