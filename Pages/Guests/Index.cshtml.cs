using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLearningProject.Data;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Guests
{
    public class GuestsModel : PageModel
    {
        private readonly HotelDbContext _context;
        public GuestsModel(HotelDbContext context)
        {
            _context = context;
        }

        public List<Guest> Guests { get; set; }

        public void OnGet()
        {
            Guests = _context.Guests.AsNoTracking().ToList();
        }
    }
}
