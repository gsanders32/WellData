using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellData.Core.Models;

namespace WellData.ApiModels
{
    public class WellModel
    {
        public int Id { get; set; }
        public int DistrictNumber { get; set; }
        public int Elevation { get; set; }
        public IEnumerable<FlowModel> Flows { get; set; }
        public IEnumerable<WaterLevelModel> WaterLevels { get; set; }

    }
}
