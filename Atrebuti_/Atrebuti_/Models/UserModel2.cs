using System.ComponentModel.DataAnnotations;

namespace Atrebuti_.Models
{
    public class UserModel2
    {
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string name { get; set; }

        [Required(ErrorMessage = "Email потрібно ввести")]
        [EmailAddress]
        public string email { get; set; }

        [Range(1, 100)]
        public int age { get; set; }

        [Phone]
        public string phone { get; set; }
    }
}