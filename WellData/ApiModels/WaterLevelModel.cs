using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WellData.ApiModels
{
    public class WaterLevelModel
    {
        public int Id { get; set; }
        public int WellId { get; set; }
        public DateTime Date { get; set; }
        public double DepthToWater { get; set; }
        public int UnitTypeId { get; set; }
        public string UnitType { get; set; }
    }
}
