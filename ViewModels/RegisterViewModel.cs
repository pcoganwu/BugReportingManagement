using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "This field is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Phone")]
        [RegularExpression("\\(?\\d{3}\\)?[-\\.]? *\\d{3}[-\\.]? *[-\\.]?\\d{4}", ErrorMessage = "Invalid Phone Format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This is a required field"), Display(Name = "Company")]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$", ErrorMessage = "Invalid Email Format")]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = " Confirm Password"), DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}
