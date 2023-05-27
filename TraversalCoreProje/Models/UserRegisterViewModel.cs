﻿using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınız Giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil.")]
        public string ConfirmPassword { get; set; }


    }
}
