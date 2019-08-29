using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public interface IBugStatusRepository
    {
        BugStatuses GetBugStatus(int? Id);
        IEnumerable<BugStatuses> GetAllBugStatus();
        BugStatuses Add(BugStatuses bugStatus);
        BugStatuses Update(BugStatuses bugStatusChanges);
        BugStatuses Delete(int? Id);
    }
}
