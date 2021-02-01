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
            //_context.SuperHeros.Remove() ;
            _context.SaveChanges();
            PopulateHeros(_context); // attempt to populate database with Heros
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
        private static void PopulateHeros(ApplicationDbContext context)
        {
            List<SuperHero> CheckHero = context.SuperHeros.ToList();
            List<string> checkForId = CheckHero.Select(h => h.AlterEgo).ToList();
            foreach (var item in checkForId)
            {
                if (checkForId.Contains("Big Bertha") || checkForId.Contains("DoorMan") || checkForId.Contains("FlatMan") || checkForId.Contains("GoodBoy") || checkForId.Contains("Mr. Immortal"))
                {
                    break;
                }
                else
                {
                    BuildHeros(context);
                    break;
                }
            }

        }
        private static void BuildHeros(ApplicationDbContext context)
        {
            SuperHero BigBertha = new SuperHero();
            BigBertha.Name = "Ashley Crawford";
            BigBertha.AlterEgo = "Big Bertha";
            BigBertha.PrimaryAbility = "Body Transformation";
            BigBertha.SecondaryAbility = "SuperHuman Strength";
            BigBertha.CatchPhrase = "Honest, I know you wouldn't think it to look at me...but I have a body that could stop traffic.";
            SuperHero Doorman = new SuperHero();
            Doorman.Name = "Demarr Davis";
            Doorman.AlterEgo = "DoorMan";
            Doorman.PrimaryAbility = "DarkForce Telepotation";
            Doorman.SecondaryAbility = "Death Sense";
            Doorman.CatchPhrase = "Maneuver 33... it's just crazy enough to work";
            SuperHero Flatman = new SuperHero();
            Flatman.Name = "Val Ventura";
            Flatman.AlterEgo = "FlatMan";
            Flatman.PrimaryAbility = "Flat Body";
            Flatman.SecondaryAbility = "Plasticity";
            Flatman.CatchPhrase = "Great Lakes Initiative-- Initiate!!";
            SuperHero GoodBoy = new SuperHero();
            GoodBoy.Name = "Goodness Silva";
            GoodBoy.AlterEgo = "GoodBoy";
            GoodBoy.PrimaryAbility = "Lycanthropy Shapeshifting";
            GoodBoy.SecondaryAbility = "Genderfluid";
            GoodBoy.CatchPhrase = "Look on the bright side. At least I'm still alive. ";
            SuperHero MrImmortal = new SuperHero();
            MrImmortal.Name = "Craig Hollis";
            MrImmortal.AlterEgo = "Mr. Immortal";
            MrImmortal.PrimaryAbility = "Retroactive Immortality";
            MrImmortal.SecondaryAbility = "Healing Factor";
            MrImmortal.CatchPhrase = "Hey! Guys! You'll never guess! I just found out... I'm Homo supreme! ";
            context.SuperHeros.Add(BigBertha);
            context.SuperHeros.Add(Doorman);
            context.SuperHeros.Add(Flatman);
            context.SuperHeros.Add(GoodBoy);
            context.SuperHeros.Add(MrImmortal);
            context.SaveChanges();
        }
    }
}
