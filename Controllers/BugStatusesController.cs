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
    public class BugStatusesController : Controller
    {
        private readonly IBugStatusRepository bugStatusRepository;

        public BugStatusesController(IBugStatusRepository bugStatusRepository)
        {
            this.bugStatusRepository = bugStatusRepository;
        }

        // GET: BugStatuses
        [HttpGet]
        public ActionResult Index()
        {
            var model = bugStatusRepository.GetAllBugStatus();
            return View(model);
        }

        // GET: BugStatuses/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugStatuse = bugStatusRepository.GetBugStatus(id);
            if (bugStatuse == null)
            {
                return NotFound();
            }

            return View(bugStatuse);
        }

        // GET: BugStatuses/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BugStatuses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,BugStatusType")] BugStatuses bugStatus)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BugStatuses newBugStatus = bugStatusRepository.Add(bugStatus);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        // GET: BugStatuses/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var bugStatus = bugStatusRepository.GetBugStatus(id); //Receive Status data from database
            if (id == null)
            {
                return NotFound();
            }

            //Instance of BugStatuses created and populated with data retrieved from database

            BugStatuses bugStatuses = new BugStatuses
            {
                Id = bugStatus.Id,
                BugStatusType = bugStatus.BugStatusType
            };
            return View(bugStatuses);
        }

        // POST: BugStatuses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,BugStatusType")] BugStatuses model)
        {
            BugStatuses bugStatus = bugStatusRepository.GetBugStatus(model.Id);

            try
            {
                if (ModelState.IsValid)
                {
                    bugStatus.BugStatusType = model.BugStatusType;
                    bugStatusRepository.Update(bugStatus);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        // GET: BugStatuses/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugStatus = bugStatusRepository.GetBugStatus(id);

            if (bugStatus == null)
            {
                return NotFound();
            }

            return View(bugStatus);
        }

        // POST: BugStatuses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var bugStatus = bugStatusRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool BugStatusesExists(int id)
        //{
        //    return _context.BugStatuses.Any(e => e.Id == id);
        //}
    }
}
