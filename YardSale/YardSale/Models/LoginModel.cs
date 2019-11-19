using System.ComponentModel.DataAnnotations;

namespace YardSale.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
    }
}