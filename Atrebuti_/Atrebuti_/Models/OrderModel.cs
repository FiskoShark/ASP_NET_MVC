using System.ComponentModel.DataAnnotations;

namespace Atrebuti_.Models
{
    public class OrderModel
    {
        [Key] public int id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string title { get; set; }

        public string description { get; set; }

        [Range(1, 10000)] public decimal price { get; set; }

        [Range(1, 100)] public int quantity { get; set; }

        public decimal totalPrice
        {
            get { return price * quantity; }
        }
    }
}

