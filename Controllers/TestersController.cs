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
    public class TestersController : Controller
    {
        private readonly ITesterRepository testerRepository;
        private readonly IProjectRepository projectRepository;

        public TestersController(ITesterRepository testerRepository, IProjectRepository projectRepository)
        {
            this.testerRepository = testerRepository;
            this.projectRepository = projectRepository;
        }

        // GET: Testers
        [HttpGet]
        public ActionResult Index()
        {
            var model = testerRepository.GetAllTester();
            return View(model);
        }

        // GET: Testers/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tester = testerRepository.GetTester(id);
            if (tester == null)
            {
                return NotFound();
            }
            return View(tester);
        }

        // GET: Testers/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(projectRepository.GetAllProjects(), "Id", "Name");
            return View();
        }

        // POST: Testers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,ProjectId,FirstName,LastName")] Testers tester)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    testerRepository.Add(tester);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        // GET: Testers/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var tester = testerRepository.GetTester(id); //Retrieve Testers data from database

            if (id == null)
            {
                return NotFound();
            }

            //Instance of Testers created and populated with data retrieved from database

            Testers testers = new Testers
            {
                Id = tester.Id,
                ProjectId = tester.ProjectId,
                FirstName = tester.FirstName,
                LastName = tester.LastName
            };
            ViewData["ProjectId"] = new SelectList(projectRepository.GetAllProjects(), "Id", "Name");
            return View(testers);
        }

        // POST: Testers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,ProjectId,FirstName,LastName")] Testers model)
        {
            Testers tester = testerRepository.GetTester(model.Id);

            try
            {
                if (ModelState.IsValid)
                {
                    tester.ProjectId = model.ProjectId;
                    tester.FirstName = model.FirstName;
                    tester.LastName = model.LastName;
                    testerRepository.Update(tester);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();        
         }

        // GET: Testers/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tester = testerRepository.GetTester(id);

            if (tester == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(projectRepository.GetAllProjects(), "Id", "Name");
            return View(tester);
        }

        // POST: Testers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var tester = testerRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }

        //private bool TestersExists(int id)
        //{
        //    return _context.Testers.Any(e => e.Id == id);
        //}
    }
}
