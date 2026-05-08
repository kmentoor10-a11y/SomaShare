using SomaShare.Data;
using System.ComponentModel.DataAnnotations;

namespace SomaShare.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        
        public int Rating { get; set; } //1-5
        public string Comment { get; set; }
        public string ReviewerID { get; set; }
        public string ReviewedUserID { get; set; }
    }
}
