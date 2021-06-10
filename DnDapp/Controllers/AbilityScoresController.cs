using DnDapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DnDapp.Controllers
{
    public class AbilityScoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ChaAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.dnd5eapi.co");
            var response = await client.GetAsync($"/api/ability-scores/cha");
            Charisma info = await response.Content.ReadAsAsync<Charisma>();
            return View(info);
        }
        public async Task<IActionResult> ConAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.dnd5eapi.co");
            var response = await client.GetAsync($"/api/ability-scores/con");
            Charisma info = await response.Content.ReadAsAsync<Charisma>();
            return View(info);
        }
    }
}
