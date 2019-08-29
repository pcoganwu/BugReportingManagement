using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public interface IBugRepository
    {
        Bugs GetBugs(int? Id);
        IEnumerable<Bugs> GetAllBugs();
        Bugs Add(Bugs bug);
        Bugs Update(Bugs bugChanges);
        Bugs Delete(int? Id);
    }
}
