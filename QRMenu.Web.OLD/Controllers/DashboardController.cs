﻿using Microsoft.AspNetCore.Mvc;

namespace QRMenu.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
