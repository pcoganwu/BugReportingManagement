using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class ProjectAdmins
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "First Name") ]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Password"), DataType(DataType.Password)]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Confirm Password"), DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}
