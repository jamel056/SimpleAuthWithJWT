﻿using System.ComponentModel.DataAnnotations;

namespace AuthWithJWT.Authentication
{
    public class LogInModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
