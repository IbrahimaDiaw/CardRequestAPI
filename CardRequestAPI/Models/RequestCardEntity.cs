using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardRequestAPI.Models
{
    [Table("request_card")]
    public class RequestCardEntity : BaseEntity
    {
        [Required]
        public string? CustomerName { get; set; }
        [Required]
        public string? CustomerAccountNumber { get; set; }
        [Required]
        public string? CardType { get; set; }
        [Required]
        public string? DeliveryAddress { get; set; }
        [Required]
        public string? Status { get; set; }
    }
}
