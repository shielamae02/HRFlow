﻿using System.ComponentModel.DataAnnotations;

namespace HRIS.Dtos
{
    public class ForgotPasswordDto
    {
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(150, ErrorMessage = "Email Address must be between {2} and {1} characters long.", MinimumLength = 3)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name input is required.")]
        [StringLength(100, ErrorMessage = "First Name must be between {2} and {1} characters long.", MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;
    }
}
