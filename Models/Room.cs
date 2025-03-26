using System.ComponentModel.DataAnnotations;

namespace ServiceLearningProject.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }  // This must be present!

        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public bool IsAvailable { get; set; }
    }
}
