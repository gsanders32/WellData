using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellData.Core.Models;

namespace WellData.ApiModels
{
    public static class WellMappingExtenstions
    {
        public static WellModel ToApiModel(this Well Well)
        {
            return new WellModel
            {
                Id = Well.Id,
                DistrictNumber = Well.DistrictNumber,
                Elevation = Well.Elevation
            };
        }

        public static Well ToDomainModel(this WellModel WellModel)
        {
            return new Well
            {
                Id = WellModel.Id,
                DistrictNumber = WellModel.DistrictNumber,
                Elevation = WellModel.Elevation
            };
        }

        public static IEnumerable<WellModel> ToApiModels(this IEnumerable<Well> Wells)
        {
            return Wells.Select(x => x.ToApiModel());
        }

        public static IEnumerable<Well> ToDomainModels(this IEnumerable<WellModel> WellModels)
        {
            return WellModels.Select(x => x.ToDomainModel());
        }
    }
}
