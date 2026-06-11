using System.ComponentModel.DataAnnotations;

namespace SomaShare.Models

{
    public class WantedAd
    {
        [Key]
        public int WantedAD { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Budget { get; set; }

        public string UserID { get; set; }
    }
}
