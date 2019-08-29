using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugReportingManagement.Models;
using BugReportingManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugReportingManagement.Controllers
{
    public class AccountController : Controller
    {
        //Inject UserManager and SignInManager into our Controller and use the built-in Identity user class
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "home");
        }

        //Remote validation for already in use email address
        [HttpPost][HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            //Check to see if the provided email is not in use

            if (user == null)
            {
                //Return type is Json because ASP.NET Core MVC uses Jquery validate method to call the server side function
                //ASP.NET Core issues an Ajax call to the method

                return Json(true); 
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }

        // GET: /<controller>/
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            //Check if incoming model object is valid
            if (ModelState.IsValid)
            {
                //if model is valid create a new user of type IdentityUser
                var user = new ApplicationUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    ProjectName = model.ProjectName,
                    UserName = model.Email,
                    Email = model.Email
                };
                var result = await userManager.CreateAsync(user, model.Password); //Password hashed and securely stored

                //Check if user is successfully created, then sign the user in
                if(result.Succeeded)
                {
                    //if we are already signed in and the user has an Admin role, that should remained signed after registering a new user
                    if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Administration");
                    }
                    await signInManager.SignInAsync(user, isPersistent: false); //Create a session cookie
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors) //result object has errors collection properties, loop thorugh each error and add to the StateModel Object
                {                                   //and display errors in the Register view
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        // GET: /<controller>/
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            //Check if incoming model object is valid
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false); 

                //Check if user is successfully signed in
                if (result.Succeeded)
                {
                    //Redirects user to the requested URL, for malicious attack we should only redirect to local URL
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}