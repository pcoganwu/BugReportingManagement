using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "This field is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Phone")]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
    }
}
