﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CBProductions.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddVideo()
        {
            return PartialView("~/Views/Admin/AddVideo.cshtml");
        }

        public IActionResult AddList()
        {
            return PartialView("~/Views/Admin/AddList.cshtml");
        }
    }
}