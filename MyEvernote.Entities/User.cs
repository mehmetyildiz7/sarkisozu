using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entities
{
    [Table("Users")]
    public class User
    {
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [DisplayName("E-Posta")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Yönetici")]
        public bool IsAdmin { get; set; }
    }
}