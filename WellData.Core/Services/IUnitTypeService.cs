using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public interface IUnitTypeService
    {
        UnitType Add(UnitType addUnitType);
        UnitType Get(int id);
        IEnumerable<UnitType> GetAll();
        void Remove(UnitType removeUnitType);
        UnitType Update(UnitType updateUnitType);
    }
}
