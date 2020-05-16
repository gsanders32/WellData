using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellData.Core.Models;

namespace WellData.ApiModels
{
    public static class UnitTypeMappingExtenstions
    {
        public static UnitTypeModel ToApiModel(this UnitType UnitType)
        {
            return new UnitTypeModel
            {
                Id = UnitType.Id,
                DisplayName = UnitType.DisplayName,
                Abbreviation = UnitType.Abbreviation
            };
        }

        public static UnitType ToDomainModel(this UnitTypeModel UnitTypeModel)
        {
            return new UnitType
            {
                Id = UnitTypeModel.Id,
                DisplayName = UnitTypeModel.DisplayName,
                Abbreviation = UnitTypeModel.Abbreviation
            };
        }

        public static IEnumerable<UnitTypeModel> ToApiModels(this IEnumerable<UnitType> UnitTypes)
        {
            return UnitTypes.Select(x => x.ToApiModel());
        }

        public static IEnumerable<UnitType> ToDomainModels(this IEnumerable<UnitTypeModel> UnitTypeModels)
        {
            return UnitTypeModels.Select(x => x.ToDomainModel());
        }
    }
}
