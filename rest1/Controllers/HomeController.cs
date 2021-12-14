using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rest1.Models;
using System;
using System.Collections.Generic;  
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace rest1.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult Index()
        {
            return View(db.Products);
        }

    }
}
