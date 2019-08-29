using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugReportingManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace BugReportingManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProjectsController : Controller
    {
        private readonly IProjectRepository projectRepository;

        public ProjectsController(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        // GET: Projects
        [HttpGet]
        public ActionResult Index()
        {
            var model = projectRepository.GetAllProjects();
            return View(model);
        }

        // GET: Projects/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = projectRepository.GetProject(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Description,ModifiedOn")] Projects project)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Projects newProject = projectRepository.Add(project);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        // GET: Projects/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var project = projectRepository.GetProject(id); //retrieve Projects data from database

            //Instance of Projects created and populated with data retrieved from database

            Projects projects = new Projects
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                ModifiedOn = project.ModifiedOn
            };
            return View(projects);
        }

        // POST: Projects/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,Name,Description,ModifiedOn")] Projects model)
        {
            var project = projectRepository.GetProject(model.Id);

            try
            {
                if (ModelState.IsValid)
                {
                    project.Name = model.Name;
                    project.Description = model.Description;
                    project.ModifiedOn = model.ModifiedOn;
                    projectRepository.Update(project);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        // GET: Projects/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = projectRepository.GetProject(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var project = projectRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
