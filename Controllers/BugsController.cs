using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugReportingManagement.Models;
using BugReportingManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using BugReportingManagement.Helper;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace BugReportingManagement.Controllers
{
    public class BugsController : Controller
    {
        BugAPI api = new BugAPI();
        private readonly IBugRepository bugRepository;
        private readonly IBugPriorityRepository bugPriorityRepository;
        private readonly IBugStatusRepository bugStatusRepository;
        private readonly IProjectRepository projectRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public BugsController(IBugRepository bugRepository, IBugPriorityRepository bugPriorityRepository, IBugStatusRepository bugStatusRepository,
            IProjectRepository projectRepository, IHostingEnvironment hostingEnvironment) //IHostEnvironment injected to get the physical path to the wwwroot folder
        {
            this.bugRepository = bugRepository;
            this.bugPriorityRepository = bugPriorityRepository;
            this.bugStatusRepository = bugStatusRepository;
            this.projectRepository = projectRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Bugs
        [Authorize]
        //public ActionResult Index()
        //{
        //    var model = bugRepository.GetAllBugs();
        //    return View(model);
        //}
        public async Task<IActionResult> Index()
        {
            List<Bugs> bugs = new List<Bugs>();
            HttpClient Client = api.Initial();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message = await Client.GetAsync("api/bugs");

            if (message.IsSuccessStatusCode)
            {
                var result = message.Content.ReadAsStringAsync().Result;
                bugs = JsonConvert.DeserializeObject<List<Bugs>>(result);
            }
            return View(bugs);
        }

        [Authorize]
        // GET: Bugs/Details/5
        //public ActionResult Details(int? Id)
        //{
        //    Bugs bug = bugRepository.GetBugs(Id.Value);

        //    if (bug == null)
        //    {
        //        Response.StatusCode = 404;
        //        return View("BugSearchedNotFound", Id.Value);
        //    }

        //    return View(bug);
        //}

        public async Task<IActionResult> Details(int? Id)
        {
            var bug = new Bugs();
            HttpClient Client = api.Initial();
            HttpResponseMessage message = await Client.GetAsync($"api/bugs/{Id}");
            if (message.IsSuccessStatusCode)
            {
                var result = message.Content.ReadAsStringAsync().Result;
                bug = JsonConvert.DeserializeObject<Bugs>(result);
            }

            return View(bug);
        }

        // GET: Bugs/Create
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {

            ViewData["BugPriorityId"] = new SelectList(bugPriorityRepository.GetAllBugPriorities(), "Id", "BugPriorityType");
            ViewData["BugStatusId"] = new SelectList(bugStatusRepository.GetAllBugStatus(), "Id", "BugStatusType");
            ViewData["ProjectId"] = new SelectList(projectRepository.GetAllProjects(), "Id", "Name");
            return View();
        }

        // POST: Bugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        //public ActionResult Create([Bind("Id,ProjectId,BugPriorityId,BugStatusId,BugCreatedBy,BugCreatedOn,BugClosedBy,BugClosedOn,BugResolutionSummary,Document")] BugsCreateViewModel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            string uniqueFileName = ProcessUploadedDocument(model); //Calling the method ProcessUploadedDocuments

        //            //Create new Bugs object and copy the bug related properties from the model object to it


        //            Bugs newBug = new Bugs
        //            {
        //                ProjectId = model.ProjectId,
        //                BugPriorityId = model.BugPriorityId,
        //                BugStatusId = model.BugStatusId,
        //                BugCreatedBy = model.BugCreatedBy,
        //                BugCreatedOn = model.BugCreatedOn,
        //                BugClosedBy = model.BugClosedBy,
        //                BugClosedOn = model.BugClosedOn,
        //                BugResolutionSummary = model.BugResolutionSummary,
        //                Attachment = uniqueFileName
        //            };
        //            bugRepository.Add(newBug);
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View();
        //    }
        //    catch
        //    {
        //        return NotFound();
        //    }

        //}

        public ActionResult Create([Bind("Id,ProjectId,BugPriorityId,BugStatusId,BugCreatedBy,BugCreatedOn,BugClosedBy,BugClosedOn,BugResolutionSummary,Document")]BugsCreateViewModel bug)
        {

            HttpClient Client = api.Initial();

            //HTTP POST
            var postTask = Client.PostAsJsonAsync<BugsCreateViewModel>("api/bugs", bug);
            //postTask.Wait();

            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: Bugs/Edit/5
        [HttpGet]
        [Authorize]
        public ActionResult Edit(int? Id)
        {
            Bugs bug = bugRepository.GetBugs(Id.Value);

            if (bug == null)
            {
                Response.StatusCode = 404;
                return View("BugSearchedNotFound", Id.Value);
            }

            //Instance of Bugs created and populate with data retrieved from Database
            //Bugs bugs = new Bugs
            BugsEditViewModel bugs = new BugsEditViewModel
            {
                Id = bug.Id,
                ProjectId = bug.ProjectId,
                BugPriorityId = bug.BugPriorityId,
                BugStatusId = bug.BugStatusId,
                BugCreatedBy = bug.BugCreatedBy,
                BugCreatedOn = bug.BugCreatedOn,
                BugClosedBy = bug.BugClosedBy,
                BugClosedOn = bug.BugClosedOn,
                BugResolutionSummary = bug.BugResolutionSummary,
                ExistingDocument = bug.Attachment
            };

            if (bugs == null)
            {
                return NotFound();
            }
            ViewData["BugPriorityId"] = new SelectList(bugPriorityRepository.GetAllBugPriorities(), "Id", "BugPriorityType");
            ViewData["BugStatusId"] = new SelectList(bugStatusRepository.GetAllBugStatus(), "Id", "BugStatusType");
            ViewData["ProjectId"] = new SelectList(projectRepository.GetAllProjects(), "Id", "Name");
            return View(bugs);
        }

        // POST: Bugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind("Id,ProjectId,BugPriorityId,BugStatusId,BugCreatedBy,BugCreatedOn,BugClosedBy,BugClosedOn,BugResolutionSummary,Document")] BugsEditViewModel model)
        {
            Bugs bug = bugRepository.GetBugs(model.Id);

            try
            {
                if (ModelState.IsValid)
                {
                    bug.ProjectId = model.ProjectId;
                    bug.BugStatusId = model.BugStatusId;
                    bug.BugPriorityId = model.BugPriorityId;
                    bug.BugCreatedBy = model.BugCreatedBy;
                    bug.BugCreatedOn = model.BugCreatedOn;
                    bug.BugClosedBy = model.BugClosedBy;
                    bug.BugClosedOn = model.BugClosedOn;
                    bug.BugResolutionSummary = model.BugResolutionSummary;

                    if (model.Document != null)
                    {
                        bug.Attachment = ProcessUploadedDocument(model); //Upload document to server
                    }


                    bugRepository.Update(bug);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return NotFound();
            }
            return View();
        }

        private string ProcessUploadedDocument(BugsCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.Document != null) //if document property is not null - user selected a file
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "documents"); //To get to the documents folder we will use the Path class to combine wwwroot and the documents folders
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Document.FileName;  //We use the Guid class to ensure the uploaded files are unique                                                                                                    
                string filePath = Path.Combine(uploadsFolder, uniqueFileName); //Combine uploadsFolders and the uniqueFileName
                model.Document.CopyTo(new FileStream(filePath, FileMode.Create)); //Copy the uploaded file and create in the server
            }
            return uniqueFileName;
        }

        //GET: Bugs/Delete/5
        [Authorize(Roles = "Admin")]
        //public ActionResult Delete(int? Id)
        //{
        //    //Bugs model = null;
        //    if (Id == null)
        //    {
        //        return NotFound();
        //    }
        //    Bugs bug = bugRepository.GetBugs(Id);
        //    if (bug == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(bug);
        //}

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int Id)
        {
            //Bugs model = null;
            var bug = new Bugs();
            HttpClient Client = api.Initial();
            HttpResponseMessage message = await Client.GetAsync($"api/bugs/{Id}");
            if (message.IsSuccessStatusCode)
            {
                var result = message.Content.ReadAsStringAsync().Result;
                bug = JsonConvert.DeserializeObject<Bugs>(result);
            }

            return View(bug);
        }

        // POST: Bugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        //public ActionResult DeleteConfirmed(int Id)
        //{
        //    try
        //    {
        //        bugRepository.Delete(Id);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            Bugs bug = new Bugs();
            HttpClient Client = api.Initial();
            HttpResponseMessage message = await Client.DeleteAsync($"api/bugs/{Id}");

            return RedirectToAction("Index");
        }
    } 
}

