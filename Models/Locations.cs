using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class Locations
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Tester")]
        public int TesterId { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Location")]
        public string Name { get; set; }
        [Display(Name = "Tester")]
        public Testers Tester { get; set; }
    }
}
