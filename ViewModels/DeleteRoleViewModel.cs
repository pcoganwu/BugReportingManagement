using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.ViewModels
{
    public class DeleteRoleViewModel
    {
        public DeleteRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        [Required(ErrorMessage = "Role Name is required"), Display(Name = "Role Name")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
