﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SZZP2._2.Models;

namespace SZZP2._2.Controllers
{
    public class AdministratorsController : Controller
    {
        public IActionResult Index()
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