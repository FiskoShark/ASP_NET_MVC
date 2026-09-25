using System.ComponentModel.DataAnnotations;
namespace Atrebuti_.Models
{
    public class UserModel
    {

        [Key] public int id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "email need to be entered")]
        public string email { get; set; }

        [Phone] public int phone { get; set; }

        [Url] public string url { get; set; }

        [Range(1, 100)] public int age { get; set; }

        public string password { get; set; }

        [Compare(nameof(password))] public string confirmPassword { get; set; }

        [RegularExpression(@"^[A-Z]+$")]
        public string line { get; set; }


    }
}



