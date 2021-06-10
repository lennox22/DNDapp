using DnDapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DnDapp.Controllers
{
    public class MainContentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AbilityScoresAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.dnd5eapi.co");
            var response = await client.GetAsync($"/api/ability-scores");
            AbilityScores info = await response.Content.ReadAsAsync<AbilityScores>();
            return View(info);
        }
        public IActionResult Alignments()
        {
            return View();
        }
        public IActionResult Backgrounds()
        {
            return View();
        }
        public IActionResult Classes()
        {
            return View();
        }
        public IActionResult Conditions()
        {
            return View();
        }
        public IActionResult DamageTypes()
        {
            return View();
        }
        public IActionResult EquipmentCategories()
        {
            return View();
        }
        public IActionResult Equipment()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult Languages()
        {
            return View();
        }
        public IActionResult MagicItems()
        {
            return View();
        }
        public IActionResult MagicSchools()
        {
            return View();
        }
        public IActionResult Monsters()
        {
            return View();
        }
        public IActionResult Proficiencies()
        {
            return View();
        }
        public IActionResult Races()
        {
            return View();
        }
        public IActionResult Rules()
        {
            return View();
        }
        public IActionResult RuleSection()
        {
            return View();
        }
        public IActionResult Skills()
        {
            return View();
        }
        public IActionResult Spells()
        {
            return View();
        }
        public IActionResult StartingEquipment()
        {
            return View();
        }
        public IActionResult Subclasses()
        {
            return View();
        }
        public IActionResult Subraces()
        {
            return View();
        }
        public IActionResult Traits()
        {
            return View();
        }
        public IActionResult WeaponProperties()
        {
            return View();
        }
    }
}
