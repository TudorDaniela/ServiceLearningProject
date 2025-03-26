using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Dashboard
{
    public class DashboardModel : PageModel
    {
        public List<Booking> Bookings { get; set; }
        public List<Guest> Guests { get; set; }
        public List<Room> Rooms { get; set; }
        public List<StaffPersonel> StaffList { get; set; }

        public int AvailableRooms => Rooms.Count(r => r.IsAvailable);
        public int OccupiedRooms => Rooms.Count(r => !r.IsAvailable);


        public void OnGet()
        {
            Bookings = HotelData.GetBookings();
            Guests = HotelData.GetGuests();
            Rooms = HotelData.GetRooms();
            StaffList = HotelData.GetStaff();
        }
    }
}
