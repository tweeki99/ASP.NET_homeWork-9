using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWork9.Models;
using HomeWork9.DataAccess;

namespace HomeWork9.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;
        public HomeController(DataContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var posts = db.Posts.ToList();
            ViewData["Posts"] = posts;
            return View();
        }
    }
}
