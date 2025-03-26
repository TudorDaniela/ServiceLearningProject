using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLearningProject.Data;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Dashboard
{
    public class DashboardModel : PageModel
    {
        private readonly HotelDbContext _context;
        public DashboardModel(HotelDbContext context)
        {
            _context = context;
        }
        public List<Booking> Bookings { get; set; }
        public List<Guest> Guests { get; set; }
        public List<Room> Rooms { get; set; }
        public List<StaffPersonel> StaffList { get; set; }

        public int AvailableRooms => Rooms.Count(r => r.IsAvailable);
        public int OccupiedRooms => Rooms.Count(r => !r.IsAvailable);


        public void OnGet()
        {
            Bookings = _context.Bookings.AsNoTracking().ToList();
            Guests = _context.Guests.AsNoTracking().ToList();
            Rooms = _context.Rooms.AsNoTracking().ToList();
            StaffList = _context.Staff.AsNoTracking().ToList();
        }
    }
}
