using System.ComponentModel.DataAnnotations;

namespace mission06_Allen.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }
    }
}
