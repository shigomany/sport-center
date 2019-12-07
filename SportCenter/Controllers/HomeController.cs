﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SportCenter.AppStart;
using SportCenter.Data;
using SportCenter.Models;
using static SportCenter.Extensions.Extensions;

namespace SportCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly SportCenterContext context;

        public HomeController(SportCenterContext context)
        {
            this.context = context;
            // Init base data, for testing
            if (context.Client.Count() == 0 || context.GroupTrain.Count() == 0)
                StartData.SetupData(ref context);
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var clientRole = context.Client.Include(x => x.IdRoleNavigation).Single(x => x.Email == User.Identity.Name).IdRoleNavigation;
                var role = FromRoleElement(clientRole);

                return View(role);
            }
            return View();
        }

<<<<<<< HEAD
=======
        public IActionResult GroupTrainingText()
        {
            return View();
        }

>>>>>>> 175042a9cbbf8e3ce1d4034954a4438f46cc4c88
        public IActionResult NoAccess()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
