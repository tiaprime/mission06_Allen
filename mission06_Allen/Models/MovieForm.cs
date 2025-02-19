using System.ComponentModel.DataAnnotations;

namespace mission06_Allen.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        //public string? Category { get; set; }
        public string? CategoryId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }
        public string? Director { get; set; }

        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }
        [Required]
        public string CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
