using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace ETicaret2.Models
{
    public class Register
    {

        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Geçerli Eposta Adres,..")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifre")]

        public string Password { get; set; }

        [Required]
        [DisplayName("Şifre Tekrar")]
        public string RePassword { get; set; }

    }
}