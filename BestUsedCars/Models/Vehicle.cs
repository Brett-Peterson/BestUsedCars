using BestUsedCars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestUsedCars.Models
{
    public class PurchasedVehicle
    {
        //This Vehicle reflects the PurchasedVehicle table in database
        //I will use the Vehicle Vehicle Identification Number VIN as my Primary Key
        //LotId is a self generated number for business use
        //I want to set it up as a 3 step process PurchasedVehicle to CurrentVehicle to SoldVehicle 
        public int LotId { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }       
        public string Model { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
        public double Cost { get; set; }
        public string SellerName { get; set; }
        public DateTime PurchaseDate { get; set; }
       
    }

    public class CurrentVehicle : PurchasedVehicle
    {
         //public string VIN { get; set; } redundant
         public string PicId { get; set; }        
         public double RepairCost { get; set; }
         public double PrepCost { get; set; }
         public double OtherCost { get; set; }
         public double TotalCost { get; set; }
         public double ListedPrice { get; set; }

    }
    public class SoldVehicle : CurrentVehicle
    {
        //public string VIN { get; set; }   redundant           
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public double SalePrice { get; set; }
        public DateTime SalesDate { get; set; }
        public string SalesAgent { get; set; }
        }
         
}


