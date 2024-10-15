using Microsoft.AspNetCore.Mvc;
using MyFinances.DAL;
using MyFinances.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinances.Controllers
{
    public class HomeController : Controller
    {
        private readonly BitcoinService _bitcoinService;

        public HomeController(BitcoinService bitcoinService)
        {
            _bitcoinService = bitcoinService;
        }
        public async Task<IActionResult> Index()
        {
            var bitcoinPrice = await _bitcoinService.GetBitcoinPriceAsync();
            ViewBag.BitcoinPrice = bitcoinPrice.ToString("C", new CultureInfo("en-US"));   
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
