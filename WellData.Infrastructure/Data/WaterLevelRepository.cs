using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WellData.Core.Models;
using WellData.Core.Services;

namespace WellData.Infrastructure.Data
{
    public class WaterLevelRepository : IWaterLevelRepository
    {
        private readonly AppDbContext _dbContext;

        public WaterLevelRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public WaterLevel Add(WaterLevel addWaterLevel)
        {
            WaterLevel waterLevel = addWaterLevel;
            if (waterLevel != null)
            {
                _dbContext.Add(waterLevel);
                _dbContext.SaveChanges();
                return waterLevel;
            }
            return null;
        }

        public WaterLevel Get(int id)
        {
            WaterLevel waterLevel = _dbContext.WaterLevels.Include(x => x.UnitType).FirstOrDefault(x => x.Id == id);
            if (waterLevel != null)
            {
                return waterLevel;
            }
            return null;
        }

        public IEnumerable<WaterLevel> GetAll()
        {
            var waterLevel = _dbContext.WaterLevels.Include(x => x.UnitType).ToList();
            if (waterLevel != null)
            {
                return waterLevel;
            }
            return null;
        }

        public void Remove(WaterLevel removeWaterLevel)
        {
            WaterLevel waterLevel = _dbContext.WaterLevels.FirstOrDefault(x => x.Id == removeWaterLevel.Id);
            if (waterLevel != null)
            {
                _dbContext.Remove(waterLevel);
                _dbContext.SaveChanges();
            }
        }

        public WaterLevel Update(WaterLevel updateWaterLevel)
        {
            WaterLevel waterLevel = _dbContext.WaterLevels.FirstOrDefault(x => x.Id == updateWaterLevel.Id);
            if (waterLevel != null)
            {
                _dbContext.Entry(waterLevel)
                    .CurrentValues
                    .SetValues(updateWaterLevel);
                _dbContext.Update(waterLevel);
                _dbContext.SaveChanges();
                return waterLevel;
            }
            return null;
        }
    }
}
