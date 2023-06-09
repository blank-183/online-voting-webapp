﻿using OnlineVotingWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineVotingWebApp.ViewModels
{
    public class AddCandidateViewModel
    {
        [Required]
        [Display(Name = "Candidate Position")]
        public int CandidatePositionId { get; set;}

        [Display(Name = "First Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'-\s]*$", ErrorMessage = "Dashes, lowercase and uppercase letters only")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Middle Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "Uppercase and lowercase letters only")]
        public string? MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]*$", ErrorMessage = "Uppercase and lowercase letters only")]
        public string LastName { get; set; } = null!;

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'-\s]*$", ErrorMessage = "Dashes, lowercase and uppercase letters only")]
        public string Party { get; set; } = null!;

        public IFormFile? Photo { get; set; }

    }
}
