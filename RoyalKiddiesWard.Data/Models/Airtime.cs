using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace RoyalKiddiesWard.Data.Models
{
    [Table ("Transaction")]
    public class Airtime

    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength (3)]
        public decimal Amount { get; set; }
        [Required]
        [MaxLength (11)]
        public string PhoneNumber { get; set; }
        [Required]
        public int Network { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionStatus { get; set; }
        public bool IsSuccessful => TransactionStatus.Equals(1);
        public decimal AvailableBalance { get; set; }
        public decimal AccountBalance { get; set; }
        public int TransactionPin { get; set; }



    }
    
}
