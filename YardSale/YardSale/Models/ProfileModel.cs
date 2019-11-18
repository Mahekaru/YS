using System.ComponentModel.DataAnnotations;

namespace YardSale.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        public int? Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required(ErrorMessage = "Zip is required")]
        public int Zipcode { get; set; }
    }
}