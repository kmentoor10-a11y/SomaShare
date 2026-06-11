using SomaShare.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomaShare.Models
{
    public class Textbook
    {
        [Key]
        public int TextbookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author {  get; set; }

        [Required]
        public string Module { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, 10000)]
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        //Foreign Key
        public string UserID { get; set; }

        public ApplicationUser User {  get; set; }
    }
}
