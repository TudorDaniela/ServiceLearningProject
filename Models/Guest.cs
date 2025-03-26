using System.ComponentModel.DataAnnotations;

namespace ServiceLearningProject.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }  // This must be present!

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
