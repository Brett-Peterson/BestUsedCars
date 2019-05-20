using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUsedCars.Models
{
    public interface IVehicleRepository
    {
        IQueryable<PurchasedVehicle> Vehicles { get; }
    }
}
