using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ETicaret2.Models
{

    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
        [Required]

        [DisplayName("Şifre")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
