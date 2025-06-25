using System.ComponentModel.DataAnnotations;

namespace BugTrackerMvc.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title {  get; set; }
        
        public string Description { get; set; }

        [Required]
        public string Severity { get; set; }

        [Required]
        public string Status { get; set; } = "Open";

        public DateTime CreatedAt { get; set; }
    }
}
