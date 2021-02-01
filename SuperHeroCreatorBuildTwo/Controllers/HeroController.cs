using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroCreatorBuildTwo.Data;
using SuperHeroCreatorBuildTwo.Models;

namespace SuperHeroCreatorBuildTwo.Controllers
{
    public class HeroController : Controller
    {
        public ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Hero
        public IActionResult Index()
        {
            List<SuperHero> SuperHeros = _context.SuperHeros.ToList();

            return View(SuperHeros);
        }

        // GET: Hero/Details/5
        public IActionResult Details(int id)
        {
            SuperHero details = _context.SuperHeros.Where(hero => hero.Id == id).SingleOrDefault();
            return View(details);
        }

        // GET: Hero/Create
        public IActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: Hero/Create
        [HttpPost]
        public IActionResult Create(SuperHero superhero)
        {

                _context.SuperHeros.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));


        }

        // GET: Hero/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            SuperHero edit = _context.SuperHeros.Where(hero => hero.Id == id).SingleOrDefault();  // creating the modified version of the superhero
            return View(edit);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, SuperHero superHero)
        {
            _context.SuperHeros.Update(superHero);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); // needs to be changed to home controller
        }

        // GET: Hero/Delete/5
        public IActionResult Delete(int id)
        {
            SuperHero delete = _context.SuperHeros.Where(hero => hero.Id == id).SingleOrDefault();
            return View(delete);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, SuperHero superHero)
        {
            _context.SuperHeros.Remove(superHero);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
