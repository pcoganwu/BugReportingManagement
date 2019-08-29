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
    public class LocationsController : Controller
    {
        private readonly ILocationRepository locationRepository;
        private readonly ITesterRepository testerRepository;

        public LocationsController(ILocationRepository locationRepository, ITesterRepository testerRepository)
        {
            this.locationRepository = locationRepository;
            this.testerRepository = testerRepository;
        }

        // GET: Locations
        [HttpGet]
        public ActionResult Index()
        {
            var model = locationRepository.GetAllBugLocations();
            return View(model);
        }

        // GET: Locations/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = locationRepository.GetLocation(id);

            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // GET: Locations/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["TesterId"] = new SelectList(testerRepository.GetAllTester(), "Id", "FirstName");
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,TesterId,Name")] Locations location)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    locationRepository.Add(location);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
           
            ViewData["TesterId"] = new SelectList(testerRepository.GetAllTester(), "Id", "FullName", location.TesterId);
            return View(location);
        }

        // GET: Locations/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
                if (id == null)
                {
                    return NotFound();
                }
                var location = locationRepository.GetLocation(id); //Retrieve Locations data from database

                //Instance of Locations created and populated with data retrieved from Database

                Locations locations = new Locations
                {
                    Id = location.Id,
                    TesterId = location.TesterId,
                    Name = location.Name
                };

                if (locations == null)
                {
                    return NotFound();

                }
                ViewData["TesterId"] = new SelectList(testerRepository.GetAllTester(), "Id", "FullName", locations.TesterId);
                return View(locations);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,TesterId,Name")] Locations model)
        {
            Locations location = locationRepository.GetLocation(model.Id);

            try
            {
                if (ModelState.IsValid)
                {
                    location.TesterId = model.TesterId;
                    location.Name = model.Name;
                    locationRepository.Update(location);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        // GET: Locations/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Locations location = locationRepository.GetLocation(id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            locationRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool LocationsExists(int id)
        //{
        //    return _context.Locations.Any(e => e.Id == id);
        //}
    }
}
