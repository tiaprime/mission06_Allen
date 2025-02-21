
using System.ComponentModel.DataAnnotations;


namespace mission06_Allen.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
