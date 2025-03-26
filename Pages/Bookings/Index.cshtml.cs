using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLearningProject.Data;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Bookings
{
    public class BookingsModel : PageModel
    {
        private readonly HotelDbContext _context;
        public BookingsModel(HotelDbContext context)
        {
            _context = context;
        }

        public List<Booking> Bookings { get; set; }

        public void OnGet()
        {
            Bookings = _context.Bookings.AsNoTracking().ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
            return RedirectToPage();
        }
    }

    public class CreateBookingModel : PageModel
    {
        private readonly HotelDbContext _context;
        public CreateBookingModel(HotelDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Bookings.Add(Booking);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }

    public class EditBookingModel : PageModel
    {
        private readonly HotelDbContext _context;
        public EditBookingModel(HotelDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; }

        public IActionResult OnGet(int id)
        {
            Booking = _context.Bookings.Find(id);
            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(Booking).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
