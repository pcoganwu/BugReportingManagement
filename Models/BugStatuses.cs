using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugReportingManagement.Models
{
    public class BugStatuses
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required"), Display(Name = "Status")]
        public string BugStatusType { get; set; }
        //public ICollection<Bugs> Bugs { get; set; }
    }
}