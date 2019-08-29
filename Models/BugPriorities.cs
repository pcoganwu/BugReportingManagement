using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugReportingManagement.Models
{
    public class BugPriorities
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Priority")]
        public string BugPriorityType { get; set; }
        //public ICollection<Bugs> Bugs  { get; set; }
    }
}