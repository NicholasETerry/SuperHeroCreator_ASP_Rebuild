using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperHeroCreatorBuildTwo.Data;
using SuperHeroCreatorBuildTwo.Models;

namespace SuperHeroCreatorBuildTwo.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Hero
        public IActionResult Index()
        {
            List<SuperHero> SuperHeros = _context.SuperHeros.ToList();

            return View(SuperHeros);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
