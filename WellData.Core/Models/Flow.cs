using System;
using System.Collections.Generic;
using System.Text;

namespace WellData.Core.Models
{
    public class Flow
    {
        public int Id { get; set; }
        public int WellId { get; set; }
        public DateTime Date { get; set; }
        public double Rate { get; set; }
        public int UnitTypeId { get; set; }
        public UnitType UnitType { get; set; }

    }
}
