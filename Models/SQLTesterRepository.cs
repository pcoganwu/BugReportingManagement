using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class SQLTesterRepository : ITesterRepository
    {
        private readonly AppDbContext _context;
        public SQLTesterRepository(AppDbContext context)
        {
            _context = context;
        }

        public Testers Add(Testers tester)
        {
            _context.Testers.Add(tester);
            _context.SaveChanges();
            return tester;
        }

        public Testers Delete(int? Id)
        {
            Testers tester = _context.Testers.Find(Id);
            if (tester != null)
            {
                _context.Testers.Remove(tester);
                _context.SaveChanges();
            }
            return tester;
        }

        public IEnumerable<Testers> GetAllTester()
        {
            return _context.Testers.Include(p => p.Project);
        }

        public Testers GetTester(int? Id)
        {
            return _context.Testers.Include(p => p.Project).FirstOrDefault(p => p.Id==Id);
        }

        public Testers Update(Testers testerChanges)
        {
            var tester = _context.Testers.Attach(testerChanges);
            tester.State = EntityState.Modified;
            _context.SaveChanges();
            return testerChanges;
        }
    }
}
