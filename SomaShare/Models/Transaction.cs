using SomaShare.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomaShare.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string MeetupLocation { get; set; }

        public string Status { get; set; } = "Pending";

        //Buyer
        public string BuyerID { get; set; }

        //Seller
        public string SellerID { get; set; }

        //Textbook
        public int TextbookID { get; set; }

        [ForeignKey("TextbookID")]
        public Textbook Textbook { get; set; }
    }
}
