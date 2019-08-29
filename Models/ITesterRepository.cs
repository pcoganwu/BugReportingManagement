using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public interface ITesterRepository
    {
        Testers GetTester(int? Id);
        IEnumerable<Testers> GetAllTester();
        Testers Add(Testers tester);
        Testers Update(Testers testerChanges);
        Testers Delete(int? Id);

    }
}
