using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission06_Allen.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }


        [Required(ErrorMessage = "You must enter a Title.")]
        public string Title { get; set; }
        
        // lower limit of 1888
        [Range(1888, 50000000, ErrorMessage = "Enter a Year of 1888 or greater.")]
        public int? Year { get; set; } = 0;
        public string? Director { get; set; }

        public string? Rating { get; set; }
        [Required]
        public bool? Edited { get; set; }

        public string? LentTo { get; set; }
        [Required]
        public string CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
