﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Models;

namespace MvcCoreAdoNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
