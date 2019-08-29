using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class SQLBugPriorityRepository : IBugPriorityRepository
    {
        private readonly AppDbContext _context;
        public SQLBugPriorityRepository(AppDbContext context)
        {
            _context = context;
        }
        public BugPriorities Add(BugPriorities bugPriority)
        {
            _context.BugPriorities.Add(bugPriority);
            _context.SaveChanges();
            return bugPriority;
        }

        public BugPriorities Delete(int? Id)
        {
            BugPriorities bugPriority = _context.BugPriorities.Find(Id);
            if (bugPriority != null)
            {
                _context.BugPriorities.Remove(bugPriority);
                _context.SaveChanges();
            }
            return bugPriority;
        }

        public IEnumerable<BugPriorities> GetAllBugPriorities()
        {
            return _context.BugPriorities;
        }

        public BugPriorities GetBugPriority(int? Id)
        {
            return _context.BugPriorities.Find(Id);
        }

        public BugPriorities Update(BugPriorities bugPriorityChanges)
        {
            var bugPriority = _context.BugPriorities.Attach(bugPriorityChanges);
            bugPriority.State = EntityState.Modified;
            _context.SaveChanges();
            return bugPriorityChanges;
        }
    }
}
