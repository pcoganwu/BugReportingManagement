using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class SQLBugsRepository : IBugRepository
    {
        //Inject DBContext class
        private readonly AppDbContext _context;
        public SQLBugsRepository(AppDbContext context)
        {
            _context = context;
        }

        public Bugs Add(Bugs bug)
        {
            _context.Bugs.Add(bug);
            _context.SaveChanges();
            return bug;
        }

        public Bugs Delete(int? Id)
        {
            Bugs bug = _context.Bugs.Find(Id); //find the bug and stored in a variable bug
            if(bug != null) //if bug we wnat to delete is found
            {
                _context.Bugs.Remove(bug);
                _context.SaveChanges(); //save changes in the database
            }
            return bug;
        }

        public IEnumerable<Bugs> GetAllBugs()
        {
            return _context.Bugs.Include(a => a.BugStatus).Include(b => b.BugPriority).Include(b => b.Project); //returns all bugs

        }

        public Bugs GetBugs(int? Id)
        {
            Bugs bug = _context.Bugs.Include(b => b.BugStatus).Include(b => b.BugPriority).Include(b => b.Project).FirstOrDefault(u => u.Id == Id);
            return bug;
        }

        public Bugs Update(Bugs bugChanges)
        {
            var bug = _context.Bugs.Attach(bugChanges); //Attach the Bugs object that has the changes to the Bugs property.
            bug.State = EntityState.Modified; //Tell EF that object the was return is modified
            _context.SaveChanges();//Update in the database
            return bugChanges;
        }
    }
}
