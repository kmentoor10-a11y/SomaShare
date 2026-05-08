using SomaShare.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomaShare.Models
{
    public class Offer
    {
        [Key]
        public int OfferID
        {
            get; set;
        }

        public decimal Amount
        {
            get; set;
        }

        public string Status
        {
            get; set;
        } = "Pending";

        // Who made the offer (Buyer)
        public string UserID
        {
            get; set;
        }

        [ForeignKey("UserID")]
        public ApplicationUser User
        {
            get; set;
        }

        //Which textbook is the offer for
        public int TextbookID
        {
            get; set;
        }

        [ForeignKey("TextbookID")]
        public Textbook Textbook
        {
            get; set;
        }
    }
}
