using RoyalKiddiesWard.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RoyalKiddiesWard.API.ViewModels
{
    public class GetAirtime
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public decimal Amount { get; set; }
        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        public int Network { get; set; }
        [Required]
        [JsonPropertyName("Transaction Pin")]
        public int TransactionPin { get; set; }
    }
}
