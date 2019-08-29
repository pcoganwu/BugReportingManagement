using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class Testers
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Project Name")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Display(Name = "Project Name")]
        public Projects Project { get; set; }
        public ICollection<Locations> Locations { get; set; }
    }
}
