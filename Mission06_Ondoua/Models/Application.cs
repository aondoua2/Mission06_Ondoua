using System.ComponentModel.DataAnnotations;

namespace Mission06_Ondoua.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Non-nullable primary key

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; } // Nullable value type

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; } // Not required

        public string? LentTo { get; set; } // Not required

        public string? Notes { get; set; } // Not required
    }
}
