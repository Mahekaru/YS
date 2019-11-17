using System.ComponentModel.DataAnnotations;

namespace YardSale.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}