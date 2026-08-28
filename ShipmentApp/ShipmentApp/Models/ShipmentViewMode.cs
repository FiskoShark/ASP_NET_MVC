using System.ComponentModel.DataAnnotations;

namespace ShipmentApp.Models
{
    public class ShipmentViewModel
    {
        [Required]
        public string RecipientName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string ProductName { get; set; }
    }
}