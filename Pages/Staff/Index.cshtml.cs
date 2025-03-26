using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLearningProject.Data;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Staff
{
    public class StaffModel : PageModel
    {
        private readonly HotelDbContext _context;
        public StaffModel(HotelDbContext context)
        {
            _context = context;
        }

        public List<StaffPersonel> StaffList { get; set; }

        public void OnGet()
        {
            StaffList = _context.Staff.AsNoTracking().ToList();
        }
    }
}
