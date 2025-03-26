using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLearningProject.Data;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Rooms
{
    public class RoomsModel : PageModel
    {
        private readonly HotelDbContext _context;
        public RoomsModel(HotelDbContext context)
        {
            _context = context;
        }

        public List<Room> Rooms { get; set; }

        public void OnGet()
        {
            Rooms = _context.Rooms.AsNoTracking().ToList();
        }
    }
}
