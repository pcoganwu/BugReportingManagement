using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.ViewModels
{
    public class DeleteUserViewModel
    {

        public DeleteUserViewModel()
        {
            Claims = new List<string>(); Roles = new List<string>();
        }

        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Phone")]
        [RegularExpression("\\(?\\d{3}\\)?[-\\.]? *\\d{3}[-\\.]? *[-\\.]?\\d{4}", ErrorMessage = "Invalid Phone Format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Email Address")]
        [RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$", ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        public List<string> Claims { get; set; }
        public IList<string> Roles { get; set; }
    }
}
