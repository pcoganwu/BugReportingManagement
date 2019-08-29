using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class SQLBugStatusRepository : IBugStatusRepository
    {
        private readonly AppDbContext _context;

        public SQLBugStatusRepository(AppDbContext context)
        {
            _context = context;
        }
        public BugStatuses Add(BugStatuses bugStatus)
        {
            _context.BugStatuses.Add(bugStatus);
            _context.SaveChanges();
            return bugStatus;
        }

        public BugStatuses Delete(int? Id)
        {
           BugStatuses bugStatuse = _context.BugStatuses.Find(Id);
            if (bugStatuse != null)
            {
                _context.BugStatuses.Remove(bugStatuse);
                _context.SaveChanges();
            }
            return bugStatuse;
        }

        public IEnumerable<BugStatuses> GetAllBugStatus()
        {
            return _context.BugStatuses;
        }

        public BugStatuses GetBugStatus(int? Id)
        {
            return _context.BugStatuses.Find(Id);
        }

        public BugStatuses Update(BugStatuses bugStatusChanges)
        {
            var bugStatus = _context.BugStatuses.Attach(bugStatusChanges);
            bugStatus.State = EntityState.Modified;
            _context.SaveChanges();
            return bugStatusChanges;
        }
    }
}
