using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public interface IProjectRepository
    {
        Projects GetProject(int? Id);
        IEnumerable<Projects> GetAllProjects();
        Projects Add(Projects project);
        Projects Update(Projects projectChanges);
        Projects Delete(int? Id);
    }
}
