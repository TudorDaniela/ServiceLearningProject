using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Bookings
{
    public class BookingsModel : PageModel
    {
        public List<Booking> Bookings { get; set; }

        public void OnGet()
        {
            Bookings = HotelData.GetBookings();
        }
    }
}
