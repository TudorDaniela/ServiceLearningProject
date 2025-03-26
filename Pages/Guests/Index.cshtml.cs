using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Guests
{
    public class GuestsModel : PageModel
    {
        public List<Guest> Guests { get; set; }

        public void OnGet()
        {
            Guests = HotelData.GetGuests();
        }
    }
}
