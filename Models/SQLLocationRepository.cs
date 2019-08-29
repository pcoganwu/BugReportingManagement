using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class SQLLocationRepository : ILocationRepository
    {
        private readonly AppDbContext _context;

        public SQLLocationRepository(AppDbContext context)
        {
            _context = context;
        }
        public Locations Add(Locations location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
            return location;
        }

        public Locations Delete(int? Id)
        {
            Locations location = _context.Locations.Find(Id);
            if (location != null)
            {
                _context.Locations.Remove(location);
                _context.SaveChanges();
            }
            return location;
        }

        public IEnumerable<Locations> GetAllBugLocations()
        {
            return _context.Locations.Include(t => t.Tester);
        }

        public Locations GetLocation(int? Id)
        {
            return _context.Locations.Include(t => t.Tester).FirstOrDefault(t => t.Id == Id);
        }

        public Locations Update(Locations locationChanges)
        {
            var location = _context.Locations.Attach(locationChanges);
            location.State = EntityState.Modified;
            _context.SaveChanges();
            return locationChanges;
        }
    }
}
