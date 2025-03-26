using System.ComponentModel.DataAnnotations;

namespace ServiceLearningProject.Models
{

    public class StaffPersonel
    {
        [Key]
        public int Id { get; set; }  // This must be present!

        public string Name { get; set; }
        public string Position { get; set; }
        public string Contact { get; set; }
    }
}
