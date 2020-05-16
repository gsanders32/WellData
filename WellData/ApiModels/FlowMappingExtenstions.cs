using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellData.Core.Models;

namespace WellData.ApiModels
{
    public static class FlowMappingExtenstions
    {
        public static FlowModel ToApiModel(this Flow Flow)
        {
            return new FlowModel
            {
                Id = Flow.Id,
                WellId = Flow.WellId,
                Date = Flow.Date,
                Rate = Flow.Rate,
                UnitTypeId = Flow.UnitTypeId
            };
        }

        public static Flow ToDomainModel(this FlowModel FlowModel)
        {
            return new Flow
            {
                Id = FlowModel.Id,
                WellId = FlowModel.WellId,
                Date = FlowModel.Date,
                Rate = FlowModel.Rate,
                UnitTypeId = FlowModel.UnitTypeId
            };
        }

        public static IEnumerable<FlowModel> ToApiModels(this IEnumerable<Flow> Flows)
        {
            return Flows.Select(x => x.ToApiModel());
        }

        public static IEnumerable<Flow> ToDomainModels(this IEnumerable<FlowModel> FlowModels)
        {
            return FlowModels.Select(x => x.ToDomainModel());
        }
    }
}
