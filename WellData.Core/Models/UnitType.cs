using System;
using System.Collections.Generic;
using System.Text;

namespace WellData.Core.Models
{
    public class UnitType
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Abbreviation { get; set; }
        public ICollection<Flow> Flows { get; set; }
    }
}
