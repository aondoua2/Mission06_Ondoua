using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Ondoua.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Non-nullable primary key

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be greater than or equal to 1888.")]
        public int Year { get; set; } // Nullable value type

        public string? Director { get; set; }

        [Required]
        public string? Rating { get; set; }
   
        public int? Edited { get; set; } // Not required

        public string? LentTo { get; set; } // Not required

        public int? CopiedToPlex { get; set; }
        public string? Notes { get; set; } // Not required
    }
}
