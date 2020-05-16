using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Core.Services
{
    public interface IWaterLevelRepository
    {
        WaterLevel Add(WaterLevel addWaterLevel);
        WaterLevel Get(int id);
        IEnumerable<WaterLevel> GetAll();
        WaterLevel Update(WaterLevel updateWaterLevel);
        void Remove(WaterLevel removeWaterLevel);
    }
}
