using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellData.Core.Models;

namespace WellData.ApiModels
{
    public class UnitTypeModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Abbreviation { get; set; }
    }
}
