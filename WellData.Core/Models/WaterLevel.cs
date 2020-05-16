using System;
using System.Collections.Generic;
using System.Text;

namespace WellData.Core.Models
{
    public class WaterLevel
    {
        public int Id { get; set; }
        public int WellId { get; set; }
        public DateTime Date { get; set; }
        public double DepthToWater { get; set; }
        public int UnitTypeId { get; set; }
        public UnitType UnitType { get; set; }
    }
}