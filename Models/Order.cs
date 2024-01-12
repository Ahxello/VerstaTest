using System.ComponentModel.DataAnnotations;
using System.Data;

namespace VerstaTest.Models
{
    public class Order
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public string SenderCity { get; set; }
        [Required]
        public string SenderAddress { get; set;}
        [Required]
        public string RecipientCity { get; set; }
        [Required]
        public string RecipientAddress { get; set;}
        [Required]
        public int Weight { get; set; }
        [Required]
        public DateTime DateOfPickup { get; set; }
    }
}
