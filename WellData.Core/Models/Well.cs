using System;
using System.Collections.Generic;
using System.Text;

namespace WellData.Core.Models
{
    public class Well
    {
        public int Id { get; set; }
        public int DistrictNumber { get; set; }
        public int Elevation { get; set; }
        public ICollection<Flow> Flows { get; set; }
        public ICollection<WaterLevel> WaterLevels { get; set; }
    }
}
