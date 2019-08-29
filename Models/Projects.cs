using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class Projects
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Project Client")]
        public string Name { get; set; }
        [Display(Name = "Project Description")]
        public string  Description { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Modified On"), DataType(DataType.Date)]
        public DateTime ModifiedOn { get; set; }
        //public ICollection<Bugs> Bugs { get; set; }
        public ICollection<Testers> Testers { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
