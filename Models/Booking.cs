using System.ComponentModel.DataAnnotations;

namespace ServiceLearningProject.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }  // This must be present!

        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
