using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BugReportingManagement.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Phone")]
        [RegularExpression("\\(?\\d{3}\\)?[-\\.]? *\\d{3}[-\\.]? *[-\\.]?\\d{4}", ErrorMessage = "Invalid Phone Format")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Email Address")]
        [RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$", ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = " Confirm Password"), DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirmation do not match")]
        public string ConfirmPassword { get; set; }
        [DisplayName("Project Name")]
        public int ProjectId { get; set; }
        public Projects Project { get; set; }
    }
}