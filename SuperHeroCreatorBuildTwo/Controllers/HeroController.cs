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
            SuperHero BigBertha = new SuperHero();
            BigBertha.Name ="";
            BigBertha.AlterEgo ="";
            BigBertha.PrimaryAbility = "";
            BigBertha.SecondaryAbility = "";
            BigBertha.HeroImage = "";
            SuperHero Doorman = new SuperHero();
            Doorman.Name = "";
            Doorman.AlterEgo = "";
            Doorman.PrimaryAbility = "";
            Doorman.SecondaryAbility = "";
            Doorman.HeroImage = "";
            SuperHero Flatman = new SuperHero();
            Flatman.Name = "";
            Flatman.AlterEgo = "";
            Flatman.PrimaryAbility = "";
            Flatman.SecondaryAbility = "";
            Flatman.HeroImage = "";
            SuperHero GoodBoy = new SuperHero();
            GoodBoy.Name = "";
            GoodBoy.AlterEgo = "";
            GoodBoy.PrimaryAbility = "";
            GoodBoy.SecondaryAbility = "";
            GoodBoy.HeroImage = "";
            SuperHero MrImmortal = new SuperHero();
            MrImmortal.Name = "";
            MrImmortal.AlterEgo = "";
            MrImmortal.PrimaryAbility = "";
            MrImmortal.SecondaryAbility = "";
            MrImmortal.HeroImage = "";


            return View(SuperHeros);
        }

        // GET: Hero/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Hero/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        public IActionResult Create(SuperHero superhero)
        {

                _context.SuperHeros.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction("Index");


        }

        // GET: Hero/Edit/5
        public IActionResult Edit(int id)
        {
            SuperHero edit = _context.SuperHeros.Where(hero => hero.Id == id).FirstOrDefault();  // creating the modified version of the superhero
            return View();
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
            SuperHero delete = _context.SuperHeros.Where(hero => hero.Id == id).FirstOrDefault();
            return View();
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
