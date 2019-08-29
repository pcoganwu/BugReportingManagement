using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public interface IBugPriorityRepository
    {
        BugPriorities GetBugPriority(int? Id);
        IEnumerable<BugPriorities> GetAllBugPriorities();
        BugPriorities Add(BugPriorities bugPriority);
        BugPriorities Update(BugPriorities bugPriorityChanges);
        BugPriorities Delete(int? Id);
    }
}
