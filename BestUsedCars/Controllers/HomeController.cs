using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestUsedCars.Models;
using BestUsedCars.Controllers;
using Microsoft.EntityFrameworkCore;

namespace BestUsedCars
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult BlueBook()
        {
            return View();
        }
        public IActionResult CurrentList()
        {
           // await CreateCurrentVehicleListAsync();
            return  View(CreateCurrentVehicleListAsync());
        }
        private async Task CreateCurrentVehicleListAsync()
        {
            using (var context = new VehiclesContext())
            {
                List<PurchasedVehicle> CurrentVehicles = await context.Vehicles.ToListAsync();
                foreach (var v in CurrentVehicles)
                {
                    Console.WriteLine($"{v.VIN}{v.Year}{v.Make}{v.Model}{v.Color}{v.SalePrice}");
                }
            }
            Console.WriteLine();
        }
    }
}
