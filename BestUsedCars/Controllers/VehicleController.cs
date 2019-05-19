using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestUsedCars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BestUsedCars.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private async Task CreateCurrentVehicleListAsync()
        {
            using (var context = new VehiclesContext())
            {
                List<Vehicle> CurrentVehicles = await context.Vehicles.ToListAsync();
                foreach (var v in CurrentVehicles)
                {
                    Console.WriteLine($"{v.VIN}{v.Year}{v.Make}{v.Model}{v.Color}{v.Miles}{v.Cost}");
                }
            }
            Console.WriteLine();
        }
        private async Task ProcessPurchaseFormAsync(string vin, int year,string make, string model, string color, int miles,int cost, string sellerName,DateTime purchaseDate)
        {
            using (var context = new VehiclesContext())
            {
                var vehicle = new Vehicle
                {
                    VIN = vin,
                    Year = year,
                    Make = make,
                    Model = model,
                    Color = color,
                    Miles = miles,
                    Cost = cost,
                    SellerName = sellerName,
                    PurchaseDate = purchaseDate

                };
            }
        }
        private async Task UpdateVehicleCostAsync()
        {
            using (var context = new VehiclesContext())
            {
                //I need to find out how to grab a VIN from an Update vehicle form
               // Vehicle vehicle = await context.Vehicles.Where
                    

            }
        }
    }
}