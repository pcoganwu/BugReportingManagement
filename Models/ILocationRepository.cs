using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public interface ILocationRepository
    {
        Locations GetLocation(int? Id);
        IEnumerable<Locations> GetAllBugLocations();
        Locations Add(Locations location);
        Locations Update(Locations locationChanges);
        Locations Delete(int? Id);
    }
}
