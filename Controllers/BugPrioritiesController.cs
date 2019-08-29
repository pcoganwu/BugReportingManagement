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
    public class BugPrioritiesController : Controller
    {
        private readonly IBugPriorityRepository bugPriorityRepository;

        public BugPrioritiesController(IBugPriorityRepository bugPriorityRepository)
        {
            this.bugPriorityRepository = bugPriorityRepository;
        }

        // GET: BugPriorities
        [HttpGet]
        public ActionResult Index()
        {
            var model = bugPriorityRepository.GetAllBugPriorities();
            return View(model);
        }

        // GET: BugPriorities/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPriority = bugPriorityRepository.GetBugPriority(id);
            if (bugPriority == null)
            {
                return NotFound();
            }

            return View(bugPriority);
        }

        // GET: BugPriorities/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BugPriorities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,BugPriorityType")] BugPriorities bugPriority)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BugPriorities newBugPriority = bugPriorityRepository.Add(bugPriority);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BugPriorities/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var bugPriority = bugPriorityRepository.GetBugPriority(id); //Receive Priority data from database

            if (id == null)
            {
                return NotFound();
            }

            //Instance of BugPriorities created and populated with data retrieved from database

            BugPriorities bugPriorities = new BugPriorities
            {
                Id = bugPriority.Id,
                BugPriorityType = bugPriority.BugPriorityType
            };
            return View(bugPriorities);
        }

        // POST: BugPriorities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,BugPriorityType")] BugPriorities model)
        {
            BugPriorities bugPriority = bugPriorityRepository.GetBugPriority(model.Id);

            if (ModelState.IsValid)
            {
                try
                {
                    bugPriority.BugPriorityType = model.BugPriorityType;
                    bugPriorityRepository.Update(bugPriority);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!BugPrioritiesExists(bugPriority.Id))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                    return NotFound();
                }
            }
            return View();
        }

        // GET: BugPriorities/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPriority = bugPriorityRepository.GetBugPriority(id);

            if (bugPriority == null)
            {
                return NotFound();
            }

            return View(bugPriority);
        }

        // POST: BugPriorities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var bugPriority = bugPriorityRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
