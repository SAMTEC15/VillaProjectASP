using MagicVilla.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla.Data
{
    public static class VillaStore
    {
        public static  List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id=1,FirstName="Pool View", LastName = "Front View", Sqft = 100, Occupancy = 4},
                new VillaDTO{Id=2,FirstName="Beach View", LastName = "Back View", Sqft = 200, Occupancy = 3}
            };
    }
}
