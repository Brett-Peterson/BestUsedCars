using BestUsedCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUsedCars.Models
{
    public class Vehicle
    {
        //I will use the Vehicle Vehicle Identification Number VIN as my Primary Key
        //LotId is a self generated number for business use
        public int LotId { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double SalePrice { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
        public string PicId { get; set; }
    }
}

