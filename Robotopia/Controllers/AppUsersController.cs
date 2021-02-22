using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Robotopia.Data;
using Robotopia.Models;
using Robotopia.Models.ServiceModels;
using Robotopia.Services;

namespace Robotopia.Controllers
{
    public class AppUsersController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserService appUserService;

        public AppUsersController(ApplicationDbContext context, UserManager<AppUser> userManager, IAppUserService appUserService)
        {
            this.userManager = userManager;
            this.appUserService = appUserService;
        }

        // GET: AppUsers
        public async Task<IActionResult> Index()
        {
            return View(await appUserService.GetAllUsers());
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await appUserService.GetUser(id);

            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }


        [Authorize]
        public async Task<IActionResult> UserPage()
        {
            int userId = int.Parse(userManager.GetUserId(User));
            ServiceAppUserModel user = await appUserService.GetUser(userId);
            
            return View(user);
        }
       
    }
}
