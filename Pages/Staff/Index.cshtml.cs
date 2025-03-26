using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLearningProject.Models;

namespace ServiceLearningProject.Pages.Staff
{
    public class StaffModel : PageModel
    {
        public List<StaffPersonel> StaffList { get; set; }

        public void OnGet()
        {
            StaffList = HotelData.GetStaff();
        }
    }
}
