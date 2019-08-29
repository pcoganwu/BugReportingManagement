using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugReportingManagement.Models
{
    public class SQLProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _context;
        public SQLProjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public Projects Add(Projects project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public Projects Delete(int? Id)
        {
            Projects project = _context.Projects.Find(Id);
            if (project != null)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
            }
            return project;
        }

        public IEnumerable<Projects> GetAllProjects()
        {
            return _context.Projects;
        }

        public Projects GetProject(int? Id)
        {
            return _context.Projects.Find(Id);
        }

        public Projects Update(Projects projectChanges)
        {
            var project = _context.Projects.Attach(projectChanges);
            project.State = EntityState.Modified;
            _context.SaveChanges();
            return projectChanges;
        }
    }
}
