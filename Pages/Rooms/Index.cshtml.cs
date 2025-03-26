using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Rooms
{
    public class RoomsModel : PageModel
    {
        public List<Room> Rooms { get; set; }

        public void OnGet()
        {
            Rooms = HotelData.GetRooms();
        }
    }
}
