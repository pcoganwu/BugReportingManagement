using BugReportingManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.ViewModels
{
    public class BugsCreateViewModel
    {
        [Display(Name = "Client Name")]
        public int ProjectId { get; set; }
        [Display(Name = "Priority")]
        public int BugPriorityId { get; set; }
        [Display(Name = "Status")]
        public int BugStatusId { get; set; }
        [Required(ErrorMessage = "This is a required Field"), Display(Name = "Created By")]
        public string BugCreatedBy { get; set; }
        [Required(ErrorMessage = "This is a required Field"), Display(Name = "Created On"), DataType(DataType.Date)]
        public DateTime BugCreatedOn { get; set; }
        [Required(ErrorMessage = "This is a required Field"), Display(Name = "Closed By")]
        public string BugClosedBy { get; set; }
        [Required(ErrorMessage = "This is a required Field"), Display(Name = "Closed On"), DataType(DataType.Date)]
        public DateTime BugClosedOn { get; set; }
        [Required(ErrorMessage = "This is a required Field"), Display(Name = "Detailed Bug Comment"), MaxLength(500)]
        public string BugResolutionSummary { get; set; }
        [Display(Name = "Attach Document")]
        public IFormFile Document { get; set; } //To save multiple files change IFormFile to List of IFormFile
        [Display(Name = "Priority")]
        public BugPriorities BugPriority { get; set; }
        [Display(Name = "Status")]
        public BugStatuses BugStatus { get; set; }
        [Display(Name = "Project Name")]
        public Projects Project { get; set; }
    }
}
