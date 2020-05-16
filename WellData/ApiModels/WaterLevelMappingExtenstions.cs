using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellData.Core.Models;

namespace WellData.ApiModels
{
    public static class WaterLevelMappingExtenstions
    {
        public static WaterLevelModel ToApiModel(this WaterLevel WaterLevel)
        {
            return new WaterLevelModel
            {
                Id = WaterLevel.Id,
                WellId = WaterLevel.WellId,
                Date = WaterLevel.Date,
                DepthToWater = WaterLevel.DepthToWater,
                UnitTypeId = WaterLevel.UnitTypeId
            };
        }

        public static WaterLevel ToDomainModel(this WaterLevelModel WaterLevelModel)
        {
            return new WaterLevel
            {
                Id = WaterLevelModel.Id,
                WellId = WaterLevelModel.WellId,
                Date = WaterLevelModel.Date,
                DepthToWater = WaterLevelModel.DepthToWater,
                UnitTypeId = WaterLevelModel.UnitTypeId
            };
        }

        public static IEnumerable<WaterLevelModel> ToApiModels(this IEnumerable<WaterLevel> WaterLevels)
        {
            return WaterLevels.Select(x => x.ToApiModel());
        }

        public static IEnumerable<WaterLevel> ToDomainModels(this IEnumerable<WaterLevelModel> WaterLevelModels)
        {
            return WaterLevelModels.Select(x => x.ToDomainModel());
        }
    }
}
