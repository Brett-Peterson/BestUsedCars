using BestUsedCars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestUsedCars.Models
{
    public class Vehicle
    {
        //I will use the Vehicle Vehicle Identification Number VIN as my Primary Key
        //LotId is a self generated number for business use
       
        public int LotID { get; set; }
        
        [Required]
        [StringLength (17)]
        public string VIN { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [StringLength (30)]
        public string Make { get; set; }
        [Required]
        [StringLength (30)]
        public string Model { get; set; }
        public double SalePrice { get; set; }
        [Required]
        [StringLength(20)]
        public string Color { get; set; }
        public int Miles { get; set; }
        [StringLength(20)]
        public string PicId { get; set; }
    }
}

