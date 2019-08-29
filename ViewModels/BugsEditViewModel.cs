using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.ViewModels
{
    public class BugsEditViewModel : BugsCreateViewModel
    {
        public int Id { get; set; }
        public string ExistingDocument { get; set; }
    }
}
